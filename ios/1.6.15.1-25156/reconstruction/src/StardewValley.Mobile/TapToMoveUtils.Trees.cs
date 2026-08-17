using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.TerrainFeatures;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TreeGrowthStage(AStarNode endNode)
	{
		return TreeGrowthStage(endNode.x, endNode.y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TreeGrowthStage(Vector2 tileClicked)
	{
		return TreeGrowthStage((int)tileClicked.X, (int)tileClicked.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TreeGrowthStage(int x, int y)
	{
		if (!gameLocation.terrainFeatures.TryGetValue(new Vector2(x, y), out TerrainFeature terrainFeature))
			return 0;
		if (terrainFeature is Tree tree)
			return tree.growthStage.Value;
		if (terrainFeature is FruitTree fruitTree)
			return fruitTree.growthStage.Value;
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTreeAt(AStarNode aStarNode)
	{
		if (aStarNode == null)
			return false;
		return IsTreeAt(aStarNode.x, aStarNode.y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTreeAt(Vector2 tile)
	{
		return IsTreeAt((int)tile.X, (int)tile.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTreeAt(int x, int y)
	{
		return gameLocation.terrainFeatures.TryGetValue(new Vector2(x, y), out TerrainFeature terrainFeature)
			&& (terrainFeature is Tree || terrainFeature is FruitTree);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TerrainFeature GetTreeAt(int x, int y)
	{
		if (!gameLocation.terrainFeatures.TryGetValue(new Vector2(x, y), out TerrainFeature terrainFeature))
			return null;
		if (terrainFeature is Tree || terrainFeature is FruitTree)
			return terrainFeature;
		return null;
	}
}
