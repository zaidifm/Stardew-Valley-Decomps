using System.Runtime.CompilerServices;

namespace rail;

public class RailOpenGameActivityWindowResult : EventBase
{
	public ulong activity_id;

	public bool is_show;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailOpenGameActivityWindowResult()
	{
	}
}
