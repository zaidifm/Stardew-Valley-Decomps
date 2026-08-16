using System.Runtime.CompilerServices;

namespace rail;

public class LeaderboardAttachSpaceWork : EventBase
{
	public string leaderboard_name;

	public SpaceWorkID spacework_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeaderboardAttachSpaceWork()
	{
	}
}
