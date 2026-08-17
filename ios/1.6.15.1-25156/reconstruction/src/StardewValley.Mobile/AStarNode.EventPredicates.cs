using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsProp()
	{
		if (Game1.CurrentEvent == null)
			return false;

		for (int i = 0; i < Game1.CurrentEvent.props.Count; i++)
		{
			Object prop = Game1.CurrentEvent.props[i];
			if (prop.TileLocation.X == x && prop.TileLocation.Y == y)
				return true;
		}

		return false;
	}
}
