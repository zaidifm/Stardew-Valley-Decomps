using System.Runtime.CompilerServices;

namespace rail;

public interface IRailInGameActivityHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryGameActivity(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncOpenDefaultGameActivityWindow(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncOpenGameActivityWindow(ulong activity_id, string user_data);
}
