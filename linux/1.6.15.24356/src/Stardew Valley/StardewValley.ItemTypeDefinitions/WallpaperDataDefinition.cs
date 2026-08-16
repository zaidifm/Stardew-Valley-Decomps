using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData;
using StardewValley.Objects;

namespace StardewValley.ItemTypeDefinitions;

public class WallpaperDataDefinition : BaseItemDataDefinition
{
	protected const int LegacyWallpaperCount = 112;

	public override string Identifier => "(WP)";

	public override IEnumerable<string> GetAllIds()
	{
		for (int i = 0; i < 112; i++)
		{
			yield return i.ToString();
		}
		List<ModWallpaperOrFlooring> list = DataLoader.AdditionalWallpaperFlooring(Game1.content);
		foreach (ModWallpaperOrFlooring set in list)
		{
			if (!set.IsFlooring)
			{
				for (int i = 0; i < set.Count; i++)
				{
					yield return set.Id + ":" + i;
				}
			}
		}
	}

	public override bool Exists(string itemId)
	{
		if (itemId == null)
		{
			return false;
		}
		if (TryParseLegacyId(itemId, out var _))
		{
			return true;
		}
		ParseStandardId(itemId, out var id, out var index);
		ModWallpaperOrFlooring wallpaperSet = GetWallpaperSet(id);
		return index < wallpaperSet?.Count;
	}

	public override ParsedItemData GetData(string itemId)
	{
		if (itemId != null)
		{
			if (TryParseLegacyId(itemId, out var legacyId))
			{
				return GetData(itemId, legacyId, "Maps\\walls_and_floors", null);
			}
			ParseStandardId(itemId, out var id, out var index);
			ModWallpaperOrFlooring wallpaperSet = GetWallpaperSet(id);
			if (wallpaperSet != null)
			{
				return GetData(itemId, index, wallpaperSet.Texture, wallpaperSet);
			}
		}
		return null;
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
		return Game1.getSourceRectForStandardTileSheet(texture, spriteIndex, 16, 48);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (TryParseLegacyId(data.ItemId, out var legacyId))
		{
			return new Wallpaper(legacyId);
		}
		ParseStandardId(data.ItemId, out var id, out var index);
		return new Wallpaper(id, index);
	}

	protected bool TryParseLegacyId(string raw, out int legacyId)
	{
		if (int.TryParse(raw, out legacyId) && legacyId >= 0)
		{
			return legacyId < 112;
		}
		return false;
	}

	protected void ParseStandardId(string raw, out string id, out int index)
	{
		id = raw;
		index = 0;
		string[] array = raw.Split(':', 2);
		if (array.Length == 2 && int.TryParse(array[1], out var result))
		{
			id = array[0];
			index = result;
		}
	}

	protected ModWallpaperOrFlooring GetWallpaperSet(string setId)
	{
		foreach (ModWallpaperOrFlooring item in DataLoader.AdditionalWallpaperFlooring(Game1.content))
		{
			if (item.Id == setId)
			{
				if (item.IsFlooring)
				{
					return null;
				}
				return item;
			}
		}
		return null;
	}

	protected ParsedItemData GetData(string itemId, int spriteIndex, string textureName, object rawData)
	{
		return new ParsedItemData(this, itemId, spriteIndex, textureName, "Wallpaper", Game1.content.LoadString("Strings\\StringsFromCSFiles:Wallpaper.cs.13204"), Game1.content.LoadString("Strings\\StringsFromCSFiles:Wallpaper.cs.13206"), 0, null, rawData);
	}
}
