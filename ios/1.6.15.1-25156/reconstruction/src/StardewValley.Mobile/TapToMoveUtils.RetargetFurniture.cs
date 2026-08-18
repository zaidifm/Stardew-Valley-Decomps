using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.BellsAndWhistles;
using StardewValley.Locations;
using StardewValley.Objects;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point retargetToParrotExpressSpot(AStarGraph graph, Point tileClicked)
	{
		if (Game1.currentLocation is not IslandLocation islandLocation)
			return tileClicked;

		foreach (ParrotPlatform platform in islandLocation.parrotPlatforms)
		{
			if (platform.OccupiesTile(new Vector2(tileClicked.X, tileClicked.Y)))
			{
				return new Point(
					(int)(platform.position.X / 64f + 1f),
					(int)(platform.position.Y / 64f));
			}
		}

		return Point.Zero;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point retargetToBedSpot(AStarGraph graph, Point tileClicked)
	{
		if (Game1.currentLocation is DecoratableLocation)
		{
			BedFurniture bed = BedFurniture.GetBedAtTile(graph.gameLocation, tileClicked.X, tileClicked.Y);
			if (bed != null)
			{
				Point bedSpot = bed.GetBedSpot();
				AStarNode node = graph.FetchAStarNode(tileClicked.X, tileClicked.Y);
				if (node != null && node.isBlockingBedTile())
				{
					if (bed.bedType == BedFurniture.BedType.Single)
					{
						Point standingPixel = Game1.player.StandingPixel;
						Vector2 playerTile = new Vector2(standingPixel.X / 64, standingPixel.Y / 64);
						float bedDistance = Vector2.Distance(new Vector2(bedSpot.X, bedSpot.Y), playerTile);
						float leftDistance = Vector2.Distance(new Vector2(bedSpot.X - 1, bedSpot.Y), playerTile);
						if (bedDistance < leftDistance)
							bedSpot.X--;
					}

					return bedSpot;
				}
			}
		}

		return tileClicked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NodeContainsFurniture(AStarNode aStarNode)
	{
		if (aStarNode == null)
			return false;

		Rectangle nodeBounds = new Rectangle(aStarNode.x << 6, aStarNode.y << 6, 64, 64);
		foreach (Furniture furniture in gameLocation.furniture)
		{
			if (furniture.GetBoundingBox().Intersects(nodeBounds))
				return true;
		}

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Furniture GetFurnitureClickedOn(int clickPointX, int clickPointY)
	{
		foreach (Furniture furniture in gameLocation.furniture)
		{
			if (furniture.furniture_type.Value != Furniture.rug
				&& furniture.GetBoundingBox().Contains(clickPointX, clickPointY))
			{
				return furniture;
			}
		}

		foreach (Furniture furniture in gameLocation.furniture)
		{
			if (furniture.furniture_type.Value == Furniture.rug
				&& furniture.GetBoundingBox().Contains(clickPointX, clickPointY))
			{
				return furniture;
			}
		}

		return null;
	}
}
