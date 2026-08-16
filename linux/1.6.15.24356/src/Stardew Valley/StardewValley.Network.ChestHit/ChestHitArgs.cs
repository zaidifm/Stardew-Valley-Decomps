using Microsoft.Xna.Framework;

namespace StardewValley.Network.ChestHit;

public sealed class ChestHitArgs
{
	public GameLocation Location;

	public Point ChestTile;

	public Vector2 ToolPosition;

	public Point StandingPixel;

	public int Direction;

	public bool HoldDownClick;

	public bool ToolCanHit;

	public bool RecentlyHit;
}
