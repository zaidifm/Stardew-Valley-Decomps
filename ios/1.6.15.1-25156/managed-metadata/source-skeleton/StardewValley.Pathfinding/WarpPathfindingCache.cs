using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Pathfinding;

public static class WarpPathfindingCache
{
	private static readonly Dictionary<string, List<LocationWarpRoute>> Routes;

	public static readonly HashSet<string> IgnoreLocationNames;

	public static readonly Dictionary<string, string> OverrideTargetNames;

	public static readonly Dictionary<string, Gender> GenderRestrictions;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PopulateCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] GetLocationRoute(string startingLocation, string endingLocation, Gender gender)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExploreWarpPoints(GameLocation location, List<string> route, Gender? genderRestriction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExploreWarpPoints(string locationName, List<string> route, Gender? genderRestriction, HashSet<string> seenTargets)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AddRoute(List<string> route, Gender? onlyGender)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearCache()
	{
	}
}
