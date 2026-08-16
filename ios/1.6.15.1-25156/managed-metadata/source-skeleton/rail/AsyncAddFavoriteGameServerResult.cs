using System.Runtime.CompilerServices;

namespace rail;

public class AsyncAddFavoriteGameServerResult : EventBase
{
	public RailID server_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncAddFavoriteGameServerResult()
	{
	}
}
