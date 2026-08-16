using System.Runtime.CompilerServices;

namespace StardewValley.Pathfinding;

public class LocationWarpRoute
{
	public readonly string[] LocationNames;

	public readonly Gender? OnlyGender;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocationWarpRoute(string[] locationNames, Gender? onlyGender)
	{
	}
}
