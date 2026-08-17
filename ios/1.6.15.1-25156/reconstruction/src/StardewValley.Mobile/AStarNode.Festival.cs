using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	public bool BrokenFestivalTile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if (Game1.CurrentEvent == null)
				return false;

			if (x == 18 && y == 31 && Game1.dayOfMonth == 16 && Game1.currentSeason == "fall")
				return true;
			if (x == 16 && y == 19 && Game1.dayOfMonth == 27 && Game1.currentSeason == "fall")
				return true;
			if (x == 66 && y == 4 && Game1.dayOfMonth == 8 && Game1.currentSeason == "winter")
				return true;
			return x == 103 && y == 28 && Game1.dayOfMonth == 8 && Game1.currentSeason == "winter";
		}
	}
}
