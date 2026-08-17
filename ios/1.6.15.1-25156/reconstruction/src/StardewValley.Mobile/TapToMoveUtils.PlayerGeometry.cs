using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	public static Vector2 PlayerOffsetPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => new Vector2(
			Game1.player.Position.X + 32f,
			Game1.player.Position.Y + 32f);
	}

	public static Vector2 PlayerPositionOnScreen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get => new Vector2(
			Game1.player.Position.X + 32f - Game1.viewport.X,
			Game1.player.Position.Y + 32f - Game1.viewport.Y);
	}

	public static float WarpRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			GameLocation location = Game1.currentLocation;
			if (location != null && (location.isOutdoors.Value || location is BathHousePool))
				return 128f;
			return 96f;
		}
	}
}
