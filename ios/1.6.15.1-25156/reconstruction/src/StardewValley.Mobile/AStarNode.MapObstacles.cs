using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Buildings;
using xTile.Dimensions;
using xTile.Tiles;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsSomeKindOfWarp()
	{
		Tile tile = _aStarGraph.gameLocation.map.GetLayer("Buildings")
			.PickTile(new Location(x << 6, y << 6), Game1.viewport.Size);
		if (tile == null)
			return false;

		_ = tile.TileIndexProperties.TryGetValue("Passable", out _);
		foreach (var property in tile.Properties)
		{
			string value = property.Value.ToString();
			if (value == "LockedDoorWarp"
				|| value == "Warp"
				|| value == "WarpMensLocker"
				|| value == "WarpWomensLocker")
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsBuilding()
	{
		if (_aStarGraph.gameLocation.IsBuildableLocation())
		{
			foreach (Building building in _aStarGraph.gameLocation.buildings)
			{
				if (!building.isTilePassable(new Vector2(x, y)))
					return true;
			}
			return false;
		}

		return _aStarGraph.gameLocation.map.GetLayer("Buildings")
			.PickTile(new Location(x << 6, y << 6), Game1.viewport.Size) != null;
	}
}
