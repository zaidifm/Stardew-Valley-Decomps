using System.Runtime.CompilerServices;

namespace rail;

public class LeaderboardEntry
{
	public RailID player_id;

	public LeaderboardData data;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeaderboardEntry()
	{
	}
}
