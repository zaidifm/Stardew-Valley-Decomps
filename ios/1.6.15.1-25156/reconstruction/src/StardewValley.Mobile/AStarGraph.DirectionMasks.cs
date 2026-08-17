using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AreOppositeWalkDirection(WalkDirection walkDirectionA, WalkDirection walkDirectionB)
	{
		return walkDirectionA switch
		{
			WalkDirection.Up => walkDirectionB is WalkDirection.Down or WalkDirection.DownLeft or WalkDirection.DownRight,
			WalkDirection.Down => walkDirectionB is WalkDirection.Up or WalkDirection.UpLeft or WalkDirection.UpRight,
			WalkDirection.Left => walkDirectionB is WalkDirection.Right or WalkDirection.UpRight or WalkDirection.DownRight,
			WalkDirection.Right => walkDirectionB is WalkDirection.Left or WalkDirection.UpLeft or WalkDirection.DownLeft,
			WalkDirection.UpLeft => walkDirectionB is WalkDirection.Down or WalkDirection.Right or WalkDirection.UpRight or WalkDirection.DownLeft or WalkDirection.DownRight,
			WalkDirection.UpRight => walkDirectionB is WalkDirection.Down or WalkDirection.Left or WalkDirection.UpLeft or WalkDirection.DownLeft or WalkDirection.DownRight,
			WalkDirection.DownLeft => walkDirectionB is WalkDirection.Up or WalkDirection.Right or WalkDirection.UpLeft or WalkDirection.UpRight or WalkDirection.DownRight,
			WalkDirection.DownRight => walkDirectionB is WalkDirection.Up or WalkDirection.Left or WalkDirection.UpLeft or WalkDirection.UpRight or WalkDirection.DownLeft,
			_ => false,
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WalkDirection WalkDirectionBetweenTwoPointsWithLastDirection(
		Vector2 start,
		Vector2 end,
		WalkDirection lastDirection,
		float threshold = 0f)
	{
		float dy = Math.Abs(start.Y - end.Y);
		float dx = Math.Abs(start.X - end.X);

		if (end.X < start.X && end.Y < start.Y && threshold <= dx && threshold <= dy
			&& lastDirection is WalkDirection.None or WalkDirection.Up or WalkDirection.Left or WalkDirection.UpLeft)
		{
			return WalkDirection.UpLeft;
		}

		if (start.X < end.X && end.Y < start.Y && threshold <= dx && threshold <= dy
			&& lastDirection is WalkDirection.None or WalkDirection.Up or WalkDirection.Right or WalkDirection.UpRight)
		{
			return WalkDirection.UpRight;
		}

		if (end.X < start.X && start.Y < end.Y && threshold <= dx && threshold <= dy
			&& lastDirection is WalkDirection.None or WalkDirection.Down or WalkDirection.Left or WalkDirection.DownLeft)
		{
			return WalkDirection.DownLeft;
		}

		if (start.X < end.X && start.Y < end.Y && threshold <= dx && threshold <= dy
			&& lastDirection is WalkDirection.None or WalkDirection.Down or WalkDirection.Right or WalkDirection.DownRight)
		{
			return WalkDirection.DownRight;
		}

		if (end.Y < start.Y && threshold <= dy
			&& lastDirection is WalkDirection.None or WalkDirection.Up or WalkDirection.UpLeft or WalkDirection.UpRight)
		{
			return WalkDirection.Up;
		}

		if (start.Y < end.Y && threshold <= dy
			&& lastDirection is WalkDirection.None or WalkDirection.Down or WalkDirection.DownLeft or WalkDirection.DownRight)
		{
			return WalkDirection.Down;
		}

		if (end.X < start.X
			&& lastDirection is WalkDirection.None or WalkDirection.Left or WalkDirection.UpLeft or WalkDirection.DownLeft)
		{
			return WalkDirection.Left;
		}

		if (start.X < end.X
			&& lastDirection is WalkDirection.None or WalkDirection.Right or WalkDirection.UpRight or WalkDirection.DownRight)
		{
			return WalkDirection.Right;
		}

		return WalkDirection.None;
	}
}
