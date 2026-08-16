using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Objects;
using StardewValley.TokenizableStrings;

namespace StardewValley.ItemTypeDefinitions;

public class FurnitureDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(F)";

	public override string StandardDescriptor => "F";

	public override IEnumerable<string> GetAllIds()
	{
		return GetDataSheet().Keys;
	}

	public override bool Exists(string itemId)
	{
		if (itemId != null)
		{
			return GetDataSheet().ContainsKey(itemId);
		}
		return false;
	}

	public override ParsedItemData GetData(string itemId)
	{
		string[] rawData = GetRawData(itemId);
		if (rawData == null)
		{
			return null;
		}
		return new ParsedItemData(this, itemId, GetSpriteIndex(itemId, rawData), ArgUtility.Get(rawData, 9, "TileSheets\\furniture", allowBlank: false), ArgUtility.Get(rawData, 0), TokenParser.ParseText(ArgUtility.Get(rawData, 7)), null, -24, null, rawData, isErrorItem: false, ArgUtility.GetBool(rawData, 10));
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
		return Furniture.GetDefaultSourceRect(data.ItemId, texture);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Furniture.GetFurnitureInstance(data.ItemId, Vector2.Zero);
	}

	protected Dictionary<string, string> GetDataSheet()
	{
		return DataLoader.Furniture(Game1.content);
	}

	private string[] GetRawData(string itemId)
	{
		if (itemId == null || !GetDataSheet().TryGetValue(itemId, out var value))
		{
			return null;
		}
		return value.Split('/');
	}

	protected int GetSpriteIndex(string itemId, string[] fields)
	{
		int num = ArgUtility.GetInt(fields, 8, -1);
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
