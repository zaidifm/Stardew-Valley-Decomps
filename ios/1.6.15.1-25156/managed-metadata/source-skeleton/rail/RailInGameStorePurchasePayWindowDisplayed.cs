using System.Runtime.CompilerServices;

namespace rail;

public class RailInGameStorePurchasePayWindowDisplayed : EventBase
{
	public string order_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGameStorePurchasePayWindowDisplayed()
	{
	}
}
