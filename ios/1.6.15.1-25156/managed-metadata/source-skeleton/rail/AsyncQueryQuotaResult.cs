using System.Runtime.CompilerServices;

namespace rail;

public class AsyncQueryQuotaResult : EventBase
{
	public ulong available_quota;

	public ulong total_quota;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncQueryQuotaResult()
	{
	}
}
