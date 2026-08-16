using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailQueryGroupsInfoResult : EventBase
{
	public List<string> group_ids;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailQueryGroupsInfoResult()
	{
	}
}
