using System;
using System.Collections.Generic;
using System.Linq;
using StardewValley.Extensions;
using StardewValley.GameData.Shops;
using StardewValley.GameData.Tools;

namespace StardewValley.Internal;

public static class ShopBuilder
{
	public static Dictionary<ISalable, ItemStockInformation> GetShopStock(string shopId)
	{
		if (DataLoader.Shops(Game1.content).TryGetValue(shopId, out var value))
		{
			return GetShopStock(shopId, value);
		}
		return new Dictionary<ISalable, ItemStockInformation>();
	}

	public static Dictionary<ISalable, ItemStockInformation> GetShopStock(string shopId, ShopData shop)
	{
		Dictionary<ISalable, ItemStockInformation> dictionary = new Dictionary<ISalable, ItemStockInformation>();
		List<ShopItemData> items = shop.Items;
		if (items != null && items.Count > 0)
		{
			Random random = Utility.CreateDaySaveRandom();
			HashSet<string> hashSet = new HashSet<string>();
			ItemQueryContext context = new ItemQueryContext(Game1.currentLocation, Game1.player, random, "shop '" + shopId + "'");
			bool applyPierreMissingStockList = shopId == "SeedShop" && Game1.MasterPlayer.hasOrWillReceiveMail("PierreStocklist");
			HashSet<string> hashSet2 = new HashSet<string>();
			foreach (ShopItemData item2 in shop.Items)
			{
				if (!hashSet2.Add(item2.Id))
				{
					Game1.log.Warn($"Shop {shopId} has multiple items with entry ID '{item2.Id}'. This may cause unintended behavior.");
				}
				if (!CheckItemCondition(item2.Condition, applyPierreMissingStockList, out var isOutOfSeason))
				{
					continue;
				}
				IList<ItemQueryResult> list = ItemQueryResolver.TryResolve(item2, context, ItemQuerySearchMode.All, item2.AvoidRepeat, item2.AvoidRepeat ? hashSet : null, null, delegate(string query, string message)
				{
					Game1.log.Error($"Failed parsing shop item query '{query}' for the '{shopId}' shop: {message}.");
				});
				int num = 0;
				foreach (ItemQueryResult item3 in list)
				{
					ISalable item = item3.Item;
					item.Stack = item3.OverrideStackSize ?? item.Stack;
					float value = GetBasePrice(item3, shop, item2, item, isOutOfSeason, item2.UseObjectDataPrice);
					int num2 = item3.OverrideShopAvailableStock ?? item2.AvailableStock;
					LimitedStockMode limitedStockMode = item2.AvailableStockLimit;
					string text = item3.OverrideTradeItemId ?? item2.TradeItemId;
					int? num3 = ((item3.OverrideTradeItemAmount > 0) ? item3.OverrideTradeItemAmount : new int?(item2.TradeItemAmount));
					if (text == null || num3 < 0)
					{
						text = null;
						num3 = null;
					}
					if (item2.IsRecipe)
					{
						item.Stack = 1;
						limitedStockMode = LimitedStockMode.None;
						num2 = 1;
					}
					if (!item2.IgnoreShopPriceModifiers)
					{
						value = Utility.ApplyQuantityModifiers(value, shop.PriceModifiers, shop.PriceModifierMode, null, null, item as Item, null, random);
					}
					value = Utility.ApplyQuantityModifiers(value, item2.PriceModifiers, item2.PriceModifierMode, null, null, item as Item, null, random);
					if (!item2.IsRecipe)
					{
						num2 = (int)Utility.ApplyQuantityModifiers(num2, item2.AvailableStockModifiers, item2.AvailableStockModifierMode, null, null, item as Item, null, random);
					}
					if (!TrackSeenItems(hashSet, item) || !item2.AvoidRepeat)
					{
						if (num2 < 0)
						{
							num2 = int.MaxValue;
						}
						string text2 = item2.Id;
						if (++num > 1)
						{
							text2 += num;
						}
						int price = (int)value;
						int stock = num2;
						string tradeItem = text;
						int? tradeItemCount = num3;
						LimitedStockMode stockMode = limitedStockMode;
						string syncedKey = text2;
						Item syncStacksWith = item3.SyncStacksWith;
						List<string> actionsOnPurchase = item2.ActionsOnPurchase;
						dictionary.Add(item, new ItemStockInformation(price, stock, tradeItem, tradeItemCount, stockMode, syncedKey, syncStacksWith, null, actionsOnPurchase));
					}
				}
			}
		}
		Game1.player.team.synchronizedShopStock.UpdateLocalStockWithSyncedQuanitities(shopId, dictionary);
		return dictionary;
	}

