namespace StardewValley.Internal;

public class ItemQueryResult
{
	public ISalable Item;

	public int? OverrideBasePrice;

	public int? OverrideStackSize;

	public int? OverrideShopAvailableStock;

	public string OverrideTradeItemId;

	public int? OverrideTradeItemAmount;

	public Item SyncStacksWith;

	public ItemQueryResult(ISalable item)
	{
		Item = item;
	}
}
