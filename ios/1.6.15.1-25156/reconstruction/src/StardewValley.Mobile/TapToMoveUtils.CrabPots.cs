using System.Runtime.CompilerServices;
using StardewValley.Objects;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AStarNode CrabPotNeighbour(AStarNode aStarNode)
	{
		foreach (AStarNode neighbour in aStarNode.GetNeighbouringNodeListFull(false))
		{
			Object obj = neighbour.FetchObject();
			if (obj != null && obj.ParentSheetIndex == 710)
				return neighbour;
		}

		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CrabPot ClickedCrabPot(AStarGraph aStarGraph, AStarNode aStarNode)
	{
		Object obj = aStarNode.FetchObject();
		if (obj != null && obj.ParentSheetIndex == 710)
			return obj as CrabPot;

		AStarNode node = aStarGraph.FetchAStarNode(aStarNode.x, aStarNode.y + 1);
		if (node != null)
		{
			obj = node.FetchObject();
			if (obj != null && obj.ParentSheetIndex == 710)
			{
				CrabPot pot = (CrabPot)obj;
				if (pot.readyForHarvest.Value)
					return pot;
			}
		}

		node = aStarGraph.FetchAStarNode(aStarNode.x, aStarNode.y + 2);
		if (node != null)
		{
			obj = node.FetchObject();
			if (obj != null && obj.ParentSheetIndex == 710)
			{
				CrabPot pot = (CrabPot)obj;
				if (pot.readyForHarvest.Value)
					return pot;
			}
		}

		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AStarNode FetchMostAccessibleNodeToCrabPot(AStarGraph aStarGraph, AStarNode aStarNode)
	{
		int x = aStarNode.x;
		int y = aStarNode.y;
		if (!Game1.currentLocation.IsWaterTile(x, y - 1))
			return aStarGraph.FetchAStarNode(x, y - 1);
		if (!Game1.currentLocation.IsWaterTile(x, y + 1))
			return aStarGraph.FetchAStarNode(x, y + 1);
		if (!Game1.currentLocation.IsWaterTile(x - 1, y))
			return aStarGraph.FetchAStarNode(x - 1, y);
		if (!Game1.currentLocation.IsWaterTile(x + 1, y))
			return aStarGraph.FetchAStarNode(x + 1, y);
		if (!Game1.currentLocation.IsWaterTile(x - 1, y - 1))
			return aStarGraph.FetchAStarNode(x - 1, y - 1);
		if (!Game1.currentLocation.IsWaterTile(x + 1, y - 1))
			return aStarGraph.FetchAStarNode(x + 1, y - 1);
		if (!Game1.currentLocation.IsWaterTile(x - 1, y + 1))
			return aStarGraph.FetchAStarNode(x - 1, y + 1);
		if (!Game1.currentLocation.IsWaterTile(x - 1, y + 1))
			return aStarGraph.FetchAStarNode(x - 1, y + 1);

		return aStarNode;
	}
}
