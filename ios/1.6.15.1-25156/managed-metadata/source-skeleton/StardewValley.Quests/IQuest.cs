using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Quests;

public interface IQuest
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetDescription();

	[MethodImpl(MethodImplOptions.NoInlining)]
	List<string> GetObjectiveDescriptions();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool CanBeCancelled();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void MarkAsViewed();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ShouldDisplayAsNew();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ShouldDisplayAsComplete();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsTimedQuest();

	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetDaysLeft();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsHidden();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool HasReward();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool HasMoneyReward();

	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetMoneyReward();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void OnMoneyRewardClaimed();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool OnLeaveQuestPage();
}
