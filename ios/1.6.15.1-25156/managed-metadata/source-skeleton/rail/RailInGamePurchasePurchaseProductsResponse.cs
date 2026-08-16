using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailInGamePurchasePurchaseProductsResponse : EventBase
{
	public string order_id;

	public List<RailProductItem> delivered_products;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGamePurchasePurchaseProductsResponse()
	{
	}
}
