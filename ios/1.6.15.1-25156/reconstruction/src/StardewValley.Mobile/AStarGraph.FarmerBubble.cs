using System.Runtime.CompilerServices;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	public AStarNode FarmerAStarNodeOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int x = (int)((Game1.player.position.X + 32f) / 64f);
			int y = (int)((Game1.player.position.Y + 32f) / 64f);
			AStarNode node = FetchAStarNode(x, y);
			if (node == null && Game1.currentLocation is FarmHouse)
				node = FetchNeighbourNodeThatIsPassible(x, y);
			return node;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshBubbles()
	{
		ResetBubbles(true, true);
		if (FarmerAStarNode != null && FarmerAStarNodeOffset != null)
			FarmerAStarNodeOffset.SetBubbleIDRecursively(0, false);
	}
}
