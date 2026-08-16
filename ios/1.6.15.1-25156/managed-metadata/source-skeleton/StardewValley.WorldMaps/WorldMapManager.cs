using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Internal;

namespace StardewValley.WorldMaps;

public static class WorldMapManager
{
	private static int NextClearCacheTick;

	private static int MaxCacheTicks;

	private static readonly List<MapRegion> Regions;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorldMapManager()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReloadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<MapRegion> GetMapRegions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MapAreaPositionWithContext? GetPositionData(GameLocation location, Point tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MapAreaPositionWithContext? GetPositionData(GameLocation location, Point tile, LogBuilder log)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MapAreaPosition GetPositionDataWithoutFallback(GameLocation location, Point tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MapAreaPosition GetPositionDataWithoutFallback(GameLocation location, Point tile, LogBuilder log)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ReloadDataIfStale()
	{
	}
}
