using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewValley.Buildings;
using StardewValley.GameData.WorldMaps;
using StardewValley.Internal;

namespace StardewValley.WorldMaps;

public static class WorldMapManager
{
	private static int NextClearCacheTick;

	private static int MaxCacheTicks;

	private static readonly List<MapRegion> Regions;

	static WorldMapManager()
	{
		MaxCacheTicks = 3600;
		Regions = new List<MapRegion>();
		ReloadData();
	}

	public static void ReloadData()
	{
		Regions.Clear();
		foreach (KeyValuePair<string, WorldMapRegionData> item in DataLoader.WorldMap(Game1.content))
		{
			Regions.Add(new MapRegion(item.Key, item.Value));
		}
		NextClearCacheTick = Game1.ticks + MaxCacheTicks;
	}

	public static IEnumerable<MapRegion> GetMapRegions()
	{
		ReloadDataIfStale();
		return Regions;
	}

	public static MapAreaPositionWithContext? GetPositionData(GameLocation location, Point tile)
	{
		return GetPositionData(location, tile, null);
	}

	internal static MapAreaPositionWithContext? GetPositionData(GameLocation location, Point tile, LogBuilder log)
	{
		if (location == null)
		{
			log?.AppendLine("Skipped: location is null.");
			return null;
		}
		LogBuilder log2 = log?.GetIndentedLog();
		log?.AppendLine("Searching for the player position...");
		MapAreaPosition positionDataWithoutFallback = GetPositionDataWithoutFallback(location, tile, log2);
		if (positionDataWithoutFallback != null)
		{
			log?.AppendLine("Found match: position '" + positionDataWithoutFallback.Data.Id + "'.");
			return new MapAreaPositionWithContext(positionDataWithoutFallback, location, tile);
		}
		Building parentBuilding = location.ParentBuilding;
		GameLocation gameLocation = parentBuilding?.GetParentLocation();
		if (gameLocation != null)
		{
			log?.AppendLine("");
			log?.AppendLine($"Searching for the exterior position of the '{parentBuilding.buildingType.Value}' building in {gameLocation.NameOrUniqueName}...");
			Point tile2 = new Point(parentBuilding.tileX.Value + parentBuilding.tilesWide.Value / 2, parentBuilding.tileY.Value + parentBuilding.tilesHigh.Value / 2);
			positionDataWithoutFallback = GetPositionDataWithoutFallback(gameLocation, tile2, log2);
			if (positionDataWithoutFallback != null)
			{
				log?.AppendLine("Found match: position '" + positionDataWithoutFallback.Data.Id + "'.");
				return new MapAreaPositionWithContext(positionDataWithoutFallback, gameLocation, tile2);
			}
		}
		log?.AppendLine("");
		log?.AppendLine("No match found.");
		return null;
	}

	public static MapAreaPosition GetPositionDataWithoutFallback(GameLocation location, Point tile)
	{
		return GetPositionDataWithoutFallback(location, tile, null);
	}

	internal static MapAreaPosition GetPositionDataWithoutFallback(GameLocation location, Point tile, LogBuilder log)
	{
		if (location == null)
		{
			log?.AppendLine("Skipped: location is null.");
			return null;
		}
		LogBuilder log2 = log?.GetIndentedLog();
		foreach (MapRegion mapRegion in GetMapRegions())
		{
			log?.AppendLine("Checking region '" + mapRegion.Id + "'...");
			MapAreaPosition positionData = mapRegion.GetPositionData(location, tile, log2);
			if (positionData != null)
			{
				return positionData;
			}
		}
		return null;
	}

	private static void ReloadDataIfStale()
	{
		if (Game1.ticks >= NextClearCacheTick)
		{
			ReloadData();
		}
	}
}
