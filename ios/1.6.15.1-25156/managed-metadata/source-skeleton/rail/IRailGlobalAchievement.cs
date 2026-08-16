using System.Runtime.CompilerServices;

namespace rail;

public interface IRailGlobalAchievement : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestAchievement(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGlobalAchievedPercent(string name, out double percent);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGlobalAchievedPercentDescending(int index, out string name, out double percent);
}
