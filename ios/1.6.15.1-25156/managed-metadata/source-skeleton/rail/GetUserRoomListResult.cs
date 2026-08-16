using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class GetUserRoomListResult : EventBase
{
	public List<RoomInfo> room_info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetUserRoomListResult()
	{
	}
}
