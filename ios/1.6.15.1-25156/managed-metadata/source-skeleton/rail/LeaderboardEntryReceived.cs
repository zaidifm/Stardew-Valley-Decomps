using System.Runtime.CompilerServices;

namespace rail;

public class LeaderboardEntryReceived : EventBase
{
	public string leaderboard_name;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeaderboardEntryReceived()
	{
	}
}
