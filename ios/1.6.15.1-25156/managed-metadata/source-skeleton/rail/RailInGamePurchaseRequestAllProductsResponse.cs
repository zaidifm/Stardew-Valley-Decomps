using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailInGamePurchaseRequestAllProductsResponse : EventBase
{
	public List<RailPurchaseProductInfo> all_products;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGamePurchaseRequestAllProductsResponse()
	{
	}
}