	public static bool CheckItemCondition(string conditions, bool applyPierreMissingStockList, out bool isOutOfSeason)
	{
		if (conditions == null || GameStateQuery.CheckConditions(conditions))
		{
			isOutOfSeason = false;
			return true;
		}
		if (applyPierreMissingStockList && GameStateQuery.CheckConditions(conditions, null, null, null, null, null, GameStateQuery.SeasonQueryKeys))
		{
			isOutOfSeason = true;
			return true;
		}
		isOutOfSeason = false;
		return false;
	}

	public static ToolUpgradeData GetToolUpgradeData(ToolData tool, Farmer player)
	{
		if (tool == null)
		{
			return null;
		}
		IList<ToolUpgradeData> list = tool.UpgradeFrom;
		if (tool.ConventionalUpgradeFrom != null)
		{
			IList<ToolUpgradeData> list2 = new ToolUpgradeData[1]
			{
				new ToolUpgradeData
				{
					RequireToolId = tool.ConventionalUpgradeFrom,
					Price = GetToolUpgradeConventionalPrice(tool.UpgradeLevel),
					TradeItemId = GetToolUpgradeConventionalTradeItem(tool.UpgradeLevel),
					TradeItemAmount = 5
				}
			};
			IList<ToolUpgradeData> list3;
			if (list == null || list.Count <= 0)
			{
				list3 = list2;
			}
			else
			{
				IList<ToolUpgradeData> list4 = list2.Concat(list).ToList();
				list3 = list4;
			}
			list = list3;
		}
		if (list == null)
		{
			return null;
		}
		foreach (ToolUpgradeData item in list)
		{
			if ((item.Condition == null || GameStateQuery.CheckConditions(item.Condition, player.currentLocation, player)) && (item.RequireToolId == null || player.Items.ContainsId(item.RequireToolId)))
			{
				return item;
			}
		}
		return null;
	}

	public static int GetToolUpgradeConventionalPrice(int level)
	{
		return level switch
		{
			1 => 2000, 
			2 => 5000, 
			3 => 10000, 
			4 => 25000, 
			_ => 2000, 
		};
	}

	private static string GetToolUpgradeConventionalTradeItem(int level)
	{
		return level switch
		{
			1 => "334", 
			2 => "335", 
			3 => "336", 
			4 => "337", 
			_ => "334", 
		};
	}

	public static IEnumerable<ShopOwnerData> GetCurrentOwners(ShopData shop)
	{
		return shop?.Owners?.Where((ShopOwnerData owner) => GameStateQuery.CheckConditions(owner.Condition)) ?? LegacyShims.EmptyArray<ShopOwnerData>();
	}

	public static int GetBasePrice(ItemQueryResult output, ShopData shopData, ShopItemData itemData, ISalable item, bool outOfSeasonPrice, bool useObjectDataPrice = false)
	{
		float num = output.OverrideBasePrice ?? itemData.Price;
		if (num < 0f)
		{
			num = ((itemData.TradeItemId != null) ? 0f : ((!useObjectDataPrice || !item.HasTypeObject() || !(item is Object obj)) ? ((float)item.salePrice(ignoreProfitMargins: true)) : ((float)obj.Price)));
		}
		if (itemData.ApplyProfitMargins ?? shopData.ApplyProfitMargins ?? item.appliesProfitMargins())
		{
			num *= Game1.MasterPlayer.difficultyModifier;
		}
		if (outOfSeasonPrice)
		{
			num *= 1.5f;
		}
		return (int)num;
	}

	public static bool TrackSeenItems(HashSet<string> stockedItems, ISalable item)
	{
		string text = item.QualifiedItemId;
		if (item is Tool { UpgradeLevel: >0 } tool)
		{
			text = text + "#" + tool.UpgradeLevel;
		}
		if (item.IsRecipe)
		{
			text += "#Recipe";
		}
		return !stockedItems.Add(text);
	}
}
