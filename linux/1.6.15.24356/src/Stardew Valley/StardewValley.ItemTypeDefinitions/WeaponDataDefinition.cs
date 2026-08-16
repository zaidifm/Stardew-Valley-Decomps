using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData.Weapons;
using StardewValley.TokenizableStrings;
using StardewValley.Tools;

namespace StardewValley.ItemTypeDefinitions;

public class WeaponDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(W)";

	public override string StandardDescriptor => "W";

	public override IEnumerable<string> GetAllIds()
	{
		return Game1.weaponData.Keys;
	}

	public override bool Exists(string itemId)
	{
		if (itemId != null)
		{
			return Game1.weaponData.ContainsKey(itemId);
		}
		return false;
	}

	public override ParsedItemData GetData(string itemId)
	{
		WeaponData rawData = GetRawData(itemId);
		if (rawData == null)
		{
			return null;
		}
		return new ParsedItemData(this, itemId, rawData.SpriteIndex, rawData.Texture, rawData.Name, TokenParser.ParseText(rawData.DisplayName), TokenParser.ParseText(rawData.Description), MeleeWeapon.IsScythe("(W)" + itemId) ? (-99) : (-98), null, rawData);
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
		return Game1.getSourceRectForStandardTileSheet(texture, spriteIndex, 16, 16);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		string itemId = data.ItemId;
		switch (itemId)
		{
		default:
			return new MeleeWeapon(itemId);
		case "32":
		case "33":
		case "34":
			return new Slingshot(itemId);
		}
	}

	protected WeaponData GetRawData(string itemId)
	{
		if (itemId == null || !Game1.weaponData.TryGetValue(itemId, out var value))
		{
			return null;
		}
		return value;
	}

	protected int GetSpriteIndex(string itemId, string[] fields)
	{
		int num = ArgUtility.GetInt(fields, 15, -1);
		if (num > -1)
		{
			return num;
		}
		if (int.TryParse(itemId, out var result))
		{
			return result;
		}
		return -1;
	}
}
