using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsAddFriendResult : EventBase
{
	public RailID target_rail_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsAddFriendResult()
	{
	}
}
