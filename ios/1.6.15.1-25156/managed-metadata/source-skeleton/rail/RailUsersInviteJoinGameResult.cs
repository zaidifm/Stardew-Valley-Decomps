using System.Runtime.CompilerServices;

namespace rail;

public class RailUsersInviteJoinGameResult : EventBase
{
	public EnumRailUsersInviteResponseType response_value;

	public RailID invitee_id;

	public EnumRailUsersInviteType invite_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUsersInviteJoinGameResult()
	{
	}
}
