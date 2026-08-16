using System.Runtime.CompilerServices;

namespace rail;

public class RailInGameStorePurchaseResult : EventBase
{
	public string order_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGameStorePurchaseResult()
	{
	}
}
