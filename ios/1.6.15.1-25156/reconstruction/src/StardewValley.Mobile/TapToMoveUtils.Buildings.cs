using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Buildings;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<Vector2> ListOfTilesSurroundingBuilding(Building building)
	{
		List<Vector2> tiles = new List<Vector2>();
		for (int i = 0; i < building.tilesWide.Value; i++)
			tiles.Add(new Vector2(building.tileX.Value + i, building.tileY.Value));

		for (int i = 1; i < building.tilesHigh.Value; i++)
			tiles.Add(new Vector2(building.tileX.Value + building.tilesWide.Value - 1, building.tileY.Value + i));

		int xOffset = -2;
		for (int i = 1; i < building.tilesWide.Value; i++)
		{
			tiles.Add(new Vector2(
				building.tileX.Value + building.tilesWide.Value + xOffset,
				building.tileY.Value + building.tilesHigh.Value - 1));
			xOffset--;
		}

		int yOffset = -2;
		for (int i = 1; i < building.tilesHigh.Value - 1; i++)
		{
			tiles.Add(new Vector2(
				building.tileX.Value,
				building.tileY.Value + building.tilesHigh.Value + yOffset));
			yOffset--;
		}

		return tiles;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 GetTileNextToBuildingNearestFarmer(AStarGraph aStarGraph, Building building, Farmer who)
	{
		int farmerX = who.StandingPixel.X / 64;
		int farmerY = who.StandingPixel.Y / 64;
		int left = building.tileX.Value;
		int top = building.tileY.Value;
		int right = left + building.tilesWide.Value - 1;
		int bottom = top + building.tilesHigh.Value - 1;

		int leftDistance = 0;
		int rightDistance = 0;
		int topDistance = 0;
		int bottomDistance = 0;
		int nearestX = 0;
		int nearestY = 0;

		if (farmerX < left)
		{
			leftDistance = left - farmerX;
		}
		else if (right < farmerX)
		{
			rightDistance = farmerX - (left + building.tilesWide.Value) + 1;
		}
		else
		{
			nearestX = farmerX;
			nearestY = farmerY < top ? top : bottom;
		}

		if (farmerY < top)
		{
			topDistance = top - farmerY;
			if (nearestX != 0 || nearestY != 0)
				goto HaveNearestTile;
		}
		else if (top + building.tilesHigh.Value < farmerY)
		{
			bottomDistance = farmerY - (top + building.tilesHigh.Value) + 1;
			if (nearestX != 0 || nearestY != 0)
				goto HaveNearestTile;
		}
		else
		{
			nearestY = farmerY;
			nearestX = farmerX < left ? left : right;
			if (nearestX != 0 || nearestY != 0)
				goto HaveNearestTile;
		}

		if (topDistance > 0 && leftDistance > 0)
		{
			nearestX = left;
			nearestY = top;
		}
		else if (topDistance > 0 && rightDistance > 0)
		{
			nearestX = right;
			nearestY = top;
		}
		else if (bottomDistance > 0 && leftDistance > 0)
		{
			nearestX = left;
			nearestY = bottom;
		}
		else if (bottomDistance > 0 && rightDistance > 0)
		{
			nearestX = right;
			nearestY = bottom;
		}

	HaveNearestTile:
		List<Vector2> tiles = ListOfTilesSurroundingBuilding(building);
		int offset = 0;
		for (int i = 0; i < tiles.Count; i++)
		{
			if (nearestX == (int)tiles[i].X && nearestY == (int)tiles[i].Y)
			{
				offset = i;
				break;
			}
		}

		AStarNode startNode = aStarGraph.FarmerAStarNodeOffset;
		Vector2 result = FetchAccessibleTileNextToBuilding(tiles, offset, aStarGraph, startNode);
		if (result != Vector2.Zero)
			return result;

		if (tiles.Count > 3)
		{
			int positiveOffset = 1;
			int negativeOffset = -1;
			do
			{
				if (offset + negativeOffset < 0)
				{
					result = FetchAccessibleTileNextToBuilding(tiles, offset + tiles.Count + negativeOffset, aStarGraph, startNode);
					if (result != Vector2.Zero)
						return result;
				}

				if (tiles.Count - 1 < offset + positiveOffset)
				{
					result = FetchAccessibleTileNextToBuilding(tiles, offset + positiveOffset - tiles.Count, aStarGraph, startNode);
					if (result != Vector2.Zero)
						return result;
				}

				positiveOffset++;
				negativeOffset--;
			}
			while (positiveOffset < tiles.Count / 2);
		}

		Point standingPixel = who.StandingPixel;
		return new Vector2(standingPixel.X / 64, standingPixel.Y / 64);
	}
}
