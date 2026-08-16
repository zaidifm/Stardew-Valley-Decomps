using System.Runtime.CompilerServices;

namespace rail;

public class UploadLeaderboardParam
{
	public LeaderboardData data;

	public LeaderboardUploadType type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UploadLeaderboardParam()
	{
	}
}
