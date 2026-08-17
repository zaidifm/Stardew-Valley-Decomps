using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Locations;
using StardewValley.TerrainFeatures;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NodeContainsMusicBlock(AStarNode aStarNode)
	{
		if (gameLocation is not DecoratableLocation location)
			return false;

		if (!location.objects.TryGetValue(new Vector2(aStarNode.x, aStarNode.y), out Object obj)
			|| obj == null)
		{
			return false;
		}

		return (uint)(obj.ParentSheetIndex - 463) < 2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NodeContainsHousePlant(AStarNode aStarNode)
	{
		if (!Game1.currentLocation.objects.TryGetValue(new Vector2(aStarNode.x, aStarNode.y), out Object obj)
			|| obj == null)
		{
			return false;
		}

		return obj.ItemId == "House Plant";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Object GetHousePlant(AStarNode aStarNode)
	{
		if (!Game1.currentLocation.objects.TryGetValue(new Vector2(aStarNode.x, aStarNode.y), out Object obj)
			|| obj == null)
		{
			return null;
		}

		return obj.ItemId == "House Plant" ? obj : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTerrainFeatureAt(AStarNode endNode)
	{
		gameLocation.terrainFeatures.TryGetValue(new Vector2(endNode.x, endNode.y), out TerrainFeature terrainFeature);
		if (terrainFeature == null)
			return false;

		Log.It("TapToMoveUtils.IsTerrainFeatureAt(" + endNode.x + ", " + endNode.y + ") terrainFeature:" + terrainFeature.ToString());
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Fence FetchGate(GameLocation gameLocation, AStarNode aStarNode)
	{
		Vector2 tile = new Vector2(aStarNode.x, aStarNode.y);
		if (!gameLocation.objects.ContainsKey(tile))
			return null;

		if (gameLocation.objects[tile] is Fence fence && fence.isGate.Value)
			return fence;
		return null;
	}
}
