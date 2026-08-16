using System;
using System.Collections.Generic;
using StardewValley.Network;
using StardewValley.SDKs.GogGalaxy;
using StardewValley.SDKs.Steam.Internal;
using Steamworks;

namespace StardewValley.SDKs.Steam;

internal sealed class SteamNetServer(IGameServer gameServer) : HookableServer(gameServer)
{
	private const int ServerBufferSize = 256;

	private const int FlagsLobbyEntered = 1;

	private const int FlagsLobbyLeft = 30;

	private CallResult<LobbyCreated_t> LobbyCreatedCallResult;

	private Callback<SteamNetConnectionStatusChangedCallback_t> SteamNetConnectionStatusChangedCallback;

	private Callback<LobbyChatUpdate_t> LobbyChatUpdateCallback;

	private Dictionary<string, string> LobbyData;

	private Dictionary<HSteamNetConnection, ConnectionData> ConnectionDataMap;

	private Dictionary<long, ConnectionData> FarmerConnectionMap;

	private Dictionary<CSteamID, string> CachedDisplayNames;

	private HashSet<HSteamNetConnection> RecentlyJoined;

	private readonly IntPtr[] Messages = new IntPtr[256];

	private CSteamID Lobby;

	private HSteamListenSocket ListenSocket = HSteamListenSocket.Invalid;

	private HSteamNetPollGroup JoiningGroup = HSteamNetPollGroup.Invalid;

	private HSteamNetPollGroup FarmhandGroup = HSteamNetPollGroup.Invalid;

	private ServerPrivacy Privacy;

	public override int connectionsCount => ConnectionDataMap?.Count ?? 0;

	private void UpdateLobbyPrivacy()
	{
		if (Lobby.IsValid())
		{
			ServerPrivacy privacy = Privacy;
			SteamMatchmaking.SetLobbyType(Lobby, privacy switch
			{
				ServerPrivacy.FriendsOnly => ELobbyType.k_ELobbyTypeFriendsOnly, 
				ServerPrivacy.Public => ELobbyType.k_ELobbyTypePublic, 
				_ => ELobbyType.k_ELobbyTypePrivate, 
			});
		}
	}

	private string ConnectionDataToId(ConnectionData connection)
	{
		return $"SN_{connection.SteamId.m_SteamID}_{connection.Connection.m_HSteamNetConnection}";
	}

	private ConnectionData IdToConnectionData(string connectionId)
	{
		if (connectionId.Length <= 3 || !connectionId.StartsWith("SN_"))
		{
			return null;
		}
		string text = connectionId.Substring(3);
		int num = text.IndexOf('_');
		if (num < 0)
		{
			return null;
		}
		ulong num2 = default(CSteamID).m_SteamID;
		uint hSteamNetConnection = HSteamNetConnection.Invalid.m_HSteamNetConnection;
		try
		{
			num2 = Convert.ToUInt64(text.Substring(0, num));
			hSteamNetConnection = Convert.ToUInt32(text.Substring(num + 1));
		}
		catch (Exception)
		{
		}
		if (!new CSteamID(num2).IsValid())
		{
			return null;
		}
		HSteamNetConnection invalid = HSteamNetConnection.Invalid;
		invalid.m_HSteamNetConnection = hSteamNetConnection;
		if (!ConnectionDataMap.TryGetValue(invalid, out var value))
		{
			return null;
		}
		if (value.SteamId.m_SteamID != num2)
		{
			return null;
		}
		return value;
	}

	public override bool isConnectionActive(string connectionId)
	{
		return IdToConnectionData(connectionId) != null;
	}

	public override string getUserId(long farmerId)
	{
		if (!FarmerConnectionMap.TryGetValue(farmerId, out var value))
		{
			return null;
		}
		return value.SteamId.m_SteamID.ToString();
	}

