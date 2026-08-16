using System.Runtime.CompilerServices;

namespace rail;

public class RailPlatformNotifyEventJoinGameByUser : EventBase
{
	public RailID rail_id_to_join;

	public string commandline_info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailPlatformNotifyEventJoinGameByUser()
	{
	}
}
