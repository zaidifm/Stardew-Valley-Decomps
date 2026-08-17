using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private WalkDirection DiagonalWalkDirection(AStarPath path, int i)
	{
		if (((path.nodes[i + 1].x == path.nodes[i].x - 1 && path.nodes[i + 1].y == path.nodes[i].y)
			|| (path.nodes[i + 1].x == path.nodes[i].x && path.nodes[i + 1].y == path.nodes[i].y + 1))
			&& path.nodes[i + 2].x == path.nodes[i].x - 1
			&& path.nodes[i + 2].y == path.nodes[i].y + 1)
		{
			int matchingNeighbours = 0;
			for (int j = 0; j < path.nodes[i].GetNeighbouringNodeList(true).Count; j++)
			{
				if (path.nodes[i].GetNeighbouringNodeList(true)[j].x == path.nodes[i].x - 1
					&& path.nodes[i].GetNeighbouringNodeList(true)[j].y == path.nodes[i].y)
				{
					matchingNeighbours++;
				}
				else if (path.nodes[i].GetNeighbouringNodeList(true)[j].x == path.nodes[i].x
					&& path.nodes[i].GetNeighbouringNodeList(true)[j].y == path.nodes[i].y + 1)
				{
					matchingNeighbours++;
				}
			}

			if (matchingNeighbours == 2)
				return WalkDirection.DownLeft;
		}

		if (((path.nodes[i + 1].x == path.nodes[i].x + 1 && path.nodes[i + 1].y == path.nodes[i].y)
			|| (path.nodes[i + 1].x == path.nodes[i].x && path.nodes[i + 1].y == path.nodes[i].y + 1))
			&& path.nodes[i + 2].x == path.nodes[i].x + 1
			&& path.nodes[i + 2].y == path.nodes[i].y + 1)
		{
			int matchingNeighbours = 0;
			for (int j = 0; j < path.nodes[i].GetNeighbouringNodeList(true).Count; j++)
			{
				if (path.nodes[i].GetNeighbouringNodeList(true)[j].x == path.nodes[i].x + 1
					&& path.nodes[i].GetNeighbouringNodeList(true)[j].y == path.nodes[i].y)
				{
					matchingNeighbours++;
				}
				else if (path.nodes[i].GetNeighbouringNodeList(true)[j].x == path.nodes[i].x
					&& path.nodes[i].GetNeighbouringNodeList(true)[j].y == path.nodes[i].y + 1)
				{
					matchingNeighbours++;
				}
			}

			if (matchingNeighbours == 2)
				return WalkDirection.DownRight;
		}

		if (((path.nodes[i + 1].x == path.nodes[i].x - 1 && path.nodes[i + 1].y == path.nodes[i].y)
			|| (path.nodes[i + 1].x == path.nodes[i].x && path.nodes[i + 1].y == path.nodes[i].y - 1))
			&& path.nodes[i + 2].x == path.nodes[i].x - 1
			&& path.nodes[i + 2].y == path.nodes[i].y - 1)
		{
			int matchingNeighbours = 0;
			for (int j = 0; j < path.nodes[i].GetNeighbouringNodeList(true).Count; j++)
			{
				if (path.nodes[i].GetNeighbouringNodeList(true)[j].x == path.nodes[i].x - 1
					&& path.nodes[i].GetNeighbouringNodeList(true)[j].y == path.nodes[i].y)
				{
					matchingNeighbours++;
				}
				else if (path.nodes[i].GetNeighbouringNodeList(true)[j].x == path.nodes[i].x
					&& path.nodes[i].GetNeighbouringNodeList(true)[j].y == path.nodes[i].y - 1)
				{
					matchingNeighbours++;
				}
			}

			if (matchingNeighbours == 2)
				return WalkDirection.UpLeft;
		}

		if (((path.nodes[i + 1].x == path.nodes[i].x + 1 && path.nodes[i + 1].y == path.nodes[i].y)
			|| (path.nodes[i + 1].x == path.nodes[i].x && path.nodes[i + 1].y == path.nodes[i].y - 1))
			&& path.nodes[i + 2].x == path.nodes[i].x + 1
			&& path.nodes[i + 2].y == path.nodes[i].y - 1)
		{
			int matchingNeighbours = 0;
			for (int j = 0; j < path.nodes[i].GetNeighbouringNodeList(true).Count; j++)
			{
				if (path.nodes[i].GetNeighbouringNodeList(true)[j].x == path.nodes[i].x + 1
					&& path.nodes[i].GetNeighbouringNodeList(true)[j].y == path.nodes[i].y)
				{
					matchingNeighbours++;
				}
				else if (path.nodes[i].GetNeighbouringNodeList(true)[j].x == path.nodes[i].x
					&& path.nodes[i].GetNeighbouringNodeList(true)[j].y == path.nodes[i].y - 1)
				{
					matchingNeighbours++;
				}
			}

			if (matchingNeighbours == 2)
				return WalkDirection.UpRight;
		}

		return WalkDirection.None;
	}
}
