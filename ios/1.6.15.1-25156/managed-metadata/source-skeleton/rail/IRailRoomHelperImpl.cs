using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class IRailRoomHelperImpl : RailObject, IRailRoomHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailRoomHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailRoomHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailRoom CreateRoom(RoomOptions options, string room_name, out RailResult result)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailRoom AsyncCreateRoom(RoomOptions options, string room_name, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailRoom OpenRoom(ulong room_id, out RailResult result)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailRoom AsyncOpenRoom(ulong room_id, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetRoomList(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<RoomInfoListFilter> filter, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetRoomListByTags(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<string> room_tags, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetUserRoomList(string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
