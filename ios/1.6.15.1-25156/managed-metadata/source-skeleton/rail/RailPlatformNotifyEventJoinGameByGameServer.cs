using System.Runtime.CompilerServices;

namespace rail;

public class RailPlatformNotifyEventJoinGameByGameServer : EventBase
{
	public string commandline_info;

	public RailID gameserver_railid;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailPlatformNotifyEventJoinGameByGameServer()
	{
	}
}
