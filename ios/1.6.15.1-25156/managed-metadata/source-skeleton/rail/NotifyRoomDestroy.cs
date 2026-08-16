using System.Runtime.CompilerServices;

namespace rail;

public class NotifyRoomDestroy : EventBase
{
	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NotifyRoomDestroy()
	{
	}
}
