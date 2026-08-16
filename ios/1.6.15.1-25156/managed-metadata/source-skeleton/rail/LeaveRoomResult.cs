using System.Runtime.CompilerServices;

namespace rail;

public class LeaveRoomResult : EventBase
{
	public EnumLeaveRoomReason reason;

	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeaveRoomResult()
	{
	}
}
