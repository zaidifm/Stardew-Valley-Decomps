using System.Runtime.CompilerServices;

namespace rail;

public class AsyncRateSpaceWorkResult : EventBase
{
	public SpaceWorkID id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncRateSpaceWorkResult()
	{
	}
}
