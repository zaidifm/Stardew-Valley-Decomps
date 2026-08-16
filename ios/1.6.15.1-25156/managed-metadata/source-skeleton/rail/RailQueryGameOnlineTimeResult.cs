using System.Runtime.CompilerServices;

namespace rail;

public class RailQueryGameOnlineTimeResult : EventBase
{
	public uint game_online_time_seconds;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailQueryGameOnlineTimeResult()
	{
	}
}
