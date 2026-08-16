using System.Runtime.CompilerServices;

namespace rail;

public class GetAllRoomDataResult : EventBase
{
	public RoomInfo room_info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetAllRoomDataResult()
	{
	}
}
