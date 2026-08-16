using System.Runtime.CompilerServices;

namespace rail;

public class RequestLeaderboardEntryParam
{
	public int range_end;

	public int range_start;

	public LeaderboardType type;

	public bool user_coordinate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequestLeaderboardEntryParam()
	{
	}
}
