using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Locations;
using StardewValley.TerrainFeatures;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsMatureTreeStumpOrBoulderAt(Vector2 tile)
	{
		int x = (int)tile.X;
		int y = (int)tile.Y;
		return IsTreeAt(x, y)
			|| TreeGrowthStage(x, y) >= 1
			|| IsChoppableBushAtPoint(x, y)
			|| IsStumpAt(x, y)
			|| IsBoulderAt(x, y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTreeStumpOrBoulderAt(Vector2 tile)
	{
		int x = (int)tile.X;
		int y = (int)tile.Y;
		return IsTreeAt(x, y)
			|| IsStumpAt(x, y)
			|| IsBoulderAt(x, y)
			|| IsChoppableBushAtPoint(x, y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsStumpAt(AStarNode endNode)
	{
		return IsStumpAt(endNode.x, endNode.y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsStumpAt(Vector2 tile)
	{
		return IsStumpAt((int)tile.X, (int)tile.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsStumpAt(int x, int y)
	{
		foreach (ResourceClump clump in gameLocation.resourceClumps)
		{
			if (clump.occupiesTile(x, y)
				&& (clump.parentSheetIndex.Value == ResourceClump.stumpIndex
					|| clump.parentSheetIndex.Value == ResourceClump.hollowLogIndex))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGiantWeedAt(AStarNode endNode)
	{
		return IsGiantWeedAt(endNode.x, endNode.y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGiantWeedAt(Vector2 tile)
	{
		return IsGiantWeedAt((int)tile.X, (int)tile.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGiantWeedAt(int x, int y)
	{
		foreach (ResourceClump clump in gameLocation.resourceClumps)
		{
			if (clump.occupiesTile(x, y)
				&& (clump.parentSheetIndex.Value == ResourceClump.greenRainBush1Index
					|| clump.parentSheetIndex.Value == ResourceClump.greenRainBush2Index))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBoulderAt(AStarNode endNode)
	{
		return IsBoulderAt(endNode.x, endNode.y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBoulderAt(Vector2 tile)
	{
		return IsBoulderAt((int)tile.X, (int)tile.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBoulderAt(int x, int y)
	{
		if (gameLocation is Farm || gameLocation is MineShaft)
		{
			foreach (ResourceClump clump in gameLocation.resourceClumps)
			{
				if (isResourceClumpBoulderAt(clump, x, y))
					return true;
			}
		}

		if (gameLocation.objects.TryGetValue(new Vector2(x, y), out Object obj))
			return obj.ItemId == "Stone" || obj.ItemId == "Boulder";
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool isResourceClumpBoulderAt(ResourceClump resourceClump, int x, int y)
	{
		if (!resourceClump.occupiesTile(x, y))
			return false;

		int index = resourceClump.parentSheetIndex.Value;
		return index == ResourceClump.mineRock1Index
			|| index == ResourceClump.mineRock2Index
			|| index == ResourceClump.mineRock3Index
			|| index == ResourceClump.mineRock4Index
			|| index == ResourceClump.boulderIndex
			|| index == ResourceClump.meteoriteIndex;
	}
}
