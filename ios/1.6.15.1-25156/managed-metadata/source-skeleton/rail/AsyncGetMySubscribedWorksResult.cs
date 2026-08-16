using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class AsyncGetMySubscribedWorksResult : EventBase
{
	public uint total_available_works;

	public List<RailSpaceWorkDescriptor> spacework_descriptors;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncGetMySubscribedWorksResult()
	{
	}
}
