using System.Runtime.CompilerServices;
using StardewValley.Locations;
using StardewValley.TerrainFeatures;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsGiantWeed()
	{
		foreach (ResourceClump clump in _aStarGraph.gameLocation.resourceClumps)
		{
			if (clump.occupiesTile(x, y)
				&& (clump.parentSheetIndex.Value == ResourceClump.greenRainBush1Index
					|| clump.parentSheetIndex.Value == ResourceClump.greenRainBush2Index))
			{
				return true;
			}
		}

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsGiantCrop()
	{
		if (_aStarGraph.gameLocation is not Farm farm)
			return false;

		foreach (ResourceClump clump in farm.resourceClumps)
		{
			if (clump.occupiesTile(x, y) && clump is GiantCrop)
				return true;
		}

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiantCrop FetchGiantCrop()
	{
		if (_aStarGraph.gameLocation is not Farm farm)
			return null;

		foreach (ResourceClump clump in farm.resourceClumps)
		{
			if (clump.occupiesTile(x, y) && clump is GiantCrop giantCrop)
				return giantCrop;
		}

		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsStumpOrHollowLog()
	{
		foreach (ResourceClump clump in _aStarGraph.gameLocation.resourceClumps)
		{
			if (clump.occupiesTile(x, y)
				&& (clump.parentSheetIndex.Value == ResourceClump.stumpIndex
					|| clump.parentSheetIndex.Value == ResourceClump.hollowLogIndex))
			{
				return true;
			}
		}

		return false;
	}
}
