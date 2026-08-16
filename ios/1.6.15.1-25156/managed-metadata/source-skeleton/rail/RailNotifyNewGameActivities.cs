using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailNotifyNewGameActivities : EventBase
{
	public List<RailGameActivityInfo> game_activities;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailNotifyNewGameActivities()
	{
	}
}
