using System.Collections.Generic;
using StardewValley.GameData.LocationContexts;

namespace StardewValley;

public static class LocationContexts
{
	public const string DefaultId = "Default";

	public const string DesertId = "Desert";

	public const string IslandId = "Island";

	public static LocationContextData Island => Require("Island");

	public static LocationContextData Default => Require("Default");

	public static LocationContextData Require(string id)
	{
		if (id == null || !Game1.locationContextData.TryGetValue(id, out var value))
		{
			throw new KeyNotFoundException("There's no entry in Data/LocationContexts with the required ID '" + id + "'.");
		}
		return value;
	}
}
