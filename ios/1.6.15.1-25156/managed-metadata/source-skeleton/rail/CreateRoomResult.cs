using System.Runtime.CompilerServices;

namespace rail;

public class CreateRoomResult : EventBase
{
	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreateRoomResult()
	{
	}
}
