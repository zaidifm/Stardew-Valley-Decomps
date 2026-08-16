using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class QueryIsOwnedDlcsResult : EventBase
{
	public List<RailDlcOwned> dlc_owned_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QueryIsOwnedDlcsResult()
	{
	}
}
