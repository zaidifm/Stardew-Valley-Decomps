using System.Runtime.CompilerServices;

namespace rail;

public class GlobalAchievementReceived : EventBase
{
	public int count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalAchievementReceived()
	{
	}
}
