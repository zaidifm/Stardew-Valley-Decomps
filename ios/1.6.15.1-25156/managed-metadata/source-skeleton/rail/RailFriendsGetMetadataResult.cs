using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsGetMetadataResult : EventBase
{
	public RailID friend_id;

	public List<RailKeyValueResult> friend_kvs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsGetMetadataResult()
	{
	}
}
