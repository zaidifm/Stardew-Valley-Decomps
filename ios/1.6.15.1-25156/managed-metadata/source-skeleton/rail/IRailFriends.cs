using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailFriends
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetPersonalInfo(List<RailID> rail_ids, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetFriendMetadata(RailID rail_id, List<string> keys, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetMyMetadata(List<RailKeyValue> key_values, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncClearAllMyMetadata(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetInviteCommandLine(string command_line, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetInviteCommandLine(RailID rail_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncReportPlayedWithUserList(List<RailUserPlayedWith> player_list, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetFriendsList(List<RailFriendInfo> friends_list);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryFriendPlayedGamesInfo(RailID rail_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryPlayedWithFriendsList(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryPlayedWithFriendsTime(List<RailID> rail_ids, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryPlayedWithFriendsGames(List<RailID> rail_ids, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncAddFriend(RailFriendsAddFriendRequest request, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncUpdateFriendsData(string user_data);
}
