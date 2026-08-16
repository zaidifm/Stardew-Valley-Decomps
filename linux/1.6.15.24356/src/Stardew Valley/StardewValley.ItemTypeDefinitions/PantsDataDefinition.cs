using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Objects;
using StardewValley.TokenizableStrings;

namespace StardewValley.ItemTypeDefinitions;

public class PantsDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(P)";

	public override string StandardDescriptor => "C";

	public override IEnumerable<string> GetAllIds()
	{
		return Game1.pantsData.Keys;
	}

	public override bool Exists(string itemId)
	{
		if (itemId != null)
		{
			return Game1.pantsData.ContainsKey(itemId);
		}
		return false;
	}

	public override ParsedItemData GetData(string itemId)
	{
		if (itemId == null || !Game1.pantsData.TryGetValue(itemId, out var value))
		{
			return null;
		}
		return new ParsedItemData(this, itemId, value.SpriteIndex, value.Texture ?? "Characters\\Farmer\\pants", value.Name, TokenParser.ParseText(value.DisplayName), TokenParser.ParseText(value.Description), -100, null, value);
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
		return new Rectangle(192 * (spriteIndex % (texture.Width / 192)), 688 * (spriteIndex / (texture.Width / 192)) + 672, 16, 16);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return new Clothing(data.ItemId);
	}
}
