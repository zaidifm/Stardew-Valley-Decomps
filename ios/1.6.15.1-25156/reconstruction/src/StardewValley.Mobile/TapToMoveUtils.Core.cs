using System.Runtime.CompilerServices;
using StardewValley.Minigames;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	public static GameLocation gameLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if (Game1.currentMinigame != null && Game1.currentMinigame is FishingGame)
				return ((FishingGame)Game1.currentMinigame).location;
			return Game1.currentLocation;
		}
	}

	public static bool inMiniGameWhereWeDontWantTaps
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if (Game1.currentMinigame == null)
				return false;

			return Game1.currentMinigame is AbigailGame
				|| Game1.currentMinigame is FantasyBoardGame
				|| Game1.currentMinigame is GrandpaStory
				|| Game1.currentMinigame is HaleyCowPictures
				|| Game1.currentMinigame is MineCart
				|| Game1.currentMinigame is PlaneFlyBy
				|| Game1.currentMinigame is RobotBlastoff;
		}
	}
}
