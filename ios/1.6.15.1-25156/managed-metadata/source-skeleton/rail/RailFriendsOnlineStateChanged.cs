using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsOnlineStateChanged : EventBase
{
	public RailFriendOnLineState friend_online_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsOnlineStateChanged()
	{
	}
}
