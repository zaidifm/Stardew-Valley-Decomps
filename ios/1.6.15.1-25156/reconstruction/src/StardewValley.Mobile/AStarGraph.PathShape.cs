using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath RetracePath(AStarNode startNode, AStarNode endNode)
	{
		AStarPath path = new AStarPath();
		while (endNode != startNode)
		{
			path.nodes.Add(endNode);
			endNode = endNode.parentNode;
		}
		path.nodes.Reverse();
		return path;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath SmoothRightAngles(AStarPath path, int endNodesToLeave = 1)
	{
		List<int> removeIndexes = new List<int>();
		for (int i = 0; i < path.nodes.Count - endNodesToLeave - 1; i++)
		{
			if (DiagonalWalkDirection(path, i) != WalkDirection.None)
				removeIndexes.Add(i + 1);
		}

		if (removeIndexes.Count > 0)
		{
			List<AStarNode> nodes = new List<AStarNode>(path.nodes);
			for (int i = removeIndexes.Count - 1; i >= 0; i--)
				nodes.RemoveAt(removeIndexes[i]);
			path.nodes = nodes;
		}
		return path;
	}
}
