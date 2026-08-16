using System.Collections.Generic;
using StardewValley.GameData.Shops;

namespace StardewValley;

public class ItemStockInformation
{
	public int Price;

	public int Stock;

	public string TradeItem;

	public int? TradeItemCount;

	public LimitedStockMode LimitedStockMode;

	public string SyncedKey;

	public ISalable ItemToSyncStack;

	public StackDrawType? StackDrawType;

	public List<string> ActionsOnPurchase;

	public ItemStockInformation(int price, int stock, string tradeItem = null, int? tradeItemCount = null, LimitedStockMode stockMode = LimitedStockMode.Global, string syncedKey = null, ISalable itemToSyncStack = null, StackDrawType? stackDrawType = null, List<string> actionsOnPurchase = null)
	{
		Price = price;
		Stock = stock;
		TradeItem = tradeItem;
		TradeItemCount = tradeItemCount;
		LimitedStockMode = stockMode;
		SyncedKey = syncedKey;
		ItemToSyncStack = itemToSyncStack;
		StackDrawType = stackDrawType;
		ActionsOnPurchase = actionsOnPurchase;
	}
}
