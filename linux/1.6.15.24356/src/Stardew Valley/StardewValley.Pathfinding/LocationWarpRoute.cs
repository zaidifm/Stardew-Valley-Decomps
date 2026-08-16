namespace StardewValley.Pathfinding;

public class LocationWarpRoute
{
	public readonly string[] LocationNames;

	public readonly Gender? OnlyGender;

	public LocationWarpRoute(string[] locationNames, Gender? onlyGender)
	{
		LocationNames = locationNames;
		OnlyGender = onlyGender;
	}
}
