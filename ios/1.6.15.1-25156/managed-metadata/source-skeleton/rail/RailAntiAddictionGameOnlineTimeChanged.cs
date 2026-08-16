using System.Runtime.CompilerServices;

namespace rail;

public class RailAntiAddictionGameOnlineTimeChanged : EventBase
{
	public uint game_online_time_count_minutes;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailAntiAddictionGameOnlineTimeChanged()
	{
	}
}
