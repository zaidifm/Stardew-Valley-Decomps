using System.Runtime.CompilerServices;

namespace rail;

public interface IRailSystemHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetTerminationTimeoutOwnershipExpired(int timeout_seconds);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailSystemState GetPlatformSystemState();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetDistributeID(out string distribute_id);
}
