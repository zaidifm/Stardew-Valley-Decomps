using System.Runtime.CompilerServices;

namespace rail;

public class IRailLeaderboardHelperImpl : RailObject, IRailLeaderboardHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailLeaderboardHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailLeaderboardHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailLeaderboard OpenLeaderboard(string leaderboard_name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailLeaderboard AsyncCreateLeaderboard(string leaderboard_name, LeaderboardSortType sort_type, LeaderboardDisplayType display_type, string user_data, out RailResult result)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
