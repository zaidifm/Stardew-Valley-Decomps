using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ConvertWalkDirection(WalkDirection walkDirection)
	{
		return walkDirection switch
		{
			WalkDirection.Up => 0,
			WalkDirection.Down => 2,
			WalkDirection.Left => 3,
			WalkDirection.Right => 1,
			_ => -1
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WalkDirection WalkDirectionForAngle(float angleDegrees)
	{
		if (angleDegrees >= -22.5f && angleDegrees < 22.5f)
			return WalkDirection.Right;
		if (angleDegrees >= 22.5f && angleDegrees < 67.5f)
			return WalkDirection.DownRight;
		if (angleDegrees >= 67.5f && angleDegrees < 112.5f)
			return WalkDirection.Down;
		if (angleDegrees >= 112.5f && angleDegrees < 157.5f)
			return WalkDirection.DownLeft;
		if (angleDegrees >= -157.5f && angleDegrees < -112.5f)
			return WalkDirection.UpLeft;
		if (angleDegrees >= -67.5f && angleDegrees < -22.5f)
			return WalkDirection.UpRight;
		if (angleDegrees >= -112.5f && angleDegrees < -67.5f)
			return WalkDirection.Up;
		return WalkDirection.Left;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WalkDirection WalkDirectionForAngleJustDiagonals(float angleDegrees)
	{
		if (angleDegrees >= 0f && angleDegrees < 90f)
			return WalkDirection.DownRight;
		if (angleDegrees >= 90f && angleDegrees <= 180f)
			return WalkDirection.DownLeft;
		if (angleDegrees >= -180f && angleDegrees <= -90f)
			return WalkDirection.UpLeft;
		return WalkDirection.UpRight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int FaceDirectionForAngle(float angleDegrees)
	{
		if (angleDegrees > -135f && angleDegrees <= -45f)
			return 0;
		if (angleDegrees > -45f && angleDegrees < 45f)
			return 1;
		if (angleDegrees >= 45f && angleDegrees <= 135f)
			return 2;
		return 3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool WalkDirectionsAgree(WalkDirection walkDirectionA, WalkDirection walkDirectionB)
	{
		return walkDirectionA switch
		{
			WalkDirection.Up => walkDirectionB is WalkDirection.Up or WalkDirection.UpLeft or WalkDirection.UpRight,
			WalkDirection.Down => walkDirectionB is WalkDirection.Down or WalkDirection.DownLeft or WalkDirection.DownRight,
			WalkDirection.Left => walkDirectionB is WalkDirection.Left or WalkDirection.UpLeft or WalkDirection.DownLeft,
			WalkDirection.Right => walkDirectionB is WalkDirection.Right or WalkDirection.UpRight or WalkDirection.DownRight,
			WalkDirection.UpLeft => walkDirectionB is WalkDirection.Up or WalkDirection.Left or WalkDirection.UpLeft,
			WalkDirection.UpRight => walkDirectionB is WalkDirection.Up or WalkDirection.Right or WalkDirection.UpRight,
			WalkDirection.DownLeft => walkDirectionB is WalkDirection.Down or WalkDirection.Left or WalkDirection.DownLeft,
			WalkDirection.DownRight => walkDirectionB is WalkDirection.Down or WalkDirection.Right or WalkDirection.DownRight,
			_ => false
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WalkDirection GetWalkDirectionFacing(Vector2 monsterPosition, Vector2 farmerPosition)
	{
		double angle = Math.Atan2(monsterPosition.Y - farmerPosition.Y, monsterPosition.X - farmerPosition.X);
		if (angle >= -Math.PI / 4 && angle <= Math.PI / 4)
			return WalkDirection.Right;
		if (angle > Math.PI / 4 && angle <= 3 * Math.PI / 4)
			return WalkDirection.Down;
		if (angle >= -3 * Math.PI / 4 && angle < -Math.PI / 4)
			return WalkDirection.Up;
		return WalkDirection.Left;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetDirectionFacing(Vector2 targetPosition, Vector2 startPosition)
	{
		double angle = Math.Atan2(targetPosition.Y - startPosition.Y, targetPosition.X - startPosition.X);
		if (angle >= -Math.PI / 4 && angle <= Math.PI / 4)
			return 1;
		if (angle > Math.PI / 4 && angle <= 3 * Math.PI / 4)
			return 2;
		if (angle >= -3 * Math.PI / 4 && angle < -Math.PI / 4)
			return 0;
		return 3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point FetchNextPointOut(int startX, int startY, int endX, int endY)
	{
		int x = endX;
		if (endX < startX)
			x++;
		else if (startX < endX)
			x--;

		int y = endY;
		if (endY < startY)
			y++;
		else if (startY < endY)
			y--;

		return new Point(x, y);
	}
}
