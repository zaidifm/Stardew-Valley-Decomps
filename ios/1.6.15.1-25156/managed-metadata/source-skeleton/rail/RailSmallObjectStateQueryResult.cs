using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailSmallObjectStateQueryResult : EventBase
{
	public List<RailSmallObjectState> objects_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSmallObjectStateQueryResult()
	{
	}
}
