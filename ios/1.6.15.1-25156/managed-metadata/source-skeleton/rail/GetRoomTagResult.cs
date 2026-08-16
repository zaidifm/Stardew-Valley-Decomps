using System.Runtime.CompilerServices;

namespace rail;

public class GetRoomTagResult : EventBase
{
	public string room_tag;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetRoomTagResult()
	{
	}
}