	public override bool hasUserId(string userId)
	{
		CSteamID cSteamID = default(CSteamID);
		try
		{
			cSteamID = new CSteamID(Convert.ToUInt64(userId));
		}
		catch (Exception)
		{
		}
		if (!cSteamID.IsValid())
		{
			return false;
		}
		foreach (KeyValuePair<HSteamNetConnection, ConnectionData> item in ConnectionDataMap)
		{
			if (item.Value.SteamId.m_SteamID == cSteamID.m_SteamID)
			{
				return true;
			}
		}
		return false;
	}

	public override string getUserName(long farmerId)
	{
		if (!FarmerConnectionMap.TryGetValue(farmerId, out var value))
		{
			return "";
		}
		string text = SteamFriends.GetFriendPersonaName(value.SteamId);
		if (string.IsNullOrWhiteSpace(text) || text == "[unknown]")
		{
			text = value.DisplayName;
		}
		value.DisplayName = text;
		return text;
	}

	public override void setPrivacy(ServerPrivacy privacy)
	{
		Privacy = privacy;
		UpdateLobbyPrivacy();
	}

	public override bool connected()
	{
		if (Lobby.IsValid() && Lobby.IsLobby() && ListenSocket != HSteamListenSocket.Invalid && JoiningGroup != HSteamNetPollGroup.Invalid)
		{
			return FarmhandGroup != HSteamNetPollGroup.Invalid;
		}
		return false;
	}

	private void OnConnecting(SteamNetConnectionStatusChangedCallback_t evt, CSteamID steamId)
	{
		Game1.log.Verbose($"{steamId.m_SteamID} connecting to server");
		if (gameServer.isUserBanned(steamId.m_SteamID.ToString()))
		{
			Game1.log.Verbose($"{steamId.m_SteamID} is banned");
			ShutdownConnection(evt.m_hConn);
		}
		else
		{
			SteamFriends.RequestUserInformation(steamId, bRequireNameOnly: true);
			SteamNetworkingSockets.AcceptConnection(evt.m_hConn);
		}
	}

	private void OnConnected(SteamNetConnectionStatusChangedCallback_t evt, CSteamID steamId)
	{
		Game1.log.Verbose($"{steamId.m_SteamID} connected to server");
		string valueOrDefault = CachedDisplayNames.GetValueOrDefault(steamId);
		ConnectionData connectionData = new ConnectionData(evt.m_hConn, steamId, valueOrDefault);
		ConnectionDataMap[evt.m_hConn] = connectionData;
		SteamNetworkingSockets.SetConnectionPollGroup(evt.m_hConn, JoiningGroup);
		string connectionId = ConnectionDataToId(connectionData);
		onConnect(connectionId);
		gameServer.sendAvailableFarmhands("", connectionId, delegate(OutgoingMessage outgoing)
		{
			SendMessageToConnection(evt.m_hConn, outgoing);
		});
	}

	private void OnDisconnected(SteamNetConnectionStatusChangedCallback_t evt, CSteamID steamId)
	{
		if (!steamId.IsValid())
		{
			return;
		}
		Game1.log.Verbose($"{steamId.m_SteamID} disconnected from server");
		if (!ConnectionDataMap.TryGetValue(evt.m_hConn, out var value))
		{
			SteamSocketUtils.CloseConnection(evt.m_hConn);
			return;
		}
		onDisconnect(ConnectionDataToId(value));
		if (value.Online)
		{
			playerDisconnected(value.FarmerId);
		}
		ConnectionDataMap.Remove(evt.m_hConn);
		SteamSocketUtils.CloseConnection(evt.m_hConn);
	}

	private void OnDisconnected(HSteamNetConnection connection)
	{
		SteamNetConnectionStatusChangedCallback_t evt = new SteamNetConnectionStatusChangedCallback_t
		{
			m_hConn = connection,
			m_eOldState = ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connected
		};
		SteamNetworkingSockets.GetConnectionInfo(connection, out evt.m_info);
		OnDisconnected(evt, evt.m_info.m_identityRemote.GetSteamID());
	}

