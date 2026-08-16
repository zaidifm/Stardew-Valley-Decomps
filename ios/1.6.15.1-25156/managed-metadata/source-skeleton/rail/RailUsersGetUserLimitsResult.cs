using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailUsersGetUserLimitsResult : EventBase
{
	public RailID user_id;

	public List<EnumRailUsersLimits> user_limits;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUsersGetUserLimitsResult()
	{
	}
}
