using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RoomInfo
{
	public bool has_password;

	public uint max_members;

	public string room_name;

	public RailID game_server_rail_id;

	public uint create_time;

	public uint current_members;

	public EnumRoomType type;

	public bool is_joinable;

	public ulong room_id;

	public List<RailKeyValue> room_kvs;

	public string room_tag;

	public RailID owner_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RoomInfo()
	{
	}
}
