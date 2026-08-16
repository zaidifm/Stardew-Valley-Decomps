using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsQueryFriendPlayedGamesResult : EventBase
{
	public List<RailFriendPlayedGameInfo> friend_played_games_info_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsQueryFriendPlayedGamesResult()
	{
	}
}
