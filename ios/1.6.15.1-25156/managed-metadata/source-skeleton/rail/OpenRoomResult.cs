using System.Runtime.CompilerServices;

namespace rail;

public class OpenRoomResult : EventBase
{
	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OpenRoomResult()
	{
	}
}
