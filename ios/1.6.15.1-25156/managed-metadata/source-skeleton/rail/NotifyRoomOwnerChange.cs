using System.Runtime.CompilerServices;

namespace rail;

public class NotifyRoomOwnerChange : EventBase
{
	public RailID old_owner_id;

	public EnumRoomOwnerChangeReason reason;

	public ulong room_id;

	public RailID new_owner_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NotifyRoomOwnerChange()
	{
	}
}
