using System.Runtime.CompilerServices;

namespace rail;

public class RailUsersInviteUsersResult : EventBase
{
	public EnumRailUsersInviteType invite_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUsersInviteUsersResult()
	{
	}
}
