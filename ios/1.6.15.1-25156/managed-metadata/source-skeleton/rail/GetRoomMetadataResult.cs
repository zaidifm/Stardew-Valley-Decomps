using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class GetRoomMetadataResult : EventBase
{
	public List<RailKeyValue> key_value;

	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetRoomMetadataResult()
	{
	}
}
