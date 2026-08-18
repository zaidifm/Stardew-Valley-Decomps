using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AStarPath getPathOnIslandNorthBridge(AStarGraph graph, Vector2 start, Vector2 end)
	{
		AStarPath path = new AStarPath();
		if (start.Y == 41f)
		{
			path.nodes.Add(graph.FetchAStarNode(37, 40));
			path.nodes.Add(graph.FetchAStarNode(37, 39));
		}
		else if (start.Y == 40f)
		{
			path.nodes.Add(graph.FetchAStarNode(37, 39));
		}

		int horizontalDistance = (int)(end.X - start.X);
		if (horizontalDistance > 0)
		{
			for (int i = 1; i <= horizontalDistance; i++)
				path.nodes.Add(graph.FetchAStarNode((int)start.X + i, 39));
		}
		else if (horizontalDistance < 0)
		{
			int x = (int)start.X;
			for (int i = 1; i <= Math.Abs(horizontalDistance); i++)
			{
				x--;
				path.nodes.Add(graph.FetchAStarNode(x, 39));
			}
		}

		return path;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AStarNode FetchAStarNodeNearestWaterSource(AStarGraph aStarGraph, AStarNode node)
	{
		List<AStarNode> candidates = new List<AStarNode>();
		int positiveOffset = 1;
		int negativeOffset = -1;
		bool continueSearch;
		do
		{
			AStarNode candidate = aStarGraph.FetchAStarNode(node.x + positiveOffset, node.y);
			if (candidate != null && candidate.TileClear && !IsWateringCanFillingSource(new Vector2(candidate.x, candidate.y)))
				candidates.Add(candidate);

			candidate = aStarGraph.FetchAStarNode(node.x + negativeOffset, node.y);
			if (candidate != null && candidate.TileClear && !IsWateringCanFillingSource(new Vector2(candidate.x, candidate.y)))
				candidates.Add(candidate);

			candidate = aStarGraph.FetchAStarNode(node.x, node.y + positiveOffset);
			if (candidate != null && candidate.TileClear && !IsWateringCanFillingSource(new Vector2(candidate.x, candidate.y)))
				candidates.Add(candidate);

			candidate = aStarGraph.FetchAStarNode(node.x, node.y + negativeOffset);
			if (candidate != null && candidate.TileClear && !IsWateringCanFillingSource(new Vector2(candidate.x, candidate.y)))
				candidates.Add(candidate);

			continueSearch = positiveOffset < 29;
			negativeOffset--;
			positiveOffset++;
		}
		while (candidates.Count < 1 && continueSearch);

		if (candidates.Count == 0)
			return null;

		int bestIndex = 0;
		if (candidates.Count >= 2)
		{
			float bestDistance = float.MaxValue;
			for (int i = 1; i < candidates.Count; i++)
			{
				float distance = Vector2.Distance(PlayerOffsetPosition, candidates[i].NodeCenterOnMap);
				if (distance < bestDistance)
				{
					bestIndex = i;
					bestDistance = distance;
				}
			}
		}

		AStarNode selected = candidates[bestIndex];
		if (selected.x == node.x)
		{
			int y = selected.y - 1;
			if (selected.y <= node.y)
				y = selected.y + 1;
			return aStarGraph.FetchAStarNode(selected.x, y);
		}

		int x = selected.x - 1;
		if (selected.x <= node.x)
			x = selected.x + 1;
		return aStarGraph.FetchAStarNode(x, node.y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AStarNode FetchNearestAStarLandNodePerpendicularToWaterSource(AStarGraph aStarGraph, AStarNode farmerNode, AStarNode nodeClicked)
	{
		bool scanVertical;
		if (nodeClicked.x == farmerNode.x)
		{
			scanVertical = true;
		}
		else if (farmerNode.y != nodeClicked.y)
		{
			int dx = Math.Abs(nodeClicked.x - farmerNode.x);
			int dy = Math.Abs(nodeClicked.y - farmerNode.y);
			scanVertical = dy < dx;
		}
		else
		{
			scanVertical = false;
		}

		if (scanVertical)
		{
			int y = nodeClicked.y;
			AStarNode previous = nodeClicked;
			if (farmerNode.y < y)
			{
				do
				{
					AStarNode current = aStarGraph.FetchAStarNode(nodeClicked.x, y);
					if (current != null && current.TileClear && !IsWateringCanFillingSource(new Vector2(current.x, current.y)))
						return previous;
					y--;
					previous = current;
				}
				while (farmerNode.y <= y);
			}
			else
			{
				do
				{
					AStarNode current = aStarGraph.FetchAStarNode(nodeClicked.x, y);
					if (current != null && current.TileClear && !IsWateringCanFillingSource(new Vector2(current.x, current.y)))
						return previous;
					y++;
					previous = current;
				}
				while (y <= farmerNode.y);
			}
		}
		else
		{
			int x = nodeClicked.x;
			AStarNode previous = nodeClicked;
			if (farmerNode.x < x)
			{
				do
				{
					AStarNode current = aStarGraph.FetchAStarNode(x, nodeClicked.y);
					if (current != null && current.TileClear && !IsWateringCanFillingSource(new Vector2(current.x, current.y)))
						return previous;
					x--;
					previous = current;
				}
				while (farmerNode.x <= x);
			}
			else
			{
				do
				{
					AStarNode current = aStarGraph.FetchAStarNode(x, nodeClicked.y);
					if (current != null && current.TileClear && !IsWateringCanFillingSource(new Vector2(current.x, current.y)))
						return previous;
					x++;
					previous = current;
				}
				while (x <= farmerNode.x);
			}
		}

		AStarNode result = FetchAStarNodeNearestWaterSource(aStarGraph, nodeClicked);
		if (result == null)
			result = FetchAStarNodeNearestWaterSource(aStarGraph, farmerNode);
		return result;
	}
}
