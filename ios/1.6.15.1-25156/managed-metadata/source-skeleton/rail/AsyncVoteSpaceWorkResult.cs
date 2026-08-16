using System.Runtime.CompilerServices;

namespace rail;

public class AsyncVoteSpaceWorkResult : EventBase
{
	public SpaceWorkID id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncVoteSpaceWorkResult()
	{
	}
}
