using System.Runtime.CompilerServices;

namespace rail;

public class RailUsersCancelInviteResult : EventBase
{
	public EnumRailUsersInviteType invite_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUsersCancelInviteResult()
	{
	}
}
