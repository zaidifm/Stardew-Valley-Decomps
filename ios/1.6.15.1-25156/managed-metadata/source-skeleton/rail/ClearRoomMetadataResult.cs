using System.Runtime.CompilerServices;

namespace rail;

public class ClearRoomMetadataResult : EventBase
{
	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClearRoomMetadataResult()
	{
	}
}
