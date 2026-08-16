using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailInGamePurchasePurchaseProductsToAssetsResponse : EventBase
{
	public string order_id;

	public List<RailAssetInfo> delivered_assets;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGamePurchasePurchaseProductsToAssetsResponse()
	{
	}
}
