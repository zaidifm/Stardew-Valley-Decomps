using System.Runtime.CompilerServices;

namespace rail;

public interface IRailAchievementHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailPlayerAchievement CreatePlayerAchievement(RailID player);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGlobalAchievement GetGlobalAchievement();
}
