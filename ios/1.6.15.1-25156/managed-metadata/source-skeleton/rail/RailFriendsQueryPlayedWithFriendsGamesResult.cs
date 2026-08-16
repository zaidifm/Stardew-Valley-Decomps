using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsQueryPlayedWithFriendsGamesResult : EventBase
{
	public List<RailPlayedWithFriendsGameItem> played_with_friends_game_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsQueryPlayedWithFriendsGamesResult()
	{
	}
}
