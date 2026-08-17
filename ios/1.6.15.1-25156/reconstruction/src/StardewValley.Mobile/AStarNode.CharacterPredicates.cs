using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsAnimals()
	{
		GameLocation location = _aStarGraph.gameLocation;
		if (location is not AnimalHouse && location is not Farm)
			return false;

		foreach (FarmAnimal animal in location.animals.Values)
		{
			Point standingPixel = animal.StandingPixel;
			if (standingPixel.X / 64 == x && standingPixel.Y / 64 == y)
				return true;
		}

		return false;
	}
}
