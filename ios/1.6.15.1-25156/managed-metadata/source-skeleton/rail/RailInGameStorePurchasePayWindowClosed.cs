using System.Runtime.CompilerServices;

namespace rail;

public class RailInGameStorePurchasePayWindowClosed : EventBase
{
	public string order_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGameStorePurchasePayWindowClosed()
	{
	}
}
