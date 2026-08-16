using System;
using Galaxy.Api;
using StardewValley.Network;
using StardewValley.SDKs.GogGalaxy.Listeners;
using StardewValley.SDKs.Steam.Internal;
using Steamworks;

namespace StardewValley.SDKs.Steam;

internal sealed class SteamNetClient : HookableClient
{
	private const int ClientBufferSize = 256;

	private CallResult<LobbyEnter_t> SteamLobbyEnterCallResult;

	private readonly Callback<SteamNetConnectionStatusChangedCallback_t> SteamNetConnectionStatusChangedCallback;

	private GalaxyLobbyDataRetrieveListener GalaxyLobbyDataRetrieveCallback;

	private readonly IntPtr[] Messages = new IntPtr[256];

	private GalaxyID GalaxyLobby;

	private CSteamID SteamLobby;

	private CSteamID HostId;

	private string CachedHostName;

	private HSteamNetConnection Connection = HSteamNetConnection.Invalid;

	public SteamNetClient(GalaxyID galaxyLobby)
	{
		SteamNetConnectionStatusChangedCallback = Callback<SteamNetConnectionStatusChangedCallback_t>.Create(OnSteamNetConnectionStatusChanged);
		GalaxyLobby = galaxyLobby;
	}

	public SteamNetClient(CSteamID steamLobby)
	{
		SteamNetConnectionStatusChangedCallback = Callback<SteamNetConnectionStatusChangedCallback_t>.Create(OnSteamNetConnectionStatusChanged);
		GalaxyLobby = null;
		SteamLobby = steamLobby;
	}

	~SteamNetClient()
	{
		CleanupLobbyDataRetrieve();
		SteamNetConnectionStatusChangedCallback.Unregister();
	}

	private void OnDisconnected(HSteamNetConnection connection)
	{
		if (!(connection == HSteamNetConnection.Invalid) && !(connection != Connection))
		{
			Game1.log.Verbose($"Client disconnected from server {HostId.m_SteamID}");
			timedOut = true;
			pendingDisconnect = Multiplayer.DisconnectType.HostLeft;
			SteamSocketUtils.CloseConnection(Connection);
			Connection = HSteamNetConnection.Invalid;
		}
	}

