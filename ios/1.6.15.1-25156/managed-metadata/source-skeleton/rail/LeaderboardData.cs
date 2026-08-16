using System.Runtime.CompilerServices;

namespace rail;

public class LeaderboardData
{
	public string additional_infomation;

	public double score;

	public int rank;

	public SpaceWorkID spacework_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeaderboardData()
	{
	}
}
