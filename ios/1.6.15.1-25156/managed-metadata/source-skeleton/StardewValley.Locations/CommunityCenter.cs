using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Characters;
using StardewValley.Network;
using StardewValley.Objects;
using xTile;
using xTile.Dimensions;
using xTile.Tiles;

namespace StardewValley.Locations;

public class CommunityCenter : GameLocation
{
	public const int AREA_Pantry = 0;

	public const int AREA_FishTank = 2;

	public const int AREA_CraftsRoom = 1;

	public const int AREA_BoilerRoom = 3;

	public const int AREA_Vault = 4;

	public const int AREA_Bulletin = 5;

	public const int AREA_AbandonedJojaMart = 6;

	public const int AREA_Bulletin2 = 7;

	public const int AREA_JunimoHut = 8;

	[XmlElement("warehouse")]
	private readonly NetBool warehouse;

	[XmlIgnore]
	public List<NetMutex> bundleMutexes;

	public readonly NetArray<bool, NetBool> areasComplete;

	[XmlElement("numberOfStarsOnPlaque")]
	public readonly NetInt numberOfStarsOnPlaque;

	[XmlIgnore]
	private readonly NetEvent0 newJunimoNoteCheckEvent;

	[XmlIgnore]
	private readonly NetEvent1Field<int, NetInt> restoreAreaCutsceneEvent;

	[XmlIgnore]
	private readonly NetEvent1Field<int, NetInt> areaCompleteRewardEvent;

	private float messageAlpha;

	private List<int> junimoNotesViewportTargets;

	private Dictionary<int, List<int>> areaToBundleDictionary;

	private Dictionary<int, int> bundleToAreaDictionary;

	private Dictionary<string, List<List<int>>> bundlesIngredientsInfo;

	private bool _isWatchingJunimoGoodbye;

	private Vector2 missedRewardsChestTile;

	private const string missedRewardsTileSheetId = "indoors2";

	[XmlIgnore]
	public readonly NetRef<Chest> missedRewardsChest;

	[XmlIgnore]
	public readonly NetBool missedRewardsChestVisible;

	[XmlIgnore]
	public readonly NetEvent1Field<bool, NetBool> showMissedRewardsChestEvent;

	public const int PHASE_firstPause = 0;

	public const int PHASE_junimoAppear = 1;

	public const int PHASE_junimoDance = 2;

	public const int PHASE_restore = 3;

	private int restoreAreaTimer;

	private int restoreAreaPhase;

	private int restoreAreaIndex;

	private ICue buildUpSound;

	[XmlElement("bundles")]
	public NetBundles bundles
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlElement("bundleRewards")]
	public NetIntDictionary<bool, NetBool> bundleRewards
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CommunityCenter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CommunityCenter(string map_path, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CommunityCenter(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void refreshBundlesIngredientsInfo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void initAreaBundleConversions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getAreaNumberFromName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Point getNotePosition(int area)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addJunimoNote(int area)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int numberOfCompleteBundles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addStarToPlaque()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getMessageForAreaCompletion()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getNumberOfAreasComplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<int, bool[]> bundlesDict()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rewardGrabbed(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkBundle(int area)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addJunimoNoteViewportTarget(int area)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForNewJunimoNotes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doCheckForNewJunimoNotes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isJunimoNoteAtArea(int area)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool shouldNoteAppearInArea(int area)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doShowMissedRewardsChest(bool isVisible)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkForMissedRewards()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getAreaNumberFromLocation(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Microsoft.Xna.Framework.Rectangle getAreaBounds(int area)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void removeJunimo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforeSave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBundleComplete(int bundleIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool couldThisIngredienteBeUsedInABundle(Object o)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void areaCompleteReward(int whichArea)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doAreaCompleteReward(int whichArea)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadArea(int area, bool showEffects = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addFishTank()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void restoreAreaCutscene(int whichArea)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void markAreaAsComplete(int area)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doRestoreAreaCutscene(int whichArea)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setViewportToNextJunimoNoteTarget()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void afterViewportGetsToJunimoNotePosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Junimo getJunimoForArea(int whichArea)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool areAllAreasComplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void junimoGoodbyeDance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void prepareForJunimoDance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void startGoodbyeDance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void endGoodbyeDance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadJunimoHut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getAreaNameFromNumber(int areaNumber)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getAreaEnglishDisplayNameFromNumber(int areaNumber)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getAreaDisplayNameFromNumber(int areaNumber)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static StaticTile[] getJunimoNoteTileFrames(int area, Map map)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
