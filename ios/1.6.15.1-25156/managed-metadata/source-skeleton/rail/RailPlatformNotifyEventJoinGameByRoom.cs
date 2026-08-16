using System.Runtime.CompilerServices;

namespace rail;

public class RailPlatformNotifyEventJoinGameByRoom : EventBase
{
	public string commandline_info;

	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailPlatformNotifyEventJoinGameByRoom()
	{
	}
}
