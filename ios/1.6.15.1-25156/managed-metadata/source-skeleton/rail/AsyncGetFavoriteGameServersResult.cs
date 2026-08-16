using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class AsyncGetFavoriteGameServersResult : EventBase
{
	public List<RailID> server_id_array;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncGetFavoriteGameServersResult()
	{
	}
}
