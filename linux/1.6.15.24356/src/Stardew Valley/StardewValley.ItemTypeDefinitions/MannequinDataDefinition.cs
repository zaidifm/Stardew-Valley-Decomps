using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData;
using StardewValley.Objects;
using StardewValley.TokenizableStrings;

namespace StardewValley.ItemTypeDefinitions;

public class MannequinDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(M)";

	public override string StandardDescriptor => "M";

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
		return new ParsedItemData(this, itemId, value.SheetIndex, value.Texture ?? "TileSheets/Mannequins", itemId, TokenParser.ParseText(value.DisplayName), TokenParser.ParseText(value.Description), -24, null, null);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		return new Mannequin(data.ItemId);
	}

	public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
	{
		return Object.getSourceRectForBigCraftable(texture, spriteIndex);
	}

	protected Dictionary<string, MannequinData> GetDataSheet()
	{
		return DataLoader.Mannequins(Game1.content);
	}
}
