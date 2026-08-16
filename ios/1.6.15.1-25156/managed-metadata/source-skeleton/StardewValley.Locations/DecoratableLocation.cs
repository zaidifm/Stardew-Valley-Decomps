using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Network;
using StardewValley.Objects;
using xTile;
using xTile.Tiles;

namespace StardewValley.Locations;

public class DecoratableLocation : GameLocation
{
	public readonly DecorationFacade wallPaper;

	[XmlIgnore]
	public readonly NetStringList wallpaperIDs;

	public readonly NetStringDictionary<string, NetString> appliedWallpaper;

	[XmlIgnore]
	public readonly Dictionary<string, List<Vector3>> wallpaperTiles;

	public readonly DecorationFacade floor;

	[XmlIgnore]
	public readonly NetStringList floorIDs;

	public readonly NetStringDictionary<string, NetString> appliedFloor;

	[XmlIgnore]
	public readonly Dictionary<string, List<Vector3>> floorTiles;

	protected Dictionary<string, TileSheet> _wallAndFloorTileSheets;

	protected Map _wallAndFloorTileSheetMap;

	[NonInstancedStatic]
	public static bool LogTroubleshootingInfo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DecoratableLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DecoratableLocation(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateLayout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReadWallpaperAndFloorTileData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual TileSheet GetWallAndFloorTilesheet(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual KeyValuePair<string, int> GetFloorSource(string pattern_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual KeyValuePair<string, int> GetWallpaperSource(string pattern_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateFloor(string floorId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateWallpaper(string wallpaperId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanFreePlaceFurniture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileOnWall(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetWallTopY(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setFloors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setWallpapers()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFloor(string which, string which_room)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWallpaper(string which, string which_room)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OverrideSpecificWallpaper(string which, string which_room, string wallpaperStyleToOverride)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OverrideSpecificFlooring(string which, string which_room, string flooringStyleToOverride)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFloorID(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetWallpaperID(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsFloorableTile(int x, int y, string layer_name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsWallAndFloorTilesheet(string tilesheet_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsFloorableOrWallpaperableTile(int x, int y, string layerName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsFloorableOrWallpaperableTile(int x, int y, string layerName, out string reasonInvalid)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Furniture getRandomFurniture(Random r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getFloorRoomIdAt(Point p)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetFirstFlooringTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetFlooringIndex(int base_tile_sheet, int tile_x, int tile_y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<Rectangle> getFloors()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
