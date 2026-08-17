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
	public static bool IsWater(Vector2 tile)
	{
		if (gameLocation is Submarine
			&& tile.X >= 9f && tile.X <= 20f
			&& tile.Y >= 7f && tile.Y <= 11f)
		{
			return true;
		}

		if (gameLocation is VolcanoDungeon volcanoDungeon)
		{
			if (volcanoDungeon.IsCooledLava((int)tile.X, (int)tile.Y))
				return false;
			if (volcanoDungeon.CanRefillWateringCanOnTile((int)tile.X, (int)tile.Y))
				return true;
		}

		if (gameLocation.doesTileHaveProperty((int)tile.X, (int)tile.Y, "Water", "Back", false) != null)
			return true;
		return gameLocation.doesTileHaveProperty((int)tile.X, (int)tile.Y, "WaterSource", "Back", false) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBuildingPassable(Vector2 tilePosition)
	{
		Tile tile = gameLocation.map.GetLayer("Buildings")
			.PickTile(new Location((int)tilePosition.X << 6, (int)tilePosition.Y << 6), Game1.viewport.Size);
		if (tile == null)
			return false;

		if (tile.TileIndexProperties.TryGetValue("Passable", out PropertyValue passable))
		{
			if (passable != null && passable.ToString() == "T")
				return true;
			if (passable.ToString() == "True")
				return true;
		}

		tile.Properties.TryGetValue("Passable", out PropertyValue directPassable);
		if (directPassable != null)
			return true;

		tile.TileIndexProperties.TryGetValue("Shadow", out PropertyValue shadow);
		return shadow != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTilePassable(GameLocation gameLocation, int tileX, int tileY)
	{
		Location pixel = new Location(tileX << 6, tileY << 6);
		Tile tile = gameLocation.map.GetLayer("Buildings").PickTile(pixel, Game1.viewport.Size);
		if (tile == null)
		{
			tile = gameLocation.map.GetLayer("Back").PickTile(pixel, Game1.viewport.Size);
			if (tile == null)
				return false;

			tile.TileIndexProperties.TryGetValue("Passable", out PropertyValue passable);
			if (passable != null)
			{
				string value = passable.ToString().ToLower();
				if (value[0] == 'f')
					return false;
				if (passable.ToString() == "0")
					return false;
			}

			tile.TileIndexProperties.TryGetValue("Water", out passable);
			if (passable != null
				&& (gameLocation is not VolcanoDungeon volcanoDungeon
					|| !volcanoDungeon.IsCooledLava(tileX, tileY)))
			{
				return false;
			}

			tile.TileIndexProperties.TryGetValue("WaterSource", out passable);
			return passable == null;
		}

		tile.TileIndexProperties.TryGetValue("Passable", out PropertyValue tileIndexPassable);
		PropertyValue directPassable2 = null;
		PropertyValue shadow2 = null;
		if (tileIndexPassable == null)
		{
			tile.Properties.TryGetValue("Passable", out directPassable2);
			if (directPassable2 == null)
				tile.TileIndexProperties.TryGetValue("Shadow", out shadow2);
		}

		if (tileIndexPassable != null
			&& tileIndexPassable.ToString().ToLower()[0] == 't')
		{
			return true;
		}

		if (directPassable2 != null
			&& directPassable2.ToString().ToLower()[0] == 't')
		{
			return true;
		}

		return shadow2 != null;
	}
}
