using System.Collections.Generic;
using StardewValley.Locations;

namespace StardewValley.Pathfinding;

public static class WarpPathfindingCache
{
	private static readonly Dictionary<string, List<LocationWarpRoute>> Routes = new Dictionary<string, List<LocationWarpRoute>>();

	public static readonly HashSet<string> IgnoreLocationNames = new HashSet<string> { "Backwoods", "Cellar", "Farm" };

	public static readonly Dictionary<string, string> OverrideTargetNames = new Dictionary<string, string> { ["BoatTunnel"] = "IslandSouth" };

	public static readonly Dictionary<string, Gender> GenderRestrictions = new Dictionary<string, Gender>
	{
		["BathHouse_MensLocker"] = Gender.Male,
		["BathHouse_WomensLocker"] = Gender.Female
	};

	public static void PopulateCache()
	{
		for (int i = 1; i <= Game1.netWorldState.Value.HighestPlayerLimit; i++)
		{
			IgnoreLocationNames.Add("Cellar" + i);
		}
		Routes.Clear();
		foreach (GameLocation location in Game1.locations)
		{
			if (!IgnoreLocationNames.Contains(location.NameOrUniqueName))
			{
				ExploreWarpPoints(location, new List<string>(), null);
			}
		}
	}

	public static string[] GetLocationRoute(string startingLocation, string endingLocation, Gender gender)
	{
		if (Routes.TryGetValue(startingLocation, out var value))
		{
			foreach (LocationWarpRoute item in value)
			{
				if (item.LocationNames[item.LocationNames.Length - 1] == endingLocation)
				{
					Gender? onlyGender = item.OnlyGender;
					if (!onlyGender.HasValue || item.OnlyGender == gender || gender == Gender.Undefined)
					{
						return item.LocationNames;
					}
				}
			}
		}
		return null;
	}

	private static void ExploreWarpPoints(GameLocation location, List<string> route, Gender? genderRestriction)
	{
		string text = location?.name.Value;
		if (text == null || location.ShouldExcludeFromNpcPathfinding() || route.Contains(text))
		{
			return;
		}
		if (GenderRestrictions.TryGetValue(text, out var value))
		{
			if (genderRestriction.HasValue && genderRestriction.Value != value)
			{
				return;
			}
			genderRestriction = value;
		}
		route.Add(text);
		if (route.Count > 1)
		{
			AddRoute(route, genderRestriction);
		}
		bool flag = location.warps.Count > 0;
		bool flag2 = location.doors.Length > 0;
		if (flag | flag2)
		{
			HashSet<string> hashSet = new HashSet<string> { text };
			if (route.Count > 1)
			{
				hashSet.Add(route[route.Count - 2]);
			}
			if (flag)
			{
				foreach (Warp warp in location.warps)
				{
					ExploreWarpPoints(warp.TargetName, route, genderRestriction, hashSet);
				}
			}
			if (flag2)
			{
				foreach (string value2 in location.doors.Values)
				{
					ExploreWarpPoints(value2, route, genderRestriction, hashSet);
				}
			}
		}
		if (route.Count > 0)
		{
			route.RemoveAt(route.Count - 1);
		}
	}

	private static void ExploreWarpPoints(string locationName, List<string> route, Gender? genderRestriction, HashSet<string> seenTargets)
	{
		if (OverrideTargetNames.TryGetValue(locationName, out var value))
		{
			locationName = value;
		}
		if (seenTargets.Add(locationName) && !IgnoreLocationNames.Contains(locationName) && !MineShaft.IsGeneratedLevel(locationName) && !VolcanoDungeon.IsGeneratedLevel(locationName))
		{
			ExploreWarpPoints(Game1.getLocationFromName(locationName), route, genderRestriction);
		}
	}

	private static void AddRoute(List<string> route, Gender? onlyGender)
	{
		if (!Routes.TryGetValue(route[0], out var value))
		{
			value = (Routes[route[0]] = new List<LocationWarpRoute>());
		}
		value.Add(new LocationWarpRoute(route.ToArray(), onlyGender));
	}
}
