using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailQueryGameActivityResult : EventBase
{
	public List<RailGameActivityInfo> game_activities;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailQueryGameActivityResult()
	{
	}
}
