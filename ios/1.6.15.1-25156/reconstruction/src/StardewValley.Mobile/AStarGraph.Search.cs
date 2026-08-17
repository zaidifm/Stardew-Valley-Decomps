using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath GetShortestPathAStar(AStarNode startNode, AStarNode endNode)
	{
		if (startNode == null || endNode == null)
			return null;

		List<AStarNode> openSet = new List<AStarNode>();
		HashSet<AStarNode> closedSet = new HashSet<AStarNode>();
		openSet.Add(startNode);

		bool avoidBlockingBedTiles = gameLocation is DecoratableLocation && !endNode.isBlockingBedTile();

		while (openSet.Count > 0)
		{
			AStarNode currentNode = openSet[0];
			for (int i = 1; i < openSet.Count; i++)
			{
				if (openSet[i].fCost < currentNode.fCost
					|| (openSet[i].fCost == currentNode.fCost && openSet[i].hCost < currentNode.hCost))
				{
					currentNode = openSet[i];
				}
			}

			openSet.Remove(currentNode);
			closedSet.Add(currentNode);

			if (currentNode == endNode)
				return RetracePath(startNode, endNode);

			foreach (AStarNode neighbour in currentNode.GetNeighbouringNodeList(true))
			{
				if (closedSet.Contains(neighbour))
					continue;
				if (avoidBlockingBedTiles && neighbour.isBlockingBedTile())
					continue;

				float newCost = currentNode.gCost + 1f;
				if (newCost < neighbour.gCost || !openSet.Contains(neighbour))
				{
					neighbour.gCost = newCost;
					neighbour.hCost = Distance(neighbour.x, neighbour.y, endNode.x, endNode.y);
					neighbour.parentNode = currentNode;
					if (!openSet.Contains(neighbour))
						openSet.Add(neighbour);
				}
			}
		}

		return null;
	}
}
