using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;
using StardewValley.ItemTypeDefinitions;
using StardewValley.Network;

namespace StardewValley.Tools;

public class FishingRod : Tool
{
	public const int BaitIndex = 0;

	public const int TackleIndex = 1;

	public const int sizeOfLandCheckRectangle = 11;

	public static int NUM_BOBBER_STYLES;

	[XmlElement("bobber")]
	public readonly NetPosition bobber;

	private readonly NetInt castDirection;

	public static int minFishingBiteTime;

	public static int maxFishingBiteTime;

	public static int maxTimeToNibble;

	public static int maxTackleUses;

	private int whichTackleSlotToReplace;

	protected Vector2 _lastAppliedMotion;

	protected Vector2[] _totalMotionBuffer;

	protected int _totalMotionBufferIndex;

	protected NetVector2 _totalMotion;

	public static double baseChanceForTreasure;

	[XmlIgnore]
	public int bobberBob;

	[XmlIgnore]
	public float bobberTimeAccumulator;

	[XmlIgnore]
	public float timePerBobberBob;

	[XmlIgnore]
	public float timeUntilFishingBite;

	[XmlIgnore]
	public float fishingBiteAccumulator;

	[XmlIgnore]
	public float fishingNibbleAccumulator;

	[XmlIgnore]
	public float timeUntilFishingNibbleDone;

	[XmlIgnore]
	public float castingPower;

	[XmlIgnore]
	public float castingChosenCountdown;

	[XmlIgnore]
	public float castingTimerSpeed;

	[XmlIgnore]
	public bool isFishing;

	[XmlIgnore]
	public bool hit;

	[XmlIgnore]
	public bool isNibbling;

	[XmlIgnore]
	public bool favBait;

	[XmlIgnore]
	public bool isTimingCast;

	[XmlIgnore]
	public bool isCasting;

	[XmlIgnore]
	public bool castedButBobberStillInAir;

	[XmlIgnore]
	public bool gotTroutDerbyTag;

	protected Color? lastWaterColor;

	[XmlIgnore]
	protected bool _hasPlayerAdjustedBobber;

	[XmlIgnore]
	public bool lastCatchWasJunk;

	[XmlIgnore]
	public bool goldenTreasure;

	[XmlIgnore]
	public bool doneWithAnimation;

	[XmlIgnore]
	public bool pullingOutOfWater;

	[XmlIgnore]
	public bool isReeling;

	[XmlIgnore]
	public bool hasDoneFucntionYet;

	[XmlIgnore]
	public bool fishCaught;

	[XmlIgnore]
	public bool recordSize;

	[XmlIgnore]
	public bool treasureCaught;

	[XmlIgnore]
	public bool showingTreasure;

	[XmlIgnore]
	public bool hadBobber;

	[XmlIgnore]
	public bool bossFish;

	[XmlIgnore]
	public bool fromFishPond;

	[XmlIgnore]
	public TemporaryAnimatedSpriteList animations;

	[XmlIgnore]
	public SparklingText sparklingText;

	[XmlIgnore]
	public int fishSize;

	[XmlIgnore]
	public int fishQuality;

	[XmlIgnore]
	public int clearWaterDistance;

	[XmlIgnore]
	public int originalFacingDirection;

	[XmlIgnore]
	public int numberOfFishCaught;

	[XmlIgnore]
	public ItemMetadata whichFish;

	[XmlIgnore]
	public string setFlagOnCatch;

	[XmlIgnore]
	public int recastTimerMs;

	protected const int RECAST_DELAY_MS = 200;

	[XmlIgnore]
	private readonly NetEventBinary pullFishFromWaterEvent;

	[XmlIgnore]
	private readonly NetEvent1Field<bool, NetBool> doneFishingEvent;

	[XmlIgnore]
	private readonly NetEvent0 startCastingEvent;

	[XmlIgnore]
	private readonly NetEvent0 castingEndEnableMovementEvent;

	[XmlIgnore]
	private readonly NetEvent0 putAwayEvent;

	[XmlIgnore]
	private readonly NetEvent0 beginReelingEvent;

	public static ICue chargeSound;

	public static ICue reelSound;

	private int randomBobberStyle;

	[XmlIgnore]
	public bool advancedIridiumRodTackleToggle;

	private bool usedGamePadToCast;

	public int CastDirection
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionWhenStopBeingHeld(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishingRod()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void resetState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishingRod(int upgradeLevel)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishingRod(int upgradeLevel, int numAttachmentSlots)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int getAddedDistance(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 calculateBobberTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getBobberStyle(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool flipCurrentBobberWhenFacingRight()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color getFishingLineColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float calculateTimeUntilFishingBite(Vector2 bobberTile, bool isFirstCast, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color getColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int distanceToLand(int tileX, int tileY, GameLocation location, bool landMustBeAdjacentToWalkableTile = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startMinigameEndFunction(Item fish)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Object> GetTackle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetTackleQualifiedItemIDs()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object GetBait()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasMagicBait()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasCuriosityLure()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool inUse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void donefishingEndFunction(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void endOfAnimationBehavior(Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAttachments(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetAttachmentSlotSprite(int slot, out Texture2D texture, out Rectangle sourceRect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool canThisBeAttached(Object o, int slot)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanUseBait()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanUseTackle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playerCaughtFishEndFunction(bool isBossFish)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void pullFishFromWater(string fishId, int fishSize, int fishQuality, int fishDifficulty, bool treasureCaught, bool wasPerfect, bool fromFishPond, string setFlagOnCatch, bool isBossFish, int numCaught)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doPullFishFromWater(BinaryReader argReader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetWaterColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool beginUsing(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTimingCastAnimation(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doneFishing(Farmer who, bool consumeBaitAndTackle = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doDoneFishing(bool consumeBaitAndTackle)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void doneWithCastingAnimation(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void castingEndFunction(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void castingEndEnableMovement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doCastingEndEnableMovement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void tickUpdate(GameTime time, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doneHoldingFish(Farmer who, bool endOfNight = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Item CreateFish()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void startCasting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void beginReeling()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doStartCasting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void openChestEndFunction(int remainingFish)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void justGotDerbyTagEndFunction(int remainingFish)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool doesShowTileLocationMarker()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void openTreasureMenuEndFunction(int remainingFish)
	{
	}
}
