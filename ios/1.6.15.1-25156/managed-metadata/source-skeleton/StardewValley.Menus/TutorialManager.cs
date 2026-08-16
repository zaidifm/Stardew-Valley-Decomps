using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

internal class TutorialManager : IClickableMenu
{
	private readonly List<TutorialItem> tutorials;

	private readonly int[] tutorialMap;

	public int challengeState;

	internal TutorialItem challengeNotification;

	internal TutorialItem challengeTutorial;

	public bool showTheTutorials;

	public bool hasWateringCanEverEmptied;

	public bool hasUsedWateringCan;

	public bool hasClosedMenu;

	public bool hasOpenedJournalEntry;

	public bool collectionsHasBeenSeen;

	public bool inventoryhasBeenSeen;

	public bool mapHasBeenSeen;

	public bool hasSeenSaleTutorial;

	public bool hasSeenBuyTutorial;

	public bool hasClickedOnSaleTutorial;

	public bool skillsHasBeenSeen;

	public bool socialHasBeenSeen;

	public bool craftingHasBeenSeen;

	public int numberOfThingsCleared;

	public int numberOfTilesHoed;

	public int numberOfSeedsSown;

	private bool hasDoneTapAndHold;

	private bool hasSelectedHoe;

	private bool hasBeenInAShop;

	private bool hasBeenOutside;

	private bool hasMadeAttackChoice;

	public List<TutorialShopLocation> shopLocationsVisited;

	public TutorialItem currentTutorial;

	public static bool menuUp;

	public bool showAttackDialog;

	public DialogueBox attackDialog;

	public DialogueBox challengeDialog;

	private bool _gamePadHasBeenUsed;

	public static TutorialManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool gamePadHasBeenUsed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool ShowingDialogueBox
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool ShowingQuestion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TutorialManager()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TutorialManager()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetBools()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void stopTutorialsTemporarily()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showTutorials(bool toShow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isInDialogBounds(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TutorialItem Register(TutorialType tutType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TutorialItem GetTutorial(TutorialType tutType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasTutorialBeenShown(TutorialType tut)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadCompletedTutorials(List<TutorialType> tuts)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<TutorialType> getCompletedTutorialsList()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTutorialComplete(TutorialType tut)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void completeAllTutorials()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void completeAllBasicTutorials()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool completeTutorial(TutorialType tut)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool dontAllowExit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkPrerequisites(TutorialItem t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkIgnores(TutorialItem t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool HandleAttackDialogueResponse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string FilterLocationName(string locationName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<string, List<NPC>> GetAllNpcsFromLocations(params string[] locationNames)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string DefaultPositionString(Dictionary<string, List<NPC>> npcs)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string ChangeLocation(string locationName, Dictionary<string, List<NPC>> npcs)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool HandleChallengeDialogueResponse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool ShouldExitTutorial(TutorialItem item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartLinkedChallengeCheck()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawUI(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawButtonHands(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initializeStartTutorials()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initializeTutorials()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TestForHoeSelected()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckTapAndHold()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SeenShop(TutorialShopLocation shopLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool shouldShowAttackDialog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool shouldShowChallengeDialog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void triggerAttackChoice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChallengeChoiceCheck()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaleTutorialCheck()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MeleeWeaponCheck()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TapLeaveHouseCheck()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DummyInteractShopCheck()
	{
	}
}
