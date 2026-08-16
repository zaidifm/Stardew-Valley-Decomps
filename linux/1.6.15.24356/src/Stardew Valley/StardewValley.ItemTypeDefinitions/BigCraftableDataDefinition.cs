using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData.BigCraftables;
using StardewValley.Objects;
using StardewValley.TokenizableStrings;

namespace StardewValley.ItemTypeDefinitions;

public class BigCraftableDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(BC)";

	public override string StandardDescriptor => "BO";

	public override IEnumerable<string> GetAllIds()
	{
		return Game1.bigCraftableData.Keys;
	}

	public override bool Exists(string itemId)
	{
		if (itemId != null)
		{
			return Game1.bigCraftableData.ContainsKey(itemId);
		}
		return false;
	}

	public override ParsedItemData GetData(string itemId)
	{
		BigCraftableData rawData = GetRawData(itemId);
		if (rawData == null)
		{
			return null;
		}
		return new ParsedItemData(this, itemId, rawData.SpriteIndex, rawData.Texture ?? "TileSheets\\Craftables", rawData.Name, TokenParser.ParseText(rawData.DisplayName), TokenParser.ParseText(rawData.Description), -9, "Crafting", rawData);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (data.QualifiedItemId == "(BC)221")
		{
			return new ItemPedestal(Vector2.Zero, null, lock_on_success: false, Color.White);
		}
		return new Object(Vector2.Zero, data.ItemId);
	}

	public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Object.getSourceRectForBigCraftable(texture, spriteIndex);
	}

	protected BigCraftableData GetRawData(string itemId)
	{
		if (itemId == null || !Game1.bigCraftableData.TryGetValue(itemId, out var value))
		{
			return null;
		}
		return value;
	}
}
