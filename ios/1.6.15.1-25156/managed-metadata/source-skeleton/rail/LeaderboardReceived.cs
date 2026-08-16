using System.Runtime.CompilerServices;

namespace rail;

public class LeaderboardReceived : EventBase
{
	public string leaderboard_name;

	public bool does_exist;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeaderboardReceived()
	{
	}
}
