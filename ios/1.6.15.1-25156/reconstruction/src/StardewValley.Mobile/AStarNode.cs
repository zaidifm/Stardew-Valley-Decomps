using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

// Staged semantic reconstruction from iOS ARM64/AOT evidence.
// Additional AStarNode behavior is intentionally added only as each method slice is verified.
public partial class AStarNode
{
	public int bubbleID;

	public int bubbleID2;

	private AStarGraph _aStarGraph;

	private bool _fakeTileClear;

	public float fCost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set;
	}

	public float gCost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set;
	}

	public float hCost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set;
	}

	public AStarNode parentNode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set;
	}

	public int x
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set;
	}

	public int y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set;
	}

	public Rectangle rectangle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => new Rectangle(x << 6, y << 6, 64, 64);
	}

	public List<AStarNode> NeighbouringNodeList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => GetNeighbouringNodeList(true);
	}

	public List<AStarNode> OccupiedNeighbouringNodeList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => GetNeighbouringNodeList(false);
	}

	public Vector2 NodeCenterOnMap
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => new Vector2((x << 6) + 32f, (y << 6) + 32f);
	}

	public bool FakeTileClear
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => _fakeTileClear;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set => _fakeTileClear = value;
	}

	public bool fakeTileClear
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => _fakeTileClear;
	}

	public Rectangle rect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => new Rectangle(x << 6, y << 6, 64, 64);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarNode(AStarGraph aStarGraph, int x, int y)
	{
		bubbleID = -1;
		bubbleID2 = -1;
		_aStarGraph = aStarGraph;
		this.x = x;
		this.y = y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle GetBoundingBox()
	{
		return new Rectangle(x << 6, y << 6, 64, 64);
	}
}
