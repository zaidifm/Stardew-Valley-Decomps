using System;
using System.Collections.Generic;
using Galaxy.Api;
using StardewValley.Network;
using StardewValley.SDKs.GogGalaxy;
using StardewValley.SDKs.Steam.Internal;
using Steamworks;

namespace StardewValley.SDKs.Steam;

internal sealed class SteamNetHelper : SDKNetHelper
{
	private List<LobbyUpdateListener> LobbyUpdateListeners;

	private readonly Callback<LobbyDataUpdate_t> LobbyDataUpdateCallback;

	private readonly Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback;

	private HybridLobby RequestedLobby;

	public SteamNetHelper()
	{
		LobbyUpdateListeners = new List<LobbyUpdateListener>();
		GameLobbyJoinRequestedCallback = Callback<GameLobbyJoinRequested_t>.Create(OnGameLobbyJoinRequested);
		LobbyDataUpdateCallback = Callback<LobbyDataUpdate_t>.Create(OnLobbyDataUpdate);
		RequestedLobby.Clear();
		FindLaunchLobby();
	}

	~SteamNetHelper()
	{
		GameLobbyJoinRequestedCallback.Unregister();
		LobbyDataUpdateCallback.Unregister();
	}

	private void OnGameLobbyJoinRequested(GameLobbyJoinRequested_t evt)
	{
		RequestJoinLobby(evt.m_steamIDLobby);
	}

	private void OnLobbyDataUpdate(LobbyDataUpdate_t evt)
	{
		CSteamID cSteamID = new CSteamID(evt.m_ulSteamIDLobby);
		if (SteamMatchmaking.GetLobbyOwner(cSteamID) == SteamUser.GetSteamID())
		{
			return;
		}
		HybridLobby hybridLobby = new HybridLobby(cSteamID);
		foreach (LobbyUpdateListener lobbyUpdateListener in LobbyUpdateListeners)
		{
			lobbyUpdateListener.OnLobbyUpdate(hybridLobby);
		}
	}

