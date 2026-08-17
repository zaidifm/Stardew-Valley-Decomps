using System.Runtime.CompilerServices;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsCinema()
	{
		if (_aStarGraph.gameLocation is not Town)
			return false;
		if (!Utility.doesMasterPlayerHaveMailReceivedButNotMailForTomorrow("ccMovieTheater"))
			return false;

		if (x >= 47 && x <= 58 && y >= 17 && y <= 19)
			return true;
		return y == 20 && (x == 47 || (x >= 55 && x <= 58));
	}
}
