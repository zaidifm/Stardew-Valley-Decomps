using System.Runtime.CompilerServices;

namespace rail;

public class SetRoomTypeResult : EventBase
{
	public EnumRoomType room_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SetRoomTypeResult()
	{
	}
}
