using System.Runtime.CompilerServices;
using xTile.Dimensions;
using xTile.ObjectModel;
using xTile.Tiles;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBuildingPassable()
	{
		Tile tile = _aStarGraph.gameLocation.map.GetLayer("Buildings")
			.PickTile(new Location(x << 6, y << 6), Game1.viewport.Size);
		if (tile == null)
			return false;

		if (tile.TileIndexProperties.TryGetValue("Passable", out PropertyValue tileIndexPassable))
		{
			string value = tileIndexPassable.ToString().ToLower();
			if (value == "t" || value == "true")
				return true;
		}

		if (tile.Properties.TryGetValue("Passable", out PropertyValue passable))
		{
			string value = passable.ToString().ToLower();
			if (value == "t" || value == "true")
				return true;
		}

		return tile.TileIndexProperties.TryGetValue("Shadow", out _);
	}
}
