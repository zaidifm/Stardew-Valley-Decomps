using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace StardewValley.SDKs.GameCenter;

public class GameCenterHelper : SDKHelper
{
	public bool IsEnterButtonAssignmentFlipped
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsJapaneseRegionRelease
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public SDKNetHelper Networking
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool ConnectionFinished
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int ConnectionProgress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool HasOverlay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern void GameCenter_Init();

	[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern void GameCenter_RunCallbacks();

	[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern void GameCenter_Shutdown();

	[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern void GameCenter_Leaderboard_SubmitScore(nint leaderboardId, int score);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EarlyInitialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RetroactiveAchievementsAllowed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubmitLeaderboardScore(string leaderboardId, int score)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetAchievement(string achieve)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shutdown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugInfo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string FilterDirtyWords(string words)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameCenterHelper()
	{
	}
}
