using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewValley.GameData.WorldMaps;
using StardewValley.Internal;
using StardewValley.TokenizableStrings;
using xTile.Dimensions;

namespace StardewValley.WorldMaps;

public class MapAreaPosition
{
	protected Microsoft.Xna.Framework.Rectangle? CachedMapPixelArea;

	protected string CachedScrollText;

	protected bool IsFixedMapPosition;

	public MapRegion Region { get; }

	public MapArea Area { get; }

	public WorldMapAreaPositionData Data { get; }

	public MapAreaPosition(MapArea mapArea, WorldMapAreaPositionData data)
	{
		Region = mapArea.Region;
		Area = mapArea;
		Data = data;
	}

	public bool Matches(string locationName, string contextName, Point tile)
	{
		return Matches(locationName, contextName, tile, null);
	}

	internal bool Matches(string locationName, string contextName, Point tile, LogBuilder log)
	{
		WorldMapAreaPositionData data = Data;
		if (data.LocationContext != null && data.LocationContext != contextName)
		{
			log?.AppendLine($"Skipped: location context '{contextName}' doesn't match required context '{data.LocationContext}'.");
			return false;
		}
		if (data.LocationName != null && data.LocationName != locationName)
		{
			log?.AppendLine($"Skipped: location '{locationName}' doesn't match required location '{data.LocationName}'.");
			return false;
		}
		List<string> locationNames = data.LocationNames;
		if (locationNames != null && locationNames.Count > 0 && !data.LocationNames.Contains(locationName))
		{
			log?.AppendLine($"Skipped: location '{locationName}' doesn't match one of the required locations '{string.Join("', '", data.LocationNames)}'.");
			return false;
		}
		if (!IsTileWithinZone(tile))
		{
			log?.AppendLine($"Skipped: tile position {tile} doesn't match required tile zone {Data.ExtendedTileArea ?? Data.TileArea}.");
			return false;
		}
		log?.AppendLine("Matched successfully.");
		return true;
	}

	public Microsoft.Xna.Framework.Rectangle GetPixelArea()
	{
		Microsoft.Xna.Framework.Rectangle? cachedMapPixelArea = CachedMapPixelArea;
		if (!cachedMapPixelArea.HasValue)
		{
			Microsoft.Xna.Framework.Rectangle rectangle = Data.MapPixelArea;
			if (rectangle.IsEmpty)
			{
				rectangle = Area.Data.PixelArea;
			}
			Microsoft.Xna.Framework.Rectangle value = new Microsoft.Xna.Framework.Rectangle(rectangle.X * 4, rectangle.Y * 4, rectangle.Width * 4, rectangle.Height * 4);
			CachedMapPixelArea = value;
			IsFixedMapPosition = rectangle.Width <= 1 && rectangle.Height <= 1;
		}
		return CachedMapPixelArea.Value;
	}

	public Vector2 GetMapPixelPosition(GameLocation location, Point tileLocation)
	{
		Microsoft.Xna.Framework.Rectangle pixelArea = GetPixelArea();
		if (IsFixedMapPosition)
		{
			return new Vector2(pixelArea.X, pixelArea.Y);
		}
		Vector2? positionRatioIfValid = GetPositionRatioIfValid(location, tileLocation);
		if (positionRatioIfValid.HasValue)
		{
			return new Vector2(Utility.Lerp(pixelArea.Left, pixelArea.Right, positionRatioIfValid.Value.X), Utility.Lerp(pixelArea.Top, pixelArea.Bottom, positionRatioIfValid.Value.Y));
		}
		Point center = pixelArea.Center;
		return new Vector2(center.X, center.Y);
	}

	public string GetScrollText(Point playerTile)
	{
		if (CachedScrollText == null)
		{
			string scrollText = Data.ScrollText;
			List<WorldMapAreaPositionScrollTextZoneData> scrollTextZones = Data.ScrollTextZones;
			if (scrollTextZones != null && scrollTextZones.Count > 0)
			{
				foreach (WorldMapAreaPositionScrollTextZoneData scrollTextZone in Data.ScrollTextZones)
				{
					if (scrollTextZone.TileArea.Contains(playerTile))
					{
						scrollText = scrollTextZone.ScrollText;
						break;
					}
				}
			}
			CachedScrollText = ((scrollText != null) ? TokenParser.ParseText(Utility.TrimLines(scrollText)) : Area.GetScrollText());
		}
		return CachedScrollText;
	}

	public virtual Vector2? GetPositionRatioIfValid(GameLocation location, Point tile)
	{
		if (location?.map == null || !IsTileWithinZone(tile))
		{
			return null;
		}
		Size layerSize = location.map.Layers[0].LayerSize;
		Microsoft.Xna.Framework.Rectangle rectangle = Data.TileArea;
		if (rectangle.IsEmpty || rectangle.Right > layerSize.Width || rectangle.Bottom > layerSize.Height)
		{
			rectangle = (rectangle.IsEmpty ? new Microsoft.Xna.Framework.Rectangle(0, 0, layerSize.Width, layerSize.Height) : new Microsoft.Xna.Framework.Rectangle(rectangle.X, rectangle.Y, Math.Min(rectangle.Width, layerSize.Width - rectangle.X), Math.Min(rectangle.Height, layerSize.Height - rectangle.Y)));
		}
		float num = MathHelper.Clamp(tile.X, rectangle.X, rectangle.Right - 1);
		return new Vector2(y: ((float)MathHelper.Clamp(tile.Y, rectangle.Y, rectangle.Bottom - 1) - (float)rectangle.Y) / (float)rectangle.Height, x: (num - (float)rectangle.X) / (float)rectangle.Width);
	}

	public virtual bool IsTileWithinZone(Point tile)
	{
		Microsoft.Xna.Framework.Rectangle rectangle = Data.ExtendedTileArea ?? Data.TileArea;
		if (!rectangle.IsEmpty)
		{
			return rectangle.Contains(tile);
		}
		return true;
	}
}
