using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class GetRoomListResult : EventBase
{
	public List<RoomInfo> room_infos;

	public uint total_room_num;

	public uint begin_index;

	public uint end_index;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetRoomListResult()
	{
	}
}
