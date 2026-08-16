using System.Runtime.CompilerServices;

namespace rail;

public interface IRailLeaderboardEntries : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetRailID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetLeaderboardName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestLeaderboardEntries(RailID player, RequestLeaderboardEntryParam param, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RequestLeaderboardEntryParam GetEntriesParam();

	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetEntriesCount();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetLeaderboardEntry(int index, LeaderboardEntry leaderboard_entry);
}
