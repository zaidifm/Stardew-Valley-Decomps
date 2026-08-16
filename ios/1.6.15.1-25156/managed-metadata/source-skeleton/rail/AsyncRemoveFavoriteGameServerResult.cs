using System.Runtime.CompilerServices;

namespace rail;

public class AsyncRemoveFavoriteGameServerResult : EventBase
{
	public RailID server_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncRemoveFavoriteGameServerResult()
	{
	}
}
