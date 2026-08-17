using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.TerrainFeatures;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsStumpOrBoulder()
	{
		foreach (ResourceClump resourceClump in _aStarGraph.gameLocation.resourceClumps)
		{
			if (resourceClump.occupiesTile(x, y))
				return true;
		}

		return _aStarGraph.gameLocation.objects.TryGetValue(new Vector2(x, y), out Object value)
			&& value.ItemId == "Boulder";
	}
}
