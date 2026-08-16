using System.Runtime.CompilerServices;

namespace StardewValley.SDKs;

public interface SDKHelper
{
	bool IsEnterButtonAssignmentFlipped
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool IsJapaneseRegionRelease
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	SDKNetHelper Networking
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool ConnectionFinished
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	int ConnectionProgress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool HasOverlay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void EarlyInitialize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Initialize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Update();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Shutdown();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void DebugInfo();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool RetroactiveAchievementsAllowed();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void SubmitLeaderboardScore(string leaderboardId, int score);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void GetAchievement(string achieve);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ResetAchievements();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string FilterDirtyWords(string words);
}
