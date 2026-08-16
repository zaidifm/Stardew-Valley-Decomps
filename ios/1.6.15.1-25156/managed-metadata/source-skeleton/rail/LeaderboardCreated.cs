using System.Runtime.CompilerServices;

namespace rail;

public class LeaderboardCreated : EventBase
{
	public string leaderboard_name;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeaderboardCreated()
	{
	}
}
