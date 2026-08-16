using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsQueryPlayedWithFriendsTimeResult : EventBase
{
	public List<RailPlayedWithFriendsTimeItem> played_with_friends_time_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsQueryPlayedWithFriendsTimeResult()
	{
	}
}
