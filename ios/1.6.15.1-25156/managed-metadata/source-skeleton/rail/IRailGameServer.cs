using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailGameServer : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetGameServerRailID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGameServerName(out string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGameServerFullName(out string full_name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetOwnerRailID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetHost(string game_server_host);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetHost(out string game_server_host);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetMapName(string game_server_map);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetMapName(out string game_server_map);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetPasswordProtect(bool has_password);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetPasswordProtect();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetMaxPlayers(uint max_player_count);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetMaxPlayers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetBotPlayers(uint bot_player_count);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetBotPlayers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetGameServerDescription(string game_server_description);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetGameServerDescription(out string game_server_description);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetGameServerTags(string game_server_tags);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetGameServerTags(out string game_server_tags);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetMods(List<string> server_mods);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetMods(List<string> server_mods);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetSpectatorHost(string spectator_host);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetSpectatorHost(out string spectator_host);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetGameServerVersion(string version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetGameServerVersion(out string version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetIsFriendOnly(bool is_friend_only);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetIsFriendOnly();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ClearAllMetadata();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetMetadata(string key, out string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetMetadata(string key, string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetMetadata(List<RailKeyValue> key_values, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetMetadata(List<string> keys, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetAllMetadata(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncAcquireGameServerSessionTicket(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void TerminateSessionOfPlayer(RailID player_rail_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void AbandonGameServerSessionTicket(RailSessionTicket session_ticket);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ReportPlayerJoinGameServer(List<GameServerPlayerInfo> player_infos);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ReportPlayerQuitGameServer(List<GameServerPlayerInfo> player_infos);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult UpdateGameServerPlayerList(List<GameServerPlayerInfo> player_infos);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetCurrentPlayers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RemoveAllPlayers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult RegisterToGameServerList();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult UnregisterFromGameServerList();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult CloseGameServer();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetFriendsInGameServer(List<RailID> friend_ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsUserInGameServer(RailID user_rail_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetServerInfo(string server_info);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetServerInfo(out string server_info);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult EnableTeamVoice(bool enable);
}
