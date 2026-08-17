using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.BellsAndWhistles;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsParrotExpress()
	{
		if (_aStarGraph.gameLocation is not IslandLocation island)
			return false;

		Vector2 tile = new Vector2(x, y);
		foreach (ParrotPlatform platform in island.parrotPlatforms)
		{
			if (platform.OccupiesTile(tile)
				&& platform.position / 64f + new Vector2(1f, 1f) != tile
				&& platform.position / 64f + new Vector2(1f, 0f) != tile)
			{
				return true;
			}
		}

		return false;
	}
}
