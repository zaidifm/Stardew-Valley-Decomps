using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsOreAt(Vector2 tile)
	{
		if (gameLocation.orePanPoint.Value == Point.Zero)
			return false;

		return Utility.Distance(
			gameLocation.orePanPoint.X,
			gameLocation.orePanPoint.Y,
			(int)tile.X,
			(int)tile.Y) <= 2.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isOnOrNearSuspensionBridge(int x, int y)
	{
		if (!Game1.player.onBridge.Value)
		{
			if (y < 39 || y > 41)
				return false;
			if (x < 26)
				return false;
			if (x > 38)
				return x > 42;
		}

		return true;
	}
}
