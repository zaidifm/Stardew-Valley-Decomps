using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2 FetchAccessibleTileNextToBuilding(List<Vector2> tilesAroundBuilding, int offset, AStarGraph aStarGraph, AStarNode startNode)
	{
		Vector2 tile = tilesAroundBuilding[offset];
		int tileX = (int)tile.X;
		int tileY = (int)tile.Y;
		AStarNode node = aStarGraph.FetchAStarNode(tileX, tileY);
		if (node != null)
		{
			node.FakeTileClear = true;
			AStarPath path = aStarGraph.GetShortestPathAStarWithBubbleCheck(startNode, node);
			if (path?.nodes != null && path.nodes.Count > 0)
				return new Vector2(tileX, tileY);

			node.FakeTileClear = false;
		}

		return Vector2.Zero;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HoeSelectedAndTileHoeable(Vector2 tile)
	{
		if (Game1.player.CurrentTool is not Hoe)
			return false;

		GameLocation location = gameLocation;
		int x = (int)tile.X;
		int y = (int)tile.Y;
		if (location.doesTileHaveProperty(x, y, "Diggable", "Back", false) == null)
			return false;
		if (location.IsTileOccupiedBy(tile))
			return false;

		return location.isTilePassable(new Vector2(x, y));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TappedEggAtEggFestival(Vector2 clickPoint)
	{
		if (Game1.CurrentEvent == null || Game1.CurrentEvent.FestivalName != "Egg Festival")
			return false;

		foreach (Prop prop in Game1.CurrentEvent.festivalProps)
		{
			if (prop.ContainsPoint(clickPoint))
				return true;
		}

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FarmAnimal FetchFarmAnimal(GameLocation gameLocation, int x, int y)
	{
		FarmAnimal result = null;
		foreach (FarmAnimal animal in gameLocation.animals.Values)
		{
			if (!animal.wasPet.Value || result == null)
			{
				if (animal.GetCursorPetBoundingBox().Contains(x, y))
				{
					result = animal;
					if (!animal.wasPet.Value)
						return result;
				}
			}
		}

		return result;
	}
}
