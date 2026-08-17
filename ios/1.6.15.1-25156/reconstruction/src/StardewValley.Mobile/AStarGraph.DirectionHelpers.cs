using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float Distance(int x1, int y1, int x2, int y2)
	{
		double dx = x1 - x2;
		double dy = y1 - y2;
		return (float)(dx * dx + dy * dy);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNeighbouringNode(AStarNode startNode, AStarNode endNode)
	{
		if (startNode == null || endNode == null)
			return false;

		return endNode.x >= startNode.x - 1
			&& endNode.x <= startNode.x + 1
			&& endNode.y >= startNode.y - 1
			&& endNode.y <= startNode.y + 1
			&& (endNode.x != startNode.x || endNode.y != startNode.y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNeighbouringNodeNoDiagonals(AStarNode startNode, AStarNode endNode)
	{
		if (startNode == null || endNode == null)
			return false;

		if (endNode.x == startNode.x)
			return endNode.y == startNode.y + 1 || endNode.y == startNode.y - 1;

		if (endNode.y == startNode.y)
			return endNode.x == startNode.x + 1 || endNode.x == startNode.x - 1;

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNeighbouringNodeOnDiagonal(AStarNode startNode, AStarNode endNode)
	{
		if (startNode == null || endNode == null)
			return false;

		return (endNode.x == startNode.x - 1 || endNode.x == startNode.x + 1)
			&& (endNode.y == startNode.y - 1 || endNode.y == startNode.y + 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSameNode(AStarNode startNode, AStarNode endNode)
	{
		return startNode != null && endNode != null
			&& endNode.x == startNode.x
			&& endNode.y == startNode.y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection OppositeWalkDirection(WalkDirection walkDirection)
	{
		return walkDirection switch
		{
			WalkDirection.Up => WalkDirection.Down,
			WalkDirection.Down => WalkDirection.Up,
			WalkDirection.Left => WalkDirection.Right,
			WalkDirection.Right => WalkDirection.Left,
			WalkDirection.UpLeft => WalkDirection.DownRight,
			WalkDirection.UpRight => WalkDirection.DownLeft,
			WalkDirection.DownLeft => WalkDirection.UpRight,
			WalkDirection.DownRight => WalkDirection.UpLeft,
			_ => WalkDirection.None,
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionToNextNode(AStarNode startNode, AStarNode endNode)
	{
		if (startNode == null || endNode == null)
			return WalkDirection.None;

		if (startNode.x == endNode.x + 1 && startNode.y == endNode.y + 1)
			return WalkDirection.UpLeft;
		if (startNode.x == endNode.x - 1 && startNode.y == endNode.y + 1)
			return WalkDirection.UpRight;
		if (startNode.x == endNode.x + 1 && startNode.y == endNode.y - 1)
			return WalkDirection.DownLeft;
		if (startNode.x == endNode.x - 1 && startNode.y == endNode.y - 1)
			return WalkDirection.DownRight;

		if (startNode.x == endNode.x)
		{
			if (startNode.y == endNode.y - 1)
				return WalkDirection.Down;
			if (startNode.y == endNode.y + 1)
				return WalkDirection.Up;
		}

		if (startNode.x == endNode.x + 1 && startNode.y == endNode.y)
			return WalkDirection.Left;
		if (startNode.x == endNode.x - 1 && startNode.y == endNode.y)
			return WalkDirection.Right;

		return WalkDirection.None;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenNodes(AStarNode startNode, AStarNode endNode)
	{
		if (endNode.x < startNode.x && endNode.y < startNode.y)
			return WalkDirection.UpLeft;
		if (endNode.x > startNode.x && endNode.y < startNode.y)
			return WalkDirection.UpRight;
		if (endNode.x < startNode.x && endNode.y > startNode.y)
			return WalkDirection.DownLeft;
		if (endNode.x > startNode.x && endNode.y > startNode.y)
			return WalkDirection.DownRight;

		if (endNode.x == startNode.x)
		{
			if (endNode.y > startNode.y)
				return WalkDirection.Down;
			if (endNode.y < startNode.y)
				return WalkDirection.Up;
		}

		if (endNode.y == startNode.y)
		{
			if (endNode.x < startNode.x)
				return WalkDirection.Left;
			if (endNode.x > startNode.x)
				return WalkDirection.Right;
		}

		return WalkDirection.None;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoPoints(Vector2 start, Vector2 end, float threshold = 0f)
	{
		float dx = Math.Abs(start.X - end.X);
		float dy = Math.Abs(start.Y - end.Y);

		if (end.X < start.X && end.Y < start.Y && threshold <= dx && threshold <= dy)
			return WalkDirection.UpLeft;
		if (end.X > start.X && end.Y < start.Y && threshold <= dx && threshold <= dy)
			return WalkDirection.UpRight;
		if (end.X < start.X && end.Y > start.Y && threshold <= dx && threshold <= dy)
			return WalkDirection.DownLeft;
		if (end.X > start.X && end.Y > start.Y && threshold <= dx && threshold <= dy)
			return WalkDirection.DownRight;

		if (end.Y < start.Y && dx < dy)
			return WalkDirection.Up;

		WalkDirection result = WalkDirection.None;
		if (start.X < end.X)
			result = WalkDirection.Right;
		else if (end.X < start.X)
			result = WalkDirection.Left;

		if (dx < dy && start.Y < end.Y)
			result = WalkDirection.Down;

		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoPointsNoDiagonals(Vector2 start, Vector2 end)
	{
		if (end.Y < start.Y && Math.Abs(start.X - end.X) < Math.Abs(start.Y - end.Y))
			return WalkDirection.Up;
		if (start.Y < end.Y && Math.Abs(start.X - end.X) < Math.Abs(start.Y - end.Y))
			return WalkDirection.Down;
		if (start.X > end.X)
			return WalkDirection.Left;
		if (start.X < end.X)
			return WalkDirection.Right;
		return WalkDirection.None;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoNodes(AStarNode start, AStarNode end)
	{
		int dx = Math.Abs(start.x - end.x);
		int dy = Math.Abs(start.y - end.y);

		if (start.y > end.y && dy > dx)
			return WalkDirection.Up;
		if (end.y > start.y && dy > dx)
			return WalkDirection.Down;
		if (end.x < start.x)
			return WalkDirection.Left;
		if (start.x < end.x)
			return WalkDirection.Right;
		return WalkDirection.None;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoTiles(Vector2 start, Vector2 end)
	{
		float dy = end.Y - start.Y;
		float absDx = Math.Abs(end.X - start.X);

		if (dy < -32f && absDx < 32f)
			return WalkDirection.Up;
		if (dy > 32f && absDx < 32f)
			return WalkDirection.Down;

		float dx = end.X - start.X;
		float absDy = Math.Abs(dy);
		if (dx < -32f && absDy < 32f)
			return WalkDirection.Left;
		if (dx > 32f && absDy < 32f)
			return WalkDirection.Right;
		if (dx < -32f && dy < -32f)
			return WalkDirection.UpLeft;
		if (dx > 32f && dy < -32f)
			return WalkDirection.UpRight;
		if (dx < -32f && dy > 32f)
			return WalkDirection.DownLeft;
		if (dx > 32f && dy > 32f)
			return WalkDirection.DownRight;

		if (absDx <= absDy)
			return dy < 0f ? WalkDirection.Up : WalkDirection.Down;
		return dx < 0f ? WalkDirection.Left : WalkDirection.Right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double distance(int x1, int x2, int y1, int y2)
	{
		double dx = x1 - x2;
		double dy = y1 - y2;
		return Math.Sqrt(dx * dx + dy * dy);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarPath GetShortestPathAStarWithBubbleCheck(AStarNode startNode, AStarNode endNode)
	{
		if (startNode == null || endNode == null)
			return null;

		if (endNode.bubbleID != 0)
		{
			startNode.bubbleID = 0;
			if (endNode.bubbleID != -1 || !PathBetweenNodesExists(startNode, endNode))
			{
				ResetBubbles(false, true);
				endNode.SetBubbleIDRecursively(0, true);
				if (startNode.bubbleID2 != endNode.bubbleID2)
					return null;
				mergeBubbleID2IntoBubbleID();
			}
		}

		return GetShortestPathAStar(startNode, endNode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PathBetweenNodesExists(AStarNode start, AStarNode end)
	{
		if (start.bubbleID == end.bubbleID)
			return true;

		if (end.bubbleID != -1 || !end.fakeTileClear)
			return false;

		AStarNode node = FetchAStarNode(end.x - 1, end.y);
		if (node != null && node.bubbleID == start.bubbleID)
			return true;
		node = FetchAStarNode(end.x + 1, end.y);
		if (node != null && node.bubbleID == start.bubbleID)
			return true;
		node = FetchAStarNode(end.x, end.y - 1);
		if (node != null && node.bubbleID == start.bubbleID)
			return true;
		node = FetchAStarNode(end.x, end.y + 1);
		return node != null && node.bubbleID == start.bubbleID;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int walkingDirectionToStardewDirection(WalkDirection d)
	{
		return d switch
		{
			WalkDirection.Up => 0,
			WalkDirection.Down => 2,
			WalkDirection.Left => 3,
			WalkDirection.Right => 1,
			_ => -1,
		};
	}
}
