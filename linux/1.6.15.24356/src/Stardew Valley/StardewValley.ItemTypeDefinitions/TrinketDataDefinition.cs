using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData;
using StardewValley.Objects.Trinkets;
using StardewValley.TokenizableStrings;

namespace StardewValley.ItemTypeDefinitions;

public class TrinketDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(TR)";

	public override string StandardDescriptor => "TR";

	public override IEnumerable<string> GetAllIds()
	{
		return GetDataSheet().Keys;
	}

	public override bool Exists(string itemId)
	{
		return GetDataSheet().ContainsKey(itemId);
	}

	public override ParsedItemData GetData(string itemId)
	{
		if (!GetDataSheet().TryGetValue(itemId, out var value))
		{
			return null;
		}
		return new ParsedItemData(this, itemId, value.SheetIndex, value.Texture, itemId, TokenParser.ParseText(value.DisplayName), TokenParser.ParseText(value.Description), -101, null, null);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		return new Trinket(data.ItemId, Game1.random.Next(9999999));
	}

	public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
	{
		return Game1.getSourceRectForStandardTileSheet(texture, spriteIndex, 16, 16);
	}

	protected Dictionary<string, TrinketData> GetDataSheet()
	{
		return DataLoader.Trinkets(Game1.content);
	}
}
