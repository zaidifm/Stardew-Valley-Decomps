using Steamworks;

namespace StardewValley.SDKs.Steam.Internal;

internal sealed class ConnectionData
{
	public long FarmerId = long.MinValue;

	public CSteamID SteamId;

	public HSteamNetConnection Connection;

	public bool Online;

	public string DisplayName;

	public ConnectionData(HSteamNetConnection connection, CSteamID steamId, string displayName)
	{
		Connection = connection;
		SteamId = steamId;
		DisplayName = displayName;
	}
}
