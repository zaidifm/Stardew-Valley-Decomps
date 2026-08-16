using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailInGamePurchase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestAllPurchasableProducts(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestAllProducts(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetProductInfo(uint product_id, RailPurchaseProductInfo product);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncPurchaseProducts(List<RailProductItem> cart_items, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncFinishOrder(string order_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncPurchaseProductsToAssets(List<RailProductItem> cart_items, string user_data);
}
