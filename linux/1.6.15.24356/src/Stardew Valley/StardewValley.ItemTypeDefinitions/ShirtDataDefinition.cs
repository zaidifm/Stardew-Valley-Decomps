using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Objects;
using StardewValley.TokenizableStrings;

namespace StardewValley.ItemTypeDefinitions;

public class ShirtDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(S)";

	public override string StandardDescriptor => "C";

	public override IEnumerable<string> GetAllIds()
	{
		return Game1.shirtData.Keys;
	}

	public override bool Exists(string itemId)
	{
		if (itemId != null)
		{
			return Game1.shirtData.ContainsKey(itemId);
		}
		return false;
	}

	public override ParsedItemData GetData(string itemId)
	{
		if (itemId == null || !Game1.shirtData.TryGetValue(itemId, out var value))
		{
			return null;
		}
		return new ParsedItemData(this, itemId, value.SpriteIndex, value.Texture ?? "Characters\\Farmer\\shirts", value.Name, TokenParser.ParseText(value.DisplayName), TokenParser.ParseText(value.Description), -100, null, value);
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
		int num = texture.Width / 2;
		return new Rectangle(spriteIndex * 8 % num, spriteIndex * 8 / num * 32, 8, 8);
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
