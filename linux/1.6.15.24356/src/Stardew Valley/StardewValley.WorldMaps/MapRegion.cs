using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData.WorldMaps;
using StardewValley.Internal;
using StardewValley.Locations;

namespace StardewValley.WorldMaps;

public class MapRegion
{
	protected Rectangle? CachedPixelBounds;

	protected MapArea[] CachedMapAreas;

	protected MapAreaTexture CachedBaseTexture;

	public string Id { get; }

	public WorldMapRegionData Data { get; }

	public MapRegion(string id, WorldMapRegionData data)
	{
		Id = id;
		Data = data;
	}

	public Rectangle GetMapPixelBounds()
	{
		Rectangle? cachedPixelBounds = CachedPixelBounds;
		if (!cachedPixelBounds.HasValue)
		{
			MapAreaTexture baseTexture = GetBaseTexture();
			MapArea[] areas = GetAreas();
			int num = baseTexture?.MapPixelArea.Width ?? 0;
			int num2 = baseTexture?.MapPixelArea.Height ?? 0;
			MapArea[] array = areas;
			for (int i = 0; i < array.Length; i++)
			{
				MapAreaTexture[] textures = array[i].GetTextures();
				foreach (MapAreaTexture mapAreaTexture in textures)
				{
					num = Math.Max(num, mapAreaTexture.MapPixelArea.Width);
					num2 = Math.Max(num2, mapAreaTexture.MapPixelArea.Height);
				}
			}
			Vector2 topLeftPositionForCenteringOnScreen = Utility.getTopLeftPositionForCenteringOnScreen(num, num2);
			CachedPixelBounds = new Rectangle((int)topLeftPositionForCenteringOnScreen.X, (int)topLeftPositionForCenteringOnScreen.Y, num / 4, num2 / 4);
		}
		return CachedPixelBounds.Value;
	}

	public MapAreaTexture GetBaseTexture()
	{
		if (CachedBaseTexture == null)
		{
			if (Data.BaseTexture.Count > 0)
			{
				foreach (WorldMapTextureData item in Data.BaseTexture)
				{
					if (GameStateQuery.CheckConditions(item.Condition))
					{
						Texture2D texture = GetTexture(item.Texture);
						Rectangle rectangle = item.SourceRect;
						if (rectangle.IsEmpty)
						{
							rectangle = new Rectangle(0, 0, texture.Width, texture.Height);
						}
						Rectangle rectangle2 = item.MapPixelArea;
						if (rectangle2.IsEmpty)
						{
							rectangle2 = rectangle;
						}
						CachedBaseTexture = new MapAreaTexture(mapPixelArea: new Rectangle(rectangle2.X * 4, rectangle2.Y * 4, rectangle2.Width * 4, rectangle2.Height * 4), texture: texture, sourceRect: rectangle);
						break;
					}
				}
			}
			if (CachedBaseTexture == null)
			{
				CachedBaseTexture = new MapAreaTexture(null, Rectangle.Empty, Rectangle.Empty);
			}
		}
		if (CachedBaseTexture.Texture == null)
		{
			return null;
		}
		return CachedBaseTexture;
	}

	public MapArea[] GetAreas()
	{
		if (CachedMapAreas == null)
		{
			List<MapArea> list = new List<MapArea>();
			foreach (WorldMapAreaData mapArea in Data.MapAreas)
			{
				if (GameStateQuery.CheckConditions(mapArea.Condition))
				{
					list.Add(new MapArea(this, mapArea));
				}
			}
			CachedMapAreas = list.ToArray();
		}
		return CachedMapAreas;
	}

	public MapAreaPosition GetPositionData(GameLocation location, Point tile)
	{
		return GetPositionData(location, tile, null);
	}

	internal MapAreaPosition GetPositionData(GameLocation location, Point tile, LogBuilder log)
	{
		if (location == null)
		{
			log?.AppendLine("Skipped: location is null.");
			return null;
		}
		string locationName = GetLocationName(location);
		string locationContextId = location.GetLocationContextId();
		LogBuilder log2 = log?.GetIndentedLog();
		MapArea[] areas = GetAreas();
		foreach (MapArea mapArea in areas)
		{
			log?.AppendLine("Checking map area '" + mapArea.Id + "'...");
			MapAreaPosition worldPosition = mapArea.GetWorldPosition(locationName, locationContextId, tile, log2);
			if (worldPosition != null)
			{
				return worldPosition;
			}
		}
		return null;
	}

	protected string GetLocationName(GameLocation location)
	{
		string text = ((location.IsTemporary && !string.IsNullOrEmpty(location.Map.Id)) ? location.Map.Id : location.Name);
		if (text == "Mine")
		{
			return "Mines";
		}
		if (location is MineShaft mineShaft)
		{
			if (mineShaft.mineLevel <= 120 || mineShaft.mineLevel == 77377)
			{
				return "Mines";
			}
			return "SkullCave";
		}
		if (VolcanoDungeon.IsGeneratedLevel(location.Name))
		{
			return "VolcanoDungeon";
		}
		return text;
	}

	private Texture2D GetTexture(string assetName)
	{
		if (Game1.season != Season.Spring)
		{
			string assetName2 = assetName + "_" + Game1.currentSeason.ToLower();
			if (Game1.content.DoesAssetExist<Texture2D>(assetName2))
			{
				return Game1.content.Load<Texture2D>(assetName2);
			}
		}
		return Game1.content.Load<Texture2D>(assetName);
	}
}
