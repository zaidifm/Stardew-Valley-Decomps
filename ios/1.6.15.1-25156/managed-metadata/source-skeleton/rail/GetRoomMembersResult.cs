using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class GetRoomMembersResult : EventBase
{
	public List<RoomMemberInfo> member_infos;

	public ulong room_id;

	public uint member_num;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetRoomMembersResult()
	{
	}
}
