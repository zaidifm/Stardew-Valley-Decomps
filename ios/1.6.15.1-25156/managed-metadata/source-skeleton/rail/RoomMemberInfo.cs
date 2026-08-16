using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RoomMemberInfo
{
	public string member_name;

	public uint member_index;

	public ulong room_id;

	public List<RailKeyValue> member_kvs;

	public RailID member_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RoomMemberInfo()
	{
	}
}
