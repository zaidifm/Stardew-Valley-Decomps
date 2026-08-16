using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailUsersHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetUsersInfo(List<RailID> rail_ids, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncInviteUsers(string command_line, List<RailID> users, RailInviteOptions options, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetInviteDetail(RailID inviter, EnumRailUsersInviteType invite_type, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncCancelInvite(EnumRailUsersInviteType invite_type, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncCancelAllInvites(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetUserLimits(RailID user_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncShowChatWindowWithFriend(RailID rail_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncShowUserHomepageWindow(RailID rail_id, string user_data);
}
