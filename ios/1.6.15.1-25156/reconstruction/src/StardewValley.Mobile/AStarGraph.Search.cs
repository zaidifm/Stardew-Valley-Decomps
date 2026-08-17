using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath GetShortestPathDijkstra(AStarNode startNode, AStarNode endNode)
	{
		AStarPath path = new AStarPath();
		if (startNode == null || endNode == null)
			throw new ArgumentNullException();

		if (startNode == endNode)
		{
			path.nodes.Add(startNode);
			return path;
		}

		List<AStarNode> unvisited = new List<AStarNode>();
		Dictionary<AStarNode, AStarNode> previous = new Dictionary<AStarNode, AStarNode>();
		Dictionary<AStarNode, float> distances = new Dictionary<AStarNode, float>();

		foreach (AStarNode node in _nodes)
		{
			unvisited.Add(node);
			distances[node] = float.MaxValue;
		}
		distances[startNode] = 0f;

		while (unvisited.Count > 0)
		{
			unvisited = unvisited.OrderBy(node => distances[node]).ToList();
			AStarNode current = unvisited[0];
			unvisited.Remove(current);

			if (current == endNode)
			{
				while (previous.ContainsKey(endNode))
				{
					path.nodes.Insert(0, endNode);
					endNode = previous[endNode];
				}
				path.nodes.Insert(0, endNode);
				break;
			}

			foreach (AStarNode neighbour in current.GetNeighbouringNodeList(true))
			{
				float dx = current.x - neighbour.x;
				float dy = current.y - neighbour.y;
				float alternateDistance = distances[current] + dx * dx + dy * dy;
				if (alternateDistance < distances[neighbour])
				{
					distances[neighbour] = alternateDistance;
					previous[neighbour] = current;
				}
			}
		}

		path.Bake();
		return path;
	}

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
