using System.Runtime.CompilerServices;

namespace rail;

public class RailUsersGetInviteDetailResult : EventBase
{
	public string command_line;

	public EnumRailUsersInviteType invite_type;

	public RailID inviter_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUsersGetInviteDetailResult()
	{
	}
}
