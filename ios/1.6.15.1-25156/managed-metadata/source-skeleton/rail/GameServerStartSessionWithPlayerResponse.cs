using System.Runtime.CompilerServices;

namespace rail;

public class GameServerStartSessionWithPlayerResponse : EventBase
{
	public RailID remote_rail_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameServerStartSessionWithPlayerResponse()
	{
	}
}
