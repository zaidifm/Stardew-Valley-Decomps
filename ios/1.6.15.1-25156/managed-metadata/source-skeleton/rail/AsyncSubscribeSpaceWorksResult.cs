using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class AsyncSubscribeSpaceWorksResult : EventBase
{
	public List<SpaceWorkID> success_ids;

	public List<SpaceWorkID> failure_ids;

	public bool subscribe;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncSubscribeSpaceWorksResult()
	{
	}
}
