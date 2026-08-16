using System.Collections.Generic;
using System.Runtime.CompilerServices;
using xTile;

namespace StardewValley.Mobile;

// Staged semantic reconstruction from iOS ARM64/AOT evidence.
// Only independently verified graph primitives are emitted here so far.
public partial class AStarGraph
{
	public GameLocation gameLocation;

	public Map map;

	private AStarNode[,] _aStarNodeArray;

	protected List<AStarNode> _nodes;

	public virtual List<AStarNode> Nodes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => _nodes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarNode FetchAStarNode(int x, int y)
	{
		if (x < 0 || x >= _aStarNodeArray.GetLength(0))
			return null;
		if (y < 0 || y >= _aStarNodeArray.GetLength(1))
			return null;

		return _aStarNodeArray[x, y];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNode(AStarNode node)
	{
		_nodes.Add(node);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarGraph()
	{
		_nodes = new List<AStarNode>();
	}
}