	private void OnSteamNetConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t evt)
	{
		switch (evt.m_info.m_eState)
		{
		case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connecting:
			OnConnecting(evt, evt.m_info.m_identityRemote.GetSteamID());
			break;
		case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connected:
			OnConnected(evt, evt.m_info.m_identityRemote.GetSteamID());
			break;
		case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ClosedByPeer:
		case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ProblemDetectedLocally:
			OnDisconnected(evt, evt.m_info.m_identityRemote.GetSteamID());
			break;
		case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_FindingRoute:
			break;
		}
	}

	private void OnLobbyChatUpdate(LobbyChatUpdate_t evt)
	{
		if (evt.m_ulSteamIDLobby == Lobby.m_SteamID)
		{
			CSteamID cSteamID = new CSteamID(evt.m_ulSteamIDUserChanged);
			if ((evt.m_rgfChatMemberStateChange & 1) != 0)
			{
				CachedDisplayNames[cSteamID] = SteamFriends.GetFriendPersonaName(cSteamID);
			}
			else if ((evt.m_rgfChatMemberStateChange & 0x1E) != 0)
			{
				CachedDisplayNames.Remove(cSteamID);
			}
		}
	}

	private string OnLobbyCreatedHelper(LobbyCreated_t evt, bool ioFailure)
	{
		if (ioFailure)
		{
			return "IO Failure";
		}
		switch (evt.m_eResult)
		{
		case EResult.k_EResultOK:
			Lobby = new CSteamID(evt.m_ulSteamIDLobby);
			return null;
		case EResult.k_EResultTimeout:
			return "Steam timed out";
		case EResult.k_EResultLimitExceeded:
			return "Too many Steam lobbies created";
		case EResult.k_EResultAccessDenied:
			return "Steam denied access";
		case EResult.k_EResultNoConnection:
			return "No connection to Steam";
		default:
			return "Unknown Steam failure";
		}
	}

	private void OnLobbyCreated(LobbyCreated_t evt, bool ioFailure)
	{
		string text = OnLobbyCreatedHelper(evt, ioFailure);
		if (text == null)
		{
			SteamNetworkingConfigValue_t[] networkingOptions = SteamSocketUtils.GetNetworkingOptions();
			ListenSocket = SteamNetworkingSockets.CreateListenSocketP2P(0, networkingOptions.Length, networkingOptions);
			JoiningGroup = SteamNetworkingSockets.CreatePollGroup();
			FarmhandGroup = SteamNetworkingSockets.CreatePollGroup();
			SteamMatchmaking.SetLobbyGameServer(Lobby, 0u, 0, SteamUser.GetSteamID());
			foreach (KeyValuePair<string, string> lobbyDatum in LobbyData)
			{
				SteamMatchmaking.SetLobbyData(Lobby, lobbyDatum.Key, lobbyDatum.Value);
			}
			SteamMatchmaking.SetLobbyJoinable(Lobby, bLobbyJoinable: true);
			UpdateLobbyPrivacy();
			Game1.log.Verbose($"Steam server successfully created lobby {Lobby.m_SteamID}");
			if (!(base.gameServer is StardewValley.Network.GameServer gameServer))
			{
				return;
			}
			{
				foreach (Server server in gameServer.servers)
				{
					if (server is GalaxyNetServer galaxyNetServer)
					{
						galaxyNetServer.setLobbyData("SteamLobbyId", Lobby.m_SteamID.ToString());
						Game1.log.Verbose("Updated Galaxy server with Steam lobby info");
						break;
					}
				}
				return;
			}
		}
		Game1.log.Verbose("Server failed to create lobby (" + text + ")");
	}

	public override void initialize()
	{
		Game1.log.Verbose("Starting Steam server");
		LobbyCreatedCallResult = CallResult<LobbyCreated_t>.Create(OnLobbyCreated);
		SteamNetConnectionStatusChangedCallback = Callback<SteamNetConnectionStatusChangedCallback_t>.Create(OnSteamNetConnectionStatusChanged);
		LobbyChatUpdateCallback = Callback<LobbyChatUpdate_t>.Create(OnLobbyChatUpdate);
		LobbyData = new Dictionary<string, string>();
		ConnectionDataMap = new Dictionary<HSteamNetConnection, ConnectionData>();
		FarmerConnectionMap = new Dictionary<long, ConnectionData>();
		CachedDisplayNames = new Dictionary<CSteamID, string>();
		RecentlyJoined = new HashSet<HSteamNetConnection>();
		LobbyData["protocolVersion"] = Multiplayer.protocolVersion;
		Lobby.Clear();
		ListenSocket = HSteamListenSocket.Invalid;
		JoiningGroup = HSteamNetPollGroup.Invalid;
		FarmhandGroup = HSteamNetPollGroup.Invalid;
		Privacy = Game1.options.serverPrivacy;
		SteamAPICall_t hAPICall = SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypePrivate, Game1.multiplayer.playerLimit * 2);
		LobbyCreatedCallResult.Set(hAPICall);
	}

	public override void stopServer()
	{
		Game1.log.Verbose("Stopping Steam server");
		foreach (KeyValuePair<HSteamNetConnection, ConnectionData> item in ConnectionDataMap)
		{
			ShutdownConnection(item.Value.Connection);
		}
		if (Lobby.IsValid())
		{
			SteamMatchmaking.LeaveLobby(Lobby);
		}
		if (ListenSocket != HSteamListenSocket.Invalid)
		{
			SteamNetworkingSockets.CloseListenSocket(ListenSocket);
			ListenSocket = HSteamListenSocket.Invalid;
		}
		if (JoiningGroup != HSteamNetPollGroup.Invalid)
		{
			SteamNetworkingSockets.DestroyPollGroup(JoiningGroup);
			JoiningGroup = HSteamNetPollGroup.Invalid;
		}
		if (FarmhandGroup != HSteamNetPollGroup.Invalid)
		{
			SteamNetworkingSockets.DestroyPollGroup(FarmhandGroup);
			FarmhandGroup = HSteamNetPollGroup.Invalid;
		}
		SteamNetConnectionStatusChangedCallback?.Unregister();
		LobbyChatUpdateCallback?.Unregister();
	}

	private void HandleFarmhandRequest(IncomingMessage message, ConnectionData connectionData)
	{
		NetFarmerRoot netFarmerRoot = Game1.multiplayer.readFarmer(message.Reader);
		long farmerId = netFarmerRoot.Value.UniqueMultiplayerID;
		Game1.log.Verbose($"Server received farmhand request from {connectionData.SteamId.m_SteamID} for {farmerId}");
		gameServer.checkFarmhandRequest("", ConnectionDataToId(connectionData), netFarmerRoot, delegate(OutgoingMessage outgoing)
		{
			SendMessageToConnection(connectionData.Connection, outgoing);
		}, delegate
		{
			Game1.log.Verbose($"Server accepted {connectionData.SteamId.m_SteamID} as farmhand {farmerId}");
			SteamNetworkingSockets.SetConnectionUserData(connectionData.Connection, farmerId);
			SteamNetworkingSockets.SetConnectionPollGroup(connectionData.Connection, FarmhandGroup);
			RecentlyJoined.Add(connectionData.Connection);
			connectionData.FarmerId = farmerId;
			connectionData.Online = true;
			FarmerConnectionMap[farmerId] = connectionData;
		});
	}

	private void PollJoiningMessages()
	{
		RecentlyJoined.Clear();
		int num = SteamNetworkingSockets.ReceiveMessagesOnPollGroup(JoiningGroup, Messages, 256);
		for (int i = 0; i < num; i++)
		{
			IncomingMessage message = new IncomingMessage();
			SteamSocketUtils.ProcessSteamMessage(Messages[i], message, out var messageConnection, bandwidthLogger);
			if (!ConnectionDataMap.TryGetValue(messageConnection, out var connectionData))
			{
				Game1.log.Warn("Tried to process multiplayer message from an invalid connection.");
				ShutdownConnection(messageConnection);
				continue;
			}
			bool isRecentlyJoined = RecentlyJoined.Contains(messageConnection);
			if (connectionData.Online && !isRecentlyJoined)
			{
				Game1.log.Warn($"Online farmhand {connectionData.FarmerId} is in the wrong poll group. Closing their connection.");
				ShutdownConnection(messageConnection);
				continue;
			}
			base.OnProcessingMessage(message, delegate(OutgoingMessage outgoing)
			{
				SendMessageToConnection(messageConnection, outgoing);
			}, delegate
			{
				if (isRecentlyJoined)
				{
					gameServer.processIncomingMessage(message);
				}
				else if (message.MessageType == 2)
				{
					HandleFarmhandRequest(message, connectionData);
				}
			});
		}
	}

	private void PollFarmhandMessages()
	{
		int num = SteamNetworkingSockets.ReceiveMessagesOnPollGroup(FarmhandGroup, Messages, 256);
		for (int i = 0; i < num; i++)
		{
			IncomingMessage message = new IncomingMessage();
			SteamSocketUtils.ProcessSteamMessage(Messages[i], message, out var messageConnection, bandwidthLogger);
			if (message.MessageType == 2)
			{
				Game1.log.Warn("Received farmhand request in the wrong poll group. Closing their connection.");
				ShutdownConnection(messageConnection);
				continue;
			}
			if (!ConnectionDataMap.TryGetValue(messageConnection, out var value))
			{
				Game1.log.Warn("Tried to process multiplayer message from an invalid connection.");
				ShutdownConnection(messageConnection);
				continue;
			}
			if (!value.Online)
			{
				Game1.log.Warn("A non-farmhand connection is in the wrong poll group. Closing their connection.");
				ShutdownConnection(messageConnection);
				continue;
			}
			base.OnProcessingMessage(message, delegate(OutgoingMessage outgoing)
			{
				SendMessageToConnection(messageConnection, outgoing);
			}, delegate
			{
				gameServer.processIncomingMessage(message);
			});
		}
	}

	public override void receiveMessages()
	{
		if (!connected())
		{
			return;
		}
		PollJoiningMessages();
		PollFarmhandMessages();
		foreach (KeyValuePair<HSteamNetConnection, ConnectionData> item in ConnectionDataMap)
		{
			SteamNetworkingSockets.FlushMessagesOnConnection(item.Value.Connection);
		}
	}

	private void SendMessageToConnection(HSteamNetConnection connection, OutgoingMessage message)
	{
		SteamSocketUtils.SendMessage(connection, message, bandwidthLogger, OnDisconnected);
	}

	public override void sendMessage(long peerId, OutgoingMessage message)
	{
		if (connected() && FarmerConnectionMap.TryGetValue(peerId, out var value) && !(value.Connection == HSteamNetConnection.Invalid))
		{
			SendMessageToConnection(value.Connection, message);
		}
	}

	public override void setLobbyData(string key, string value)
	{
		if (LobbyData != null)
		{
			LobbyData[key] = value;
			if (Lobby.IsValid())
			{
				SteamMatchmaking.SetLobbyData(Lobby, key, value);
			}
		}
	}

	public override void kick(long disconnectee)
	{
		base.kick(disconnectee);
		sendMessage(disconnectee, new OutgoingMessage(23, Game1.player));
		if (FarmerConnectionMap.TryGetValue(disconnectee, out var value))
		{
			ShutdownConnection(value.Connection);
		}
	}

	public override void playerDisconnected(long disconnectee)
	{
		if (FarmerConnectionMap.TryGetValue(disconnectee, out var _))
		{
			base.playerDisconnected(disconnectee);
			FarmerConnectionMap.Remove(disconnectee);
		}
	}

	public override float getPingToClient(long farmerId)
	{
		if (!FarmerConnectionMap.TryGetValue(farmerId, out var value))
		{
			return -1f;
		}
		SteamNetworkingSockets.GetQuickConnectionStatus(value.Connection, out var pStats);
		return pStats.m_nPing;
	}

	public override bool canOfferInvite()
	{
		return connected();
	}

	public override void offerInvite()
	{
		if (connected())
		{
			Program.sdk.Networking.ShowInviteDialog(Lobby);
		}
	}

	private void ShutdownConnection(HSteamNetConnection connection)
	{
		SteamSocketUtils.CloseConnection(connection, OnDisconnected);
	}
}
