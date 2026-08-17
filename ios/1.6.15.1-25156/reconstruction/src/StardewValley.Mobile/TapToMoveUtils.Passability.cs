using System.Runtime.CompilerServices;
using StardewValley.Locations;
using xTile.Dimensions;
using xTile.ObjectModel;
using xTile.Tiles;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
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
		PropertyValue directPassable = null;
		PropertyValue shadow = null;
		if (tileIndexPassable == null)
		{
			tile.Properties.TryGetValue("Passable", out directPassable);
			if (directPassable == null)
				tile.TileIndexProperties.TryGetValue("Shadow", out shadow);
		}

		if (tileIndexPassable != null
			&& tileIndexPassable.ToString().ToLower()[0] == 't')
		{
			return true;
		}

		if (directPassable != null
			&& directPassable.ToString().ToLower()[0] == 't')
		{
			return true;
		}

		return shadow != null;
	}
}
