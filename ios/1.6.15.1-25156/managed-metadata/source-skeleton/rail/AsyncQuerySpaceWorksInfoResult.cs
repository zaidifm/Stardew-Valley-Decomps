using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class AsyncQuerySpaceWorksInfoResult : EventBase
{
	public List<RailQuerySpaceWorkInfoResult> query_spaceworks_info_result;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncQuerySpaceWorksInfoResult()
	{
	}
}
