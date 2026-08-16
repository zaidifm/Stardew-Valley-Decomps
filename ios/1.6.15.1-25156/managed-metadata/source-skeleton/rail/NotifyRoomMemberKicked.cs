using System.Runtime.CompilerServices;

namespace rail;

public class NotifyRoomMemberKicked : EventBase
{
	public RailID id_for_making_kick;

	public uint due_to_kicker_lost_connect;

	public ulong room_id;

	public RailID kicked_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NotifyRoomMemberKicked()
	{
	}
}
