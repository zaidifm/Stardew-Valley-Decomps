using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Monsters;
using StardewValley.Network;
using StardewValley.Objects;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class MineShaft : GameLocation
{
	public const int mineFrostLevel = 40;

	public const int mineLavaLevel = 80;

	public const int upperArea = 0;

	public const int jungleArea = 10;

	public const int frostArea = 40;

	public const int lavaArea = 80;

	public const int desertArea = 121;

	public const int bottomOfMineLevel = 120;

	public const int quarryMineShaft = 77377;

	public const int numberOfLevelsPerArea = 40;

	public const int mineFeature_barrels = 0;

	public const int mineFeature_chests = 1;

	public const int mineFeature_coalCart = 2;

	public const int mineFeature_elevator = 3;

	public const double chanceForColoredGemstone = 0.008;

	public const double chanceForDiamond = 0.0005;

	public const double chanceForPrismaticShard = 0.0005;

	public const int monsterLimit = 30;

	public const string MineTileSheetId = "mine";

	public static SerializableDictionary<int, MineInfo> permanentMineChanges;

	public static int numberOfCraftedStairsUsedThisRun;

	public Random mineRandom;

	private LocalizedContentManager mineLoader;

	private int timeUntilElevatorLightUp;

	[XmlIgnore]
	public int loadedMapNumber;

	public int fogTime;

	public NetBool isFogUp;

	public static int timeSinceLastMusic;

	public bool ladderHasSpawned;

	public bool ghostAdded;

	public bool loadedDarkArea;

	public bool isFallingDownShaft;

	public Vector2 fogPos;

	private readonly NetBool elevatorShouldDing;

	public readonly NetString mapImageSource;

	private readonly NetInt netMineLevel;

	private readonly NetIntDelta netStonesLeftOnThisLevel;

	private readonly NetVector2 netTileBeneathLadder;

	private readonly NetVector2 netTileBeneathElevator;

	public readonly NetPoint calicoStatueSpot;

	public readonly NetPoint recentlyActivatedCalicoStatue;

	private readonly NetPoint netElevatorLightSpot;

	private readonly NetBool netIsSlimeArea;

	private readonly NetBool netIsMonsterArea;

	private readonly NetBool netIsTreasureRoom;

	private readonly NetBool netIsDinoArea;

	private readonly NetBool netIsQuarryArea;

	private readonly NetBool netAmbientFog;

	private readonly NetColor netLighting;

	private readonly NetColor netFogColor;

	private readonly NetVector2Dictionary<bool, NetBool> createLadderAtEvent;

	private readonly NetPointDictionary<bool, NetBool> createLadderDownEvent;

	private float fogAlpha;

	[XmlIgnore]
	public static ICue bugLevelLoop;

	public readonly NetBool rainbowLights;

	public readonly NetBool isLightingDark;

	private readonly int? forceLayout;

	private LocalizedContentManager mapContent;

	public static List<MineShaft> activeMines;

	public static HashSet<int> mushroomLevelsGeneratedToday;

	public static int totalCalicoStatuesActivatedToday;

	private int recentCalicoStatueEffect;

	private bool forceFirstTime;

	internal static int deepestLevelOnCurrentDesertFestivalRun;

	private int lastLevelsDownFallen;

	private Microsoft.Xna.Framework.Rectangle fogSource;

	private List<Vector2> brownSpots;

	private int lifespan;

	private bool hasAddedDesertFestivalStatue;

	public float calicoEggIconTimerShake;

	public static int lowestLevelReached
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

	public int mineLevel
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

	public int stonesLeftOnThisLevel
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

	public Vector2 tileBeneathLadder
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

	public Vector2 tileBeneathElevator
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

	public Point ElevatorLightSpot
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

	public bool isSlimeArea
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

	public bool isDinoArea
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

	public bool isMonsterArea
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

	public bool isQuarryArea
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

	public bool ambientFog
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

	public Color lighting
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

	public Color fogColor
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

	public int EnemyCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MineShaft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MineShaft(int level, int? forceLayout = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetLocationContextId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanPlaceThisFurnitureHere(Furniture furniture)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void calicoStatueActivated(NetPoint field, Point oldVector, Point newVector)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void signalCalicoStatueActivation(int whichEffect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool tryToAddCalicoStatueEffect(Random r, double chance, int which, bool effectCanStack = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool AllowMapModificationsInResetState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override LocalizedContentManager getMapLoader()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setElevatorLit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 mineEntrancePosition(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void generateContents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void chooseLevelType()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void yearUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool canAdd(int typeOfFeature, int numberSoFar)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateMineLevelData(int feature, int amount = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void chestConsumed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isLevelSlimeArea()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForMapAlterations(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void findLadder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void spawnFlyingMonsterOffScreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawLightGlows(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monster BuffMonsterIfNecessary(Monster monster)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setMonsterTextureToDangerousVersion(Monster monster)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string locationName = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void adjustLevelChances(ref double stoneChance, ref double monsterChance, ref double itemChance, ref double gemStoneChance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AnyOnlineFarmerHasBuff(string which_buff)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void populateLevel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void placeAppropriateOreAt(Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object getAppropriateOre(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tryToAddOreClumps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tryToAddOldMinerPath()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tryToAddAreaUniques()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tryToAddMonster(Monster m, int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isContainerPlatform(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool mustKillAllMonstersToAdvance()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createLadderAt(Vector2 p, string sound = "hoeHit")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool shouldCreateLadderOnThisLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doCreateLadderAt(Vector2 p)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool recursiveTryToCreateLadderDown(Vector2 centerTile, string sound = "hoeHit", int maxIterations = 16)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void monsterDrop(Monster monster, int x, int y, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetReplacementChestItem(int floor)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addLevelChests()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isForcedChestLevel(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item getTreasureRoomItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item getSpecialItemForThisMineLevel(int level, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLocationSpecificOccupantOnTile(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isDarkArea()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileClearForMineObjects(Vector2 v)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getFootstepSoundReplacement(string footstep)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileOnClearAndSolidGround(Vector2 v)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileOnClearAndSolidGround(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileClearForMineObjects(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadLevel(int level)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addBlueFlamesToChallengeShrine()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckForQiChallengeCompletion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void prepareElevator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void enterMineShaft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void afterFall()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShouldExcludeFromNpcPathfinding()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void checkForMusic(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getMineSong()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAdditionalDifficulty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isPlayingSongFromDifferentArea()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playMineSong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyDiggableTileFixes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createLadderDown(int x, int y, bool forceShaft = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doCreateLadderDown(Point point, bool shaft)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkStoneForItems(string stoneId, int x, int y, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getOreIdForLevel(int mineLevel, Random r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool shouldUseSnowTextureHoeDirt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getMineArea(int level = -1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isSideBranch(int level = -1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte getWallAt(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color getLightingColor(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object getRandomItemForThisLevel(int level, Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool shouldShowDarkHoeDirt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getRandomGemRichStoneForThisLevel(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float getDistanceFromStart(int xTile, int yTile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monster getMonsterForThisLevel(int level, int xTile, int yTile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Object createLitterObject(double chanceForPurpleStone, double chanceForMysticStone, double gemStoneChance, Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnLeftMines()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void clearActiveMines()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void clearInactiveMines(bool keepUntickedLevels = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateMines10Minutes(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateCharacters(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateMines(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRemoved()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLevelName(int level, int? forceLayout = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeneratedLevel(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeneratedLevel(GameLocation location, out int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeneratedLevel(GameLocation location, out int level, out int? forceLayout)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeneratedLevel(string locationName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeneratedLevel(string locationName, out int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeneratedLevel(string locationName, out int level, out int? forceLayout)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MineShaft GetMine(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ForEach(Action<MineShaft> action)
	{
	}
}
