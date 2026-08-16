using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailRoomHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailRoom CreateRoom(RoomOptions options, string room_name, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailRoom AsyncCreateRoom(RoomOptions options, string room_name, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailRoom OpenRoom(ulong room_id, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailRoom AsyncOpenRoom(ulong room_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetRoomList(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<RoomInfoListFilter> filter, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetRoomListByTags(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<string> room_tags, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetUserRoomList(string user_data);
}
