using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Locations;
using xTile.Dimensions;
using xTile.ObjectModel;
using xTile.Tiles;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool InWarpRange(Vector2 clickPoint)
	{
		if (gameLocation.ignoreWarps)
			return false;

		foreach (Warp warp in gameLocation.warps)
		{
			Vector2 warpPosition = new Vector2(warp.X << 6, warp.Y << 6);
			if (Vector2.Distance(warpPosition + new Vector2(32f, 32f), clickPoint) < WarpRange
				&& Vector2.Distance(warpPosition, Game1.player.Position) < WarpRange)
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NodeIsWarp(AStarNode aStarNode)
	{
		if (aStarNode == null || gameLocation.ignoreWarps)
			return false;

		Vector2 nodeCenter = new Vector2((aStarNode.x << 6) + 32f, (aStarNode.y << 6) + 32f);
		foreach (Warp warp in gameLocation.warps)
		{
			Vector2 warpPosition = new Vector2(warp.X << 6, warp.Y << 6);
			if (Vector2.Distance(warpPosition, nodeCenter) < WarpRange)
				return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool WarpIfInRange(Vector2 clickPoint)
	{
		if (gameLocation.ignoreWarps || !Game1.player.CanMove)
			return false;

		foreach (Warp sourceWarp in gameLocation.warps)
		{
			Warp warp = sourceWarp;
			if (sourceWarp.TargetName == "VolcanoEntrance")
			{
				warp = new Warp(sourceWarp.X, sourceWarp.Y, "VolcanoDungeon0",
					sourceWarp.TargetX, sourceWarp.TargetY, flipFarmer: false);
			}

			Vector2 warpPosition = new Vector2(warp.X << 6, warp.Y << 6);
			float clickDistance = Vector2.Distance(warpPosition + new Vector2(32f, 32f), clickPoint);
			float playerDistance = Vector2.Distance(warpPosition, Game1.player.Position);

			if (sourceWarp.TargetName == "IslandSouthEast"
				&& gameLocation is IslandSouth islandSouth
				&& !islandSouth.westernTurtleMoved.Value
				&& playerDistance > 125f)
			{
				return false;
			}

			if (gameLocation is BusStop && sourceWarp.TargetName == "Desert")
				continue;

			if (clickDistance < WarpRange && playerDistance < WarpRange)
			{
				Game1.player.warpFarmer(warp, -1);
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NpcAtWarpOrDoor(NPC npc, GameLocation location)
	{
		if (location == null)
			return false;

		if (location.isCollidingWithWarp(npc.GetBoundingBox(), npc) != null)
			return true;

		if (location.map == null)
			return false;

		Point pixel = npc.StandingPixel;
		switch (npc.getDirection())
		{
			case 0: pixel.Y -= 64; break;
			case 1: pixel.X += 64; break;
			case 2: pixel.Y += 64; break;
			case 3: pixel.X -= 64; break;
			default: pixel = Point.Zero; break;
		}

		var layer = location.map.GetLayer("Buildings");
		Tile tile = layer?.PickTile(new Location(pixel.X, pixel.Y), Game1.viewport.Size);
		if (tile == null)
			return false;

		tile.Properties.TryGetValue("Action", out PropertyValue action);
		return action != null;
	}
}
