using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Shops;

public class ShopItemData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public List<string> ActionsOnPurchase;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;

	[ContentSerializer(Optional = true)]
	public string TradeItemId { get; set; }

	[ContentSerializer(Optional = true)]
	public int TradeItemAmount { get; set; } = 1;

	[ContentSerializer(Optional = true)]
	public int Price { get; set; } = -1;

	[ContentSerializer(Optional = true)]
	public bool? ApplyProfitMargins { get; set; }

	[ContentSerializer(Optional = true)]
	public int AvailableStock { get; set; } = -1;

	[ContentSerializer(Optional = true)]
	public LimitedStockMode AvailableStockLimit { get; set; }

	[ContentSerializer(Optional = true)]
	public bool AvoidRepeat { get; set; }

	[ContentSerializer(Optional = true)]
	public bool UseObjectDataPrice { get; set; }

	[ContentSerializer(Optional = true)]
	public bool IgnoreShopPriceModifiers { get; set; }

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> PriceModifiers { get; set; }

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode PriceModifierMode { get; set; }

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> AvailableStockModifiers { get; set; }

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode AvailableStockModifierMode { get; set; }
}
