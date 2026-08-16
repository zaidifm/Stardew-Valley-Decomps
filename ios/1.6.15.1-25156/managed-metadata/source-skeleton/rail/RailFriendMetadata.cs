using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendMetadata
{
	public RailID friend_rail_id;

	public List<RailKeyValue> metadatas;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendMetadata()
	{
	}
}
