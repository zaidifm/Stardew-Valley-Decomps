using System.Runtime.CompilerServices;

namespace rail;

public class JoinRoomResult : EventBase
{
	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JoinRoomResult()
	{
	}
}
