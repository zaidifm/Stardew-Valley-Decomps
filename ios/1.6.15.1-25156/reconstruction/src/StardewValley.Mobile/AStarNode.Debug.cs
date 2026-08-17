using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using xTile.Dimensions;
using xTile.ObjectModel;
using xTile.Tiles;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugTileClear()
	{
		DebugObjectParentSheetIndexOnTile();
		_ = TileClear;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugObjectParentSheetIndexOnTile()
	{
		if (_aStarGraph.gameLocation.objects.TryGetValue(new Vector2(x, y), out Object value))
		{
			Log.It(string.Concat(
				"obj.parentSheetIndex:",
				value.parentSheetIndex?.ToString(),
				", ",
				value.ToString()));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DebugIsTilePassable()
	{
		Log.It("AStarNode.DebugIsTilePassable (" + x + "," + y + ")... " + isTilePassable());

		Tile backTile = _aStarGraph.gameLocation.map.GetLayer("Back")
			.PickTile(new Location(x << 6, y << 6), Game1.viewport.Size);
		if (backTile == null)
		{
			Log.It("AStarNode.DebugIsTilePassable A (" + x + "," + y + ") FALSE tile is null");
			return false;
		}

		backTile.TileIndexProperties.TryGetValue("Passable", out PropertyValue passable);
		if (passable != null)
		{
			Log.It("AStarNode.DebugIsTilePassable B (" + x + "," + y + ") FALSE Passable:" + passable);
			return false;
		}

		Tile buildingTile = _aStarGraph.gameLocation.map.GetLayer("Buildings")
			.PickTile(new Location(x << 6, y << 6), Game1.viewport.Size);
		if (buildingTile != null)
		{
			buildingTile.TileIndexProperties.TryGetValue("Passable", out passable);
			Log.It("AStarNode.DebugIsTilePassable C (" + x + "," + y + ") BUILDING Passable:"
				+ (passable?.ToString() ?? "Null") + ", IsBuildingPassable():" + IsBuildingPassable());

			foreach (KeyValuePair<string, PropertyValue> pair in buildingTile.TileIndexProperties)
				Log.It("AStarNode.DebugIsTilePassable C TileIndexProperties:" + pair.Key + " => " + pair.Value);

			foreach (KeyValuePair<string, PropertyValue> pair in buildingTile.Properties)
				Log.It("AStarNode.DebugIsTilePassable C Properties:" + pair.Key + " => " + pair.Value);

			buildingTile.TileIndexProperties.TryGetValue("Shadow", out PropertyValue shadow);
			if (shadow != null)
				Log.It("AStarNode.DebugIsTilePassable C has shadow");

			if (passable != null)
				return true;
			return shadow != null;
		}

		backTile.TileIndexProperties.TryGetValue("Water", out passable);
		if (passable != null)
		{
			Log.It("AStarNode.DebugIsTilePassable D (" + x + "," + y + ") FALSE Water:" + passable);
			return false;
		}

		backTile.TileIndexProperties.TryGetValue("WaterSource", out passable);
		if (passable != null)
		{
			Log.It("AStarNode.DebugIsTilePassable E (" + x + "," + y + ") FALSE WaterSource:" + passable);
			return false;
		}

		bool mobilePassable = isTilePassable();
		bool locationPassable = _aStarGraph.gameLocation.isTilePassable(new Vector2(x, y));
		Log.It("AStarNode.DebugIsTilePassable F (" + x + "," + y + ")... isTilePassable:" + mobilePassable
			+ ", _aStarGraph.gameLocation.isTilePassable:" + locationPassable);
		if (mobilePassable == locationPassable)
			return true;

		Tile tmp = _aStarGraph.gameLocation.map.GetLayer("Back")
			.PickTile(new Location(x << 6, y << 6), Game1.viewport.Size);
		PropertyValue backPassable = null;
		if (tmp != null)
			tmp.TileIndexProperties.TryGetValue("Passable", out backPassable);

		Tile tileX = _aStarGraph.gameLocation.map.GetLayer("Buildings")
			.PickTile(new Location(x << 6, y << 6), Game1.viewport.Size);
		PropertyValue buildingPassable = null;
		if (tileX != null)
		{
			tileX.TileIndexProperties.TryGetValue("Passable", out buildingPassable);
			Log.It("AStarNode.DebugIsTilePassable G (" + x + "," + y + ") BUILDING Passable:"
				+ (buildingPassable?.ToString() ?? "Null"));
		}

		Log.It("AStarNode.DebugIsTilePassable H (passable == null):" + (backPassable == null)
			+ ", (tileX == null):" + (tileX == null)
			+ ", (tmp != null):" + (tmp != null));

		if (backPassable != null || tileX != null)
			return false;
		return tmp != null;
	}
}
