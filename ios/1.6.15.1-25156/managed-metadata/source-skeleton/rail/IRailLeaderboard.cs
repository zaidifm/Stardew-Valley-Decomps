using System.Runtime.CompilerServices;

namespace rail;

public interface IRailLeaderboard : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetLeaderboardName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetLeaderboardDisplayName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetTotalEntriesCount();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetLeaderboard(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetLeaderboardParameters(LeaderboardParameters param);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailLeaderboardEntries CreateLeaderboardEntries();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncUploadLeaderboard(UploadLeaderboardParam update_param, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetLeaderboardSortType(out int sort_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetLeaderboardDisplayType(out int display_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncAttachSpaceWork(SpaceWorkID spacework_id, string user_data);
}
