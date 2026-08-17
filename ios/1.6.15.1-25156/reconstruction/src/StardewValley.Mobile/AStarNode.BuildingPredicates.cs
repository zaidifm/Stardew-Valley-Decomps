using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Buildings;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Building FetchBuilding()
	{
		GameLocation location = _aStarGraph.gameLocation;
		if (!location.IsBuildableLocation())
			return null;

		Vector2 tile = new Vector2(x, y);
		foreach (Building building in location.buildings)
		{
			if (!building.isTilePassable(tile))
				return building;
		}

		return null;
	}
}
