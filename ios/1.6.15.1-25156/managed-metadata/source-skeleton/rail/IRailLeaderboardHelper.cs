using System.Runtime.CompilerServices;

namespace rail;

public interface IRailLeaderboardHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailLeaderboard OpenLeaderboard(string leaderboard_name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailLeaderboard AsyncCreateLeaderboard(string leaderboard_name, LeaderboardSortType sort_type, LeaderboardDisplayType display_type, string user_data, out RailResult result);
}
