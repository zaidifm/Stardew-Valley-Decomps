using System.Runtime.CompilerServices;

namespace rail;

public interface IRailAntiAddictionHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryGameOnlineTime(string user_data);
}
