using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailRoom : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncJoinRoom(string password, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	ulong GetRoomID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetRoomName(out string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetOwnerID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool HasPassword();

	[MethodImpl(MethodImplOptions.NoInlining)]
	EnumRoomType GetRoomType();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetMembers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetMemberByIndex(uint index);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetMemberNameByIndex(uint index, out string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetMaxMembers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Leave();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetNewRoomOwner(RailID new_owner_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetRoomMembers(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetAllRoomData(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncKickOffMember(RailID member_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetRoomTag(string room_tag, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetRoomTag(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetRoomMetadata(List<RailKeyValue> key_values, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetRoomMetadata(List<string> keys, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncClearRoomMetadata(List<string> keys, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetMemberMetadata(RailID member_id, List<RailKeyValue> key_values, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetMemberMetadata(RailID member_id, List<string> keys, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SendDataToMember(RailID remote_peer, byte[] data_buf, uint data_len, uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SendDataToMember(RailID remote_peer, byte[] data_buf, uint data_len);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetGameServerID(RailID game_server_rail_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetGameServerID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetRoomJoinable(bool is_joinable);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsRoomJoinable();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetFriendsInRoom(List<RailID> friend_ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsUserInRoom(RailID user_rail_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult EnableTeamVoice(bool enable);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetRoomType(EnumRoomType room_type, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetRoomMaxMember(uint max_member, string user_data);
}
