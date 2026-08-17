using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.TerrainFeatures;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBushAt(AStarNode endNode)
	{
		if (IsBushAt(endNode.x, endNode.y))
			return true;

		Vector2 tile = new Vector2(endNode.x, endNode.y);
		return gameLocation.terrainFeatures.ContainsKey(tile)
			&& gameLocation.terrainFeatures[tile] is Bush;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBushAt(Vector2 tile)
	{
		if (IsBushAt((int)tile.X, (int)tile.Y))
			return true;

		Vector2 key = new Vector2((int)tile.X, (int)tile.Y);
		return gameLocation.terrainFeatures.ContainsKey(key)
			&& gameLocation.terrainFeatures[key] is Bush;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBushAt(int x, int y)
	{
		if (x == 32 && y == 9 && Game1.whichFarm == 2 && Game1.currentLocation is Farm)
			return false;
		return IsBushAtPoint(x << 6, y << 6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBushAtPoint(int x, int y)
	{
		foreach (LargeTerrainFeature feature in gameLocation.largeTerrainFeatures)
		{
			if (feature is Bush bush && bush.getBoundingBox().Contains(x, y))
				return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsChoppableBushAtPoint(int x, int y)
	{
		foreach (LargeTerrainFeature feature in gameLocation.largeTerrainFeatures)
		{
			if (feature is Bush bush && bush.getBoundingBox().Contains(x, y))
				return bush.isDestroyable();
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bush FetchBushAt(AStarNode aStarNode)
	{
		Vector2 tile = new Vector2(aStarNode.x, aStarNode.y);
		if (gameLocation.terrainFeatures.ContainsKey(tile)
			&& gameLocation.terrainFeatures[tile] is Bush bush)
		{
			return bush;
		}
		return FetchBushAtPoint(aStarNode.x << 6, aStarNode.y << 6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bush FetchBushAtPoint(int x, int y)
	{
		foreach (LargeTerrainFeature feature in gameLocation.largeTerrainFeatures)
		{
			if (feature is Bush bush && bush.getBoundingBox().Contains(x, y))
				return bush;
		}
		return null;
	}
}
