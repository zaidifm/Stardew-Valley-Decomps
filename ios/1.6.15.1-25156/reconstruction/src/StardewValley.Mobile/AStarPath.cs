using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

// Staged semantic reconstruction from iOS ARM64/AOT evidence.
// The original metadata does not mark this class partial; partial is used here only
// so independently verified method slices can be committed without inventing the
// still-unresolved ToString implementation. Consolidate when the class is complete.
public partial class AStarPath
{
	protected List<AStarNode> _nodeList;

	protected float _length;

	public virtual List<AStarNode> nodes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => _nodeList;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set => _nodeList = value;
	}

	public virtual float length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => _length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Bake()
	{
		List<AStarNode> visitedNodes = new List<AStarNode>();
		_length = 0f;

		for (int i = 0; i < _nodeList.Count; i++)
		{
			AStarNode node = _nodeList[i];
			for (int j = 0; j < node.GetNeighbouringNodeList(true).Count; j++)
			{
				AStarNode neighbour = node.GetNeighbouringNodeList(true)[j];
				if (_nodeList.Contains(neighbour) && !visitedNodes.Contains(neighbour))
				{
					_length += Distance(node.x, node.y, neighbour.x, neighbour.y);
				}
			}

			visitedNodes.Add(node);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float Distance(int x1, int y1, int x2, int y2)
	{
		double dx = x1 - x2;
		double dy = y1 - y2;
		return (float)(dx * dx + dy * dy);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarNode containsClosedGate()
	{
		for (int i = 0; i < nodes.Count; i++)
		{
			if (nodes[i].isGate() && !nodes[i].isGateOpen())
				return nodes[i];
		}

		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarNode ContainsGate()
	{
		for (int i = 0; i < nodes.Count; i++)
		{
			if (nodes[i].isGate())
				return nodes[i];
		}

		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath()
	{
		_nodeList = new List<AStarNode>();
	}
}
