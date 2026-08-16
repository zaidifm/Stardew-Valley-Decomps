using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailInGamePurchaseRequestAllPurchasableProductsResponse : EventBase
{
	public List<RailPurchaseProductInfo> purchasable_products;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGamePurchaseRequestAllPurchasableProductsResponse()
	{
	}
}
