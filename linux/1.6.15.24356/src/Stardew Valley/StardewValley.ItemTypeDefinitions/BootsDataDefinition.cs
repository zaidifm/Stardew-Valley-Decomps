using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Objects;

namespace StardewValley.ItemTypeDefinitions;

public class BootsDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(B)";

	public override string StandardDescriptor => "B";

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
		return new ParsedItemData(this, itemId, GetSpriteIndex(itemId, rawData), ArgUtility.Get(rawData, 9) ?? "Maps\\springobjects", ArgUtility.Get(rawData, 0), ArgUtility.Get(rawData, 6), ArgUtility.Get(rawData, 1), -97, null, rawData);
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
		return new Boots(data.ItemId);
	}

	protected Dictionary<string, string> GetDataSheet()
	{
		return DataLoader.Boots(Game1.content);
	}

	protected string[] GetRawData(string itemId)
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
