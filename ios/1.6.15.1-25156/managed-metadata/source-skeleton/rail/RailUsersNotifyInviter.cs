using System.Runtime.CompilerServices;

namespace rail;

public class RailUsersNotifyInviter : EventBase
{
	public RailID invitee_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUsersNotifyInviter()
	{
	}
}
