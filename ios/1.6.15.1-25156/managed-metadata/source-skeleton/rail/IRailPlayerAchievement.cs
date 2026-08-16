using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailPlayerAchievement : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetRailID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestAchievement(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult HasAchieved(string name, out bool achieved);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetAchievementInfo(string name, out string achievement_info);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncTriggerAchievementProgress(string name, uint current_value, uint max_value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncTriggerAchievementProgress(string name, uint current_value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult MakeAchievement(string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult CancelAchievement(string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncStoreAchievement(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ResetAllAchievements();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetAllAchievementsName(List<string> names);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetAchievementInfo(string name, RailPlayerAchievementInfo achievement_info);
}
