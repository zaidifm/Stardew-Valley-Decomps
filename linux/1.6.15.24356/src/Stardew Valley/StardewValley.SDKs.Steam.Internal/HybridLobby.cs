using Galaxy.Api;
using Steamworks;

namespace StardewValley.SDKs.Steam.Internal;

internal struct HybridLobby
{
	private bool IsHybrid;

	public ulong SteamId { get; private set; }

	public ulong GalaxyId { get; private set; }

	public LobbyConnectionType LobbyType
	{
		get
		{
			CSteamID cSteamID = new CSteamID(SteamId);
			if (cSteamID.IsValid() && cSteamID.IsLobby())
			{
				return LobbyConnectionType.Steam;
			}
			if (!new GalaxyID(GalaxyId).IsValid())
			{
				return LobbyConnectionType.Invalid;
			}
			if (IsHybrid)
			{
				return LobbyConnectionType.Hybrid;
			}
			return LobbyConnectionType.Galaxy;
		}
	}

	public HybridLobby(CSteamID steamID)
	{
		SteamId = steamID.m_SteamID;
		GalaxyId = 0uL;
		IsHybrid = false;
	}

	public HybridLobby(GalaxyID galaxyID, bool isHybrid = false)
	{
		SteamId = 0uL;
		GalaxyId = galaxyID.ToUint64();
		IsHybrid = isHybrid;
	}

	public void Clear()
	{
		SteamId = 0uL;
		GalaxyId = 0uL;
		IsHybrid = false;
	}
}
