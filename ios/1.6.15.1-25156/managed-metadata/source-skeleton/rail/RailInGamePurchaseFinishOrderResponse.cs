using System.Runtime.CompilerServices;

namespace rail;

public class RailInGamePurchaseFinishOrderResponse : EventBase
{
	public string order_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGamePurchaseFinishOrderResponse()
	{
	}
}