	private void OnSteamNetConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t evt)
	{
		if (!(evt.m_hConn != Connection))
		{
			switch (evt.m_info.m_eState)
			{
			case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connecting:
				Game1.log.Verbose($"Client connecting to server {HostId.m_SteamID}");
				break;
			case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connected:
				Game1.log.Verbose($"Client connected to server {HostId.m_SteamID}");
				break;
			case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ClosedByPeer:
			case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ProblemDetectedLocally:
				OnDisconnected(evt.m_hConn);
				break;
			case ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_FindingRoute:
				break;
			}
		}
	}

	public override string getUserID()
	{
		return Program.sdk.Networking.GetUserID();
	}

	protected override string getHostUserName()
	{
		if (!HostId.IsValid())
		{
			return "???";
		}
		string text = SteamFriends.GetFriendPersonaName(HostId);
		if (string.IsNullOrWhiteSpace(text) || text == "[unknown]")
		{
			text = CachedHostName;
		}
		CachedHostName = text;
		return text;
	}

	private void ConnectToHost()
	{
		Game1.log.Verbose($"Found Steam host {HostId.m_SteamID}");
		SteamNetworkingIdentity identityRemote = default(SteamNetworkingIdentity);
		identityRemote.SetSteamID(HostId);
		SteamNetworkingConfigValue_t[] networkingOptions = SteamSocketUtils.GetNetworkingOptions();
		Connection = SteamNetworkingSockets.ConnectP2P(ref identityRemote, 0, networkingOptions.Length, networkingOptions);
	}

	private string TryConnectSteam(LobbyEnter_t evt, bool ioFailure, out string errorTranslationKey)
	{
		SteamLobby.Clear();
		if (ioFailure)
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_Failed";
			return "IO Failure";
		}
		if (evt.m_EChatRoomEnterResponse != 1)
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_Failed";
			return $"Failed to join: {(EChatRoomEnterResponse)evt.m_EChatRoomEnterResponse}";
		}
		SteamLobby = new CSteamID(evt.m_ulSteamIDLobby);
		string lobbyData = SteamMatchmaking.GetLobbyData(SteamLobby, "protocolVersion");
		if (lobbyData != Multiplayer.protocolVersion)
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_FailedProtocolVersion";
			if (!(lobbyData == ""))
			{
				return $"Protocol ({lobbyData}) does not match our own ({Multiplayer.protocolVersion})";
			}
			return "Missing protocol version data";
		}
		if (!SteamMatchmaking.GetLobbyGameServer(SteamLobby, out var _, out var _, out var psteamIDGameServer))
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_Failed";
			return "Missing game server data";
		}
		if (!psteamIDGameServer.IsValid())
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_Failed";
			return "Invalid host ID";
		}
		CachedHostName = SteamFriends.GetFriendPersonaName(HostId);
		SteamFriends.RequestUserInformation(psteamIDGameServer, bRequireNameOnly: true);
		HostId = psteamIDGameServer;
		ConnectToHost();
		errorTranslationKey = null;
		return null;
	}

	private void OnLobbyEnter(LobbyEnter_t evt, bool ioFailure)
	{
		if (evt.m_ulSteamIDLobby == SteamLobby.m_SteamID)
		{
			string text = TryConnectSteam(evt, ioFailure, out var errorTranslationKey);
			if (text != null)
			{
				connectionMessage = Game1.content.LoadString(errorTranslationKey);
				Game1.log.Verbose($"Error joining via Steam lobby {evt.m_ulSteamIDLobby} ({text})");
			}
			SteamLobbyEnterCallResult = null;
		}
	}

	private void ConnectImplSteam()
	{
		Game1.log.Verbose($"Resolving Steam host via Steam lobby {SteamLobby.m_SteamID}");
		SteamLobbyEnterCallResult = CallResult<LobbyEnter_t>.Create(OnLobbyEnter);
		SteamAPICall_t hAPICall = SteamMatchmaking.JoinLobby(SteamLobby);
		SteamLobbyEnterCallResult.Set(hAPICall);
	}

	private void CleanupLobbyDataRetrieve()
	{
		GalaxyLobbyDataRetrieveCallback?.Dispose();
		GalaxyLobbyDataRetrieveCallback = null;
	}

	private string TryConnectGalaxy(GalaxyID lobbyId, out string errorTranslationKey)
	{
		string lobbyData;
		try
		{
			lobbyData = GalaxyInstance.Matchmaking().GetLobbyData(lobbyId, "SteamLobbyId");
		}
		catch (Exception)
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_Failed";
			return "Failed to get Steam lobby ID";
		}
		if (string.IsNullOrEmpty(lobbyData))
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_Failed";
			return "Missing Steam lobby ID";
		}
		string lobbyData2;
		try
		{
			lobbyData2 = GalaxyInstance.Matchmaking().GetLobbyData(lobbyId, "protocolVersion");
		}
		catch (Exception)
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_FailedProtocolVersion";
			return "Failed to get protocol version";
		}
		if (lobbyData2 != Multiplayer.protocolVersion)
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_FailedProtocolVersion";
			if (!string.IsNullOrEmpty(lobbyData2))
			{
				return $"Protocol ({lobbyData2}) does not match our own ({Multiplayer.protocolVersion})";
			}
			return "Missing protocol version data";
		}
		CSteamID steamLobby = default(CSteamID);
		try
		{
			steamLobby = new CSteamID(Convert.ToUInt64(lobbyData));
		}
		catch (Exception)
		{
		}
		if (!steamLobby.IsValid())
		{
			errorTranslationKey = "Strings\\UI:CoopMenu_Failed";
			return "Invalid lobby ID";
		}
		SteamLobby = steamLobby;
		GalaxyLobby = null;
		errorTranslationKey = null;
		ConnectImplSteam();
		return null;
	}

	private void OnLobbyDataRetrieveSuccess(GalaxyID lobbyId)
	{
		if (lobbyId != null && lobbyId != GalaxyLobby)
		{
			return;
		}
		string text = TryConnectGalaxy(lobbyId, out var errorTranslationKey);
		if (text != null)
		{
			connectionMessage = Game1.content.LoadString(errorTranslationKey);
			Game1.log.Verbose($"Error joining via Galaxy lobby {lobbyId} ({text})");
		}
		else
		{
			try
			{
				GalaxyInstance.Matchmaking().LeaveLobby(lobbyId);
			}
			catch (Exception)
			{
			}
		}
		CleanupLobbyDataRetrieve();
	}

	private void OnLobbyDataRetrieveFailure(GalaxyID lobbyId, ILobbyDataRetrieveListener.FailureReason failureReason)
	{
		if (!(lobbyId != null) || !(lobbyId != GalaxyLobby))
		{
			connectionMessage = Game1.content.LoadString("Strings\\UI:CoopMenu_Failed");
			Game1.log.Verbose($"Steam client failed to get data from Galaxy lobby {lobbyId}");
			CleanupLobbyDataRetrieve();
		}
	}

	private void ConnectImplGalaxy()
	{
		Game1.log.Verbose($"Resolving Steam lobby via Galaxy lobby {GalaxyLobby}");
		GalaxyLobbyDataRetrieveCallback = new GalaxyLobbyDataRetrieveListener(OnLobbyDataRetrieveSuccess, OnLobbyDataRetrieveFailure);
		try
		{
			GalaxyInstance.Matchmaking().RequestLobbyData(GalaxyLobby, GalaxyLobbyDataRetrieveCallback);
		}
		catch (Exception exception)
		{
			connectionMessage = Game1.content.LoadString("Strings\\UI:CoopMenu_Failed");
			Game1.log.Error("Steam client Galaxy RequestLobbyData failed with an exception:", exception);
			CleanupLobbyDataRetrieve();
		}
	}

	protected override void connectImpl()
	{
		if (GalaxyLobby == null)
		{
			ConnectImplSteam();
		}
		else
		{
			ConnectImplGalaxy();
		}
	}

	public override void disconnect(bool neatly = true)
	{
		if (SteamLobby.IsValid())
		{
			SteamMatchmaking.LeaveLobby(SteamLobby);
			SteamLobby.Clear();
		}
		Game1.log.Verbose($"Client disconnecting from server {HostId.m_SteamID}");
		connectionMessage = null;
		ShutdownConnection();
	}

	protected override void receiveMessagesImpl()
	{
		if (Connection == HSteamNetConnection.Invalid)
		{
			return;
		}
		int num = SteamNetworkingSockets.ReceiveMessagesOnConnection(Connection, Messages, 256);
		for (int i = 0; i < num; i++)
		{
			IncomingMessage message = new IncomingMessage();
			SteamSocketUtils.ProcessSteamMessage(Messages[i], message, out var _, bandwidthLogger);
			base.OnProcessingMessage(message, SendMessageImpl, delegate
			{
				processIncomingMessage(message);
			});
		}
		SteamNetworkingSockets.FlushMessagesOnConnection(Connection);
	}

	public override void sendMessage(OutgoingMessage message)
	{
		base.OnSendingMessage(message, SendMessageImpl, delegate
		{
			SendMessageImpl(message);
		});
	}

	public override float GetPingToHost()
	{
		if (Connection == HSteamNetConnection.Invalid)
		{
			return -1f;
		}
		SteamNetworkingSockets.GetQuickConnectionStatus(Connection, out var pStats);
		return pStats.m_nPing;
	}

	private void SendMessageImpl(OutgoingMessage message)
	{
		if (!(Connection == HSteamNetConnection.Invalid))
		{
			SteamSocketUtils.SendMessage(Connection, message, bandwidthLogger, OnDisconnected);
		}
	}

	private void ShutdownConnection()
	{
		SteamSocketUtils.CloseConnection(Connection, OnDisconnected);
	}
}
