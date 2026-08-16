using System.Runtime.CompilerServices;

namespace rail;

public class QuerySubscribeWishPlayStateResult : EventBase
{
	public bool is_subscribed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuerySubscribeWishPlayStateResult()
	{
	}
}
