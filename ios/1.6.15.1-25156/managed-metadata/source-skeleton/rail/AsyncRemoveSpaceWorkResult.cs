using System.Runtime.CompilerServices;

namespace rail;

public class AsyncRemoveSpaceWorkResult : EventBase
{
	public SpaceWorkID id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncRemoveSpaceWorkResult()
	{
	}
}
