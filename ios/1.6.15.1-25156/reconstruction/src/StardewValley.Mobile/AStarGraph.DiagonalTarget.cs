using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath GetShortestPathToNeighbouringDiagonalAStarWithBubbleCheck(AStarNode startNode, AStarNode endNode)
	{
		AStarPath path = GetShortestPathAStarWithBubbleCheck(startNode, endNode);
		if (path != null)
			return path;
		if (!endNode.fakeTileClear)
			return null;

		AStarNode northWest = FetchAStarNode(endNode.x - 1, endNode.y - 1);
		AStarNode northEast = FetchAStarNode(endNode.x + 1, endNode.y - 1);
		AStarNode southWest = FetchAStarNode(endNode.x - 1, endNode.y + 1);
		AStarNode southEast = FetchAStarNode(endNode.x + 1, endNode.y + 1);

		double northWestDistance = northWest == null
			? double.MaxValue
			: Math.Sqrt((double)(startNode.x - northWest.x) * (startNode.x - northWest.x)
				+ (double)(startNode.y - northWest.y) * (startNode.y - northWest.y));
		double northEastDistance = northEast == null
			? double.MaxValue
			: Math.Sqrt((double)(startNode.x - northEast.x) * (startNode.x - northEast.x)
				+ (double)(startNode.y - northEast.y) * (startNode.y - northEast.y));
		double southWestDistance = southWest == null
			? double.MaxValue
			: Math.Sqrt((double)(startNode.x - southWest.x) * (startNode.x - southWest.x)
				+ (double)(startNode.y - southWest.y) * (startNode.y - southWest.y));
		double southEastDistance = southEast == null
			? double.MaxValue
			: Math.Sqrt((double)(startNode.x - southEast.x) * (startNode.x - southEast.x)
				+ (double)(startNode.y - southEast.y) * (startNode.y - southEast.y));

		AStarNode candidate;
		if (northWest != null && northWest.TileClear
			&& northWestDistance < northEastDistance
			&& northWestDistance < southWestDistance
			&& northWestDistance < southEastDistance)
		{
			candidate = northWest;
		}
		else if (northEast != null && northEast.TileClear
			&& northEastDistance < northWestDistance
			&& northEastDistance < southWestDistance
			&& northEastDistance < southEastDistance)
		{
			candidate = northEast;
		}
		else if (southWest != null && southWest.TileClear
			&& southWestDistance < northWestDistance
			&& southWestDistance < northEastDistance
			&& southWestDistance < southEastDistance)
		{
			candidate = southWest;
		}
		else if (southEast != null && southEast.TileClear)
		{
			candidate = southEast;
		}
		else
		{
			return null;
		}

		return GetShortestPathAStarWithBubbleCheck(startNode, candidate);
	}
}