	private void FindLaunchLobby()
	{
		CSteamID requestedLobby = default(CSteamID);
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = 0; i < commandLineArgs.Length - 1; i++)
		{
			if (!(commandLineArgs[i] != "+connect_lobby"))
			{
				requestedLobby.Clear();
				try
				{
					requestedLobby = new CSteamID(Convert.ToUInt64(commandLineArgs[i + 1]));
					Game1.log.Verbose($"Found startup Steam lobby {requestedLobby.m_SteamID}");
					RequestJoinLobby(requestedLobby);
					break;
				}
				catch (Exception)
				{
					Game1.log.Verbose("Could not parse argument for +connect_lobby: " + commandLineArgs[i + 1]);
				}
			}
		}
	}

	private void RequestJoinLobby(CSteamID requestedLobby)
	{
		if (requestedLobby.IsValid() && requestedLobby.IsLobby())
		{
			Game1.log.Verbose($"Requesting to join Steam lobby {requestedLobby.m_SteamID}");
			RequestedLobby = new HybridLobby(requestedLobby);
			Game1.multiplayer.inviteAccepted();
		}
		else
		{
			Game1.log.Verbose($"Denied request to join invalid Steam lobby {requestedLobby.m_SteamID}");
		}
	}

	public string GetUserID()
	{
		try
		{
			return GalaxyInstance.User().GetGalaxyID().ToUint64()
				.ToString();
		}
		catch (Exception)
		{
			return "";
		}
	}

	private Client CreateClientFromHybrid(HybridLobby lobby)
	{
		return lobby.LobbyType switch
		{
			LobbyConnectionType.Steam => new SteamNetClient(new CSteamID(lobby.SteamId)), 
			LobbyConnectionType.Galaxy => new GalaxyNetClient(new GalaxyID(lobby.GalaxyId)), 
			LobbyConnectionType.Hybrid => new SteamNetClient(new GalaxyID(lobby.GalaxyId)), 
			_ => null, 
		};
	}

	private Client CreateClientHelper(HybridLobby lobby)
	{
		Client client = CreateClientFromHybrid(lobby);
		if (client == null)
		{
			return null;
		}
		return Game1.multiplayer.InitClient(client);
	}

	public Client CreateClient(object lobby)
	{
		if (!(lobby is HybridLobby lobby2))
		{
			return null;
		}
		return CreateClientHelper(lobby2);
	}

	public Client GetRequestedClient()
	{
		Client result = CreateClientHelper(RequestedLobby);
		RequestedLobby.Clear();
		return result;
	}

	public Server CreateSteamServer(IGameServer gameServer)
	{
		return Game1.multiplayer.InitServer(new SteamNetServer(gameServer));
	}

	public Server CreateServer(IGameServer gameServer)
	{
		if (Program.sdk is SteamHelper { GalaxyConnected: false })
		{
			Game1.log.Error("Could not create a Galaxy server: not logged on");
			return null;
		}
		return Game1.multiplayer.InitServer(new GalaxyNetServer(gameServer));
	}

	public void AddLobbyUpdateListener(LobbyUpdateListener listener)
	{
		LobbyUpdateListeners.Add(listener);
	}

	public void RemoveLobbyUpdateListener(LobbyUpdateListener listener)
	{
		LobbyUpdateListeners.Remove(listener);
	}

	public void RequestFriendLobbyData()
	{
		int friendCount = SteamFriends.GetFriendCount(EFriendFlags.k_EFriendFlagImmediate);
		for (int i = 0; i < friendCount; i++)
		{
			CSteamID friendByIndex = SteamFriends.GetFriendByIndex(i, EFriendFlags.k_EFriendFlagImmediate);
			if (!(friendByIndex == SteamUser.GetSteamID()))
			{
				SteamFriends.GetFriendGamePlayed(friendByIndex, out var pFriendGameInfo);
				if (!(pFriendGameInfo.m_gameID.AppID() != SteamUtils.GetAppID()))
				{
					SteamMatchmaking.RequestLobbyData(pFriendGameInfo.m_steamIDLobby);
				}
			}
		}
	}

	public string GetLobbyData(object lobby, string key)
	{
		if (!(lobby is HybridLobby { LobbyType: var lobbyType } hybridLobby))
		{
			return "";
		}
		switch (lobbyType)
		{
		case LobbyConnectionType.Steam:
			return SteamMatchmaking.GetLobbyData(new CSteamID(hybridLobby.SteamId), key);
		case LobbyConnectionType.Galaxy:
		case LobbyConnectionType.Hybrid:
			try
			{
				return GalaxyInstance.Matchmaking().GetLobbyData(new GalaxyID(hybridLobby.GalaxyId), key);
			}
			catch (Exception)
			{
				return "";
			}
		default:
			return "";
		}
	}

	public string GetLobbyOwnerName(object lobby)
	{
		if (!(lobby is HybridLobby hybridLobby))
		{
			return null;
		}
		switch (hybridLobby.LobbyType)
		{
		case LobbyConnectionType.Steam:
			return SteamFriends.GetFriendPersonaName(SteamMatchmaking.GetLobbyOwner(new CSteamID(hybridLobby.SteamId)));
		case LobbyConnectionType.Hybrid:
			return GalaxyNetHelper.TryGetHostSteamDisplayName(new GalaxyID(hybridLobby.GalaxyId)) ?? "";
		case LobbyConnectionType.Galaxy:
			try
			{
				GalaxyID lobbyOwner = GalaxyInstance.Matchmaking().GetLobbyOwner(new GalaxyID(hybridLobby.GalaxyId));
				return GalaxyInstance.Friends().GetFriendPersonaName(lobbyOwner);
			}
			catch (Exception)
			{
				return "";
			}
		default:
			return "";
		}
	}

	public bool SupportsInviteCodes()
	{
		return true;
	}

	public object GetLobbyFromInviteCode(string inviteCode)
	{
		GalaxyID lobbyFromGalaxyInvite = GalaxyNetHelper.GetLobbyFromGalaxyInvite(inviteCode);
		if (!(lobbyFromGalaxyInvite != null))
		{
			return null;
		}
		return new HybridLobby(lobbyFromGalaxyInvite, inviteCode[0] == 'S');
	}

	public void ShowInviteDialog(object lobby)
	{
		if (lobby is CSteamID steamIDLobby)
		{
			SteamFriends.ActivateGameOverlayInviteDialog(steamIDLobby);
		}
	}

	public void MutePlayer(string userId, bool mute)
	{
	}

	public bool IsPlayerMuted(string userId)
	{
		return false;
	}

	public void ShowProfile(string userId)
	{
	}
}
