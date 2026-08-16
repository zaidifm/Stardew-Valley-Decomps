using System.Runtime.CompilerServices;

namespace rail;

public class SyncSpaceWorkResult : EventBase
{
	public SpaceWorkID id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SyncSpaceWorkResult()
	{
	}
}
