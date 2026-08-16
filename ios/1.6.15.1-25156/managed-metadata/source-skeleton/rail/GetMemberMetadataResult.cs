using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class GetMemberMetadataResult : EventBase
{
	public List<RailKeyValue> key_value;

	public ulong room_id;

	public RailID member_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetMemberMetadataResult()
	{
	}
}
