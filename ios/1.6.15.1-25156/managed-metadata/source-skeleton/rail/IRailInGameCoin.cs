using System.Runtime.CompilerServices;

namespace rail;

public interface IRailInGameCoin
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestCoinInfo(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncPurchaseCoins(RailCoins purchase_info, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncPurchaseProducts(RailPurchaseItemsInfo items_info, string user_data);
}
