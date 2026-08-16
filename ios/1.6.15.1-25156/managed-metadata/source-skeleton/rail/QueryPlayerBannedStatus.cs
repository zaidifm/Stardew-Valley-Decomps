using System.Runtime.CompilerServices;

namespace rail;

public class QueryPlayerBannedStatus : EventBase
{
	public EnumRailPlayerBannedStatus status;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QueryPlayerBannedStatus()
	{
	}
}
