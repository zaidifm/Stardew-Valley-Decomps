using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using xTile;

namespace StardewValley.Mobile;

public class AStarGraph
{
	public GameLocation gameLocation;

	public Map map;

	private AStarNode[,] _aStarNodeArray;

	protected List<AStarNode> _nodes;

	public AStarNode FarmerAStarNode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public AStarNode FarmerAStarNodeOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual List<AStarNode> Nodes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(GameLocation gameLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarNode FetchAStarNode(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarNode FetchNeighbourNodeThatIsPassible(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNode(AStarNode node)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath GetShortestPathDijkstra(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath GetShortestPathAStar(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath RetracePath(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath SmoothRightAngles(AStarPath path, int endNodesToLeave = 1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float Distance(int x1, int y1, int x2, int y2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNeighbouringNode(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNeighbouringNodeNoDiagonals(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNeighbouringNodeOnDiagonal(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSameNode(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection OppositeWalkDirection(WalkDirection walkDirection)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AreOppositeWalkDirection(WalkDirection walkDirectionA, WalkDirection walkDirectionB)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionToNextNode(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenNodes(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoPoints(Vector2 start, Vector2 end, float threshold = 0f)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoPointsNoDiagonals(Vector2 start, Vector2 end)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoNodes(AStarNode start, AStarNode end)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoTiles(Vector2 start, Vector2 end)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoPointsWithLastDirection(Vector2 start, Vector2 end, WalkDirection lastDirection, float threshold = 0f)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WalkDirection DiagonalWalkDirection(AStarPath path, int i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshBubbles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetBubbles(bool one = true, bool two = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void mergeBubbleID2IntoBubbleID()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath GetShortestPathToNeighbouringDiagonalAStarWithBubbleCheck(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double distance(int x1, int x2, int y1, int y2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath GetShortestPathAStarWithBubbleCheck(AStarNode startNode, AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PathBetweenNodesExists(AStarNode start, AStarNode end)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int walkingDirectionToStardewDirection(WalkDirection d)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarGraph()
	{
	}
}
