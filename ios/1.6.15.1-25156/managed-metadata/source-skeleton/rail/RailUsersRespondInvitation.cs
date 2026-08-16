using System.Runtime.CompilerServices;

namespace rail;

public class RailUsersRespondInvitation : EventBase
{
	public RailInviteOptions original_invite_option;

	public EnumRailUsersInviteResponseType response;

	public RailID inviter_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUsersRespondInvitation()
	{
	}
}
