using System.Runtime.CompilerServices;

namespace rail;

public class NotifyRoomMemberChange : EventBase
{
	public RailID changer_id;

	public RailID id_for_making_change;

	public EnumRoomMemberActionStatus state_change;

	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NotifyRoomMemberChange()
	{
	}
}
