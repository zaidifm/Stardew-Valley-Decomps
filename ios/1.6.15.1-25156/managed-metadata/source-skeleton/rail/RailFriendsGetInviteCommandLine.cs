using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsGetInviteCommandLine : EventBase
{
	public RailID friend_id;

	public string invite_command_line;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsGetInviteCommandLine()
	{
	}
}
