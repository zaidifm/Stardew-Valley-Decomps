using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Shops;

public class ShopData
{
	[ContentSerializer(Optional = true)]
	public int Currency;

	[ContentSerializer(Optional = true)]
	public StackSizeVisibility? StackSizeVisibility;

	[ContentSerializer(Optional = true)]
	public string OpenSound;

	[ContentSerializer(Optional = true)]
	public string PurchaseSound;

	[ContentSerializer(Optional = true)]
	public string PurchaseRepeatSound;

	[ContentSerializer(Optional = true)]
	public bool? ApplyProfitMargins;

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> PriceModifiers;

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode PriceModifierMode;

	[ContentSerializer(Optional = true)]
	public List<ShopOwnerData> Owners;

	[ContentSerializer(Optional = true)]
	public List<ShopThemeData> VisualTheme;

	[ContentSerializer(Optional = true)]
	public List<string> SalableItemTags;

	public List<ShopItemData> Items = new List<ShopItemData>();

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
