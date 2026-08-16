using System.Runtime.CompilerServices;

namespace rail;

public class CreateGameServerResult : EventBase
{
	public RailID game_server_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreateGameServerResult()
	{
	}
}
