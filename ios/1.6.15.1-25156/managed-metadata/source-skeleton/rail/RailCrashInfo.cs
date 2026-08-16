using System.Runtime.CompilerServices;

namespace rail;

public class RailCrashInfo
{
	public RailUtilsCrashType exception_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailCrashInfo()
	{
	}
}
