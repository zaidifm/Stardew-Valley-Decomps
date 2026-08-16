using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsQueryPlayedWithFriendsListResult : EventBase
{
	public List<RailID> played_with_friends_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsQueryPlayedWithFriendsListResult()
	{
	}
}
