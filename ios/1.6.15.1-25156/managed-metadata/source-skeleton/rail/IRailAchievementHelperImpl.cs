using System.Runtime.CompilerServices;

namespace rail;

public class IRailAchievementHelperImpl : RailObject, IRailAchievementHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailAchievementHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailAchievementHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailPlayerAchievement CreatePlayerAchievement(RailID player)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailGlobalAchievement GetGlobalAchievement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
