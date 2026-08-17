using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Locations;
using StardewValley.Objects;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBed()
	{
		if (_aStarGraph.gameLocation is not FarmHouse)
			return false;

		FarmHouse home = Utility.getHomeOfFarmer(Game1.player);
		BedFurniture bed = home.GetBed(BedFurniture.BedType.Any, 0);
		Point bedSpot = bed?.GetBedSpot() ?? new Point(-1000, -1000);
		return x == (int)(bedSpot.X * 64f)
			&& y == (int)(bedSpot.Y * 64f);
	}
}
