using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;
using StardewValley.BellsAndWhistles;
using StardewValley.Buffs;
using StardewValley.Characters;
using StardewValley.Companions;
using StardewValley.Enchantments;
using StardewValley.Inventories;
using StardewValley.Menus;
using StardewValley.Minigames;
using StardewValley.Monsters;
using StardewValley.Network;
using StardewValley.Objects;
using StardewValley.Objects.Trinkets;
using StardewValley.Quests;
using StardewValley.Util;
using xTile.Dimensions;

namespace StardewValley;

public class Farmer : Character, IComparable
{
	public class EmoteType
	{
		public string emoteString;

		public int emoteIconIndex;

		public FarmerSprite.AnimationFrame[] animationFrames;

		public bool hidden;

		public int facingDirection;

		public string displayNameKey;

		public string displayName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteType(string emote_string = "", string display_name_key = "", int icon_index = -1, FarmerSprite.AnimationFrame[] frames = null, int facing_direction = 2, bool is_hidden = false)
		{
		}
	}

	public const int millisecondsPerSpeedUnit = 64;

	public const byte halt = 64;

	public const byte up = 1;

	public const byte right = 2;

	public const byte down = 4;

	public const byte left = 8;

	public const byte run = 16;

	public const byte release = 32;

	public const int farmingSkill = 0;

	public const int miningSkill = 3;

	public const int fishingSkill = 1;

	public const int foragingSkill = 2;

	public const int combatSkill = 4;

	public const int luckSkill = 5;

	public const float interpolationConstant = 0.5f;

	public const int runningSpeed = 5;

	public const int walkingSpeed = 2;

	public const int caveNothing = 0;

	public const int caveBats = 1;

	public const int caveMushrooms = 2;

	public const int millisecondsInvincibleAfterDamage = 1200;

	public const int millisecondsPerFlickerWhenInvincible = 50;

	public const int startingStamina = 270;

	public const int totalLevels = 35;

	public const int maxInventorySpace = 36;

	public const int hotbarSize = 12;

	public const int eyesOpen = 0;

	public const int eyesHalfShut = 4;

	public const int eyesClosed = 1;

	public const int eyesRight = 2;

	public const int eyesLeft = 3;

	public const int eyesWide = 5;

	public const int rancher = 0;

	public const int tiller = 1;

	public const int butcher = 2;

	public const int shepherd = 3;

	public const int artisan = 4;

	public const int agriculturist = 5;

	public const int fisher = 6;

	public const int trapper = 7;

	public const int angler = 8;

	public const int pirate = 9;

	public const int baitmaster = 10;

	public const int mariner = 11;

	public const int forester = 12;

	public const int gatherer = 13;

	public const int lumberjack = 14;

	public const int tapper = 15;

	public const int botanist = 16;

	public const int tracker = 17;

	public const int miner = 18;

	public const int geologist = 19;

	public const int blacksmith = 20;

	public const int burrower = 21;

	public const int excavator = 22;

	public const int gemologist = 23;

	public const int fighter = 24;

	public const int scout = 25;

	public const int brute = 26;

	public const int defender = 27;

	public const int acrobat = 28;

	public const int desperado = 29;

	public static int MaximumTrinkets;

	public readonly NetObjectList<Quest> questLog;

	public readonly NetIntHashSet professions;

	public readonly NetList<Point, NetPoint> newLevels;

	[XmlIgnore]
	public Queue<int> newLevelSparklingTexts;

	[XmlIgnore]
	public SparklingText sparklingText;

	public readonly NetArray<int, NetInt> experiencePoints;

	[XmlElement("items")]
	public readonly NetRef<Inventory> netItems;

	[XmlArrayItem("int")]
	public readonly NetStringHashSet dialogueQuestionsAnswered;

	[XmlElement("cookingRecipes")]
	public readonly NetStringDictionary<int, NetInt> cookingRecipes;

	[XmlElement("craftingRecipes")]
	public readonly NetStringDictionary<int, NetInt> craftingRecipes;

	[XmlElement("activeDialogueEvents")]
	public readonly NetStringDictionary<int, NetInt> activeDialogueEvents;

	[XmlElement("previousActiveDialogueEvents")]
	public readonly NetStringDictionary<int, NetInt> previousActiveDialogueEvents;

	public readonly NetStringHashSet triggerActionsRun;

	[XmlArrayItem("int")]
	public readonly NetStringHashSet eventsSeen;

	public readonly NetIntHashSet secretNotesSeen;

	public HashSet<string> songsHeard;

	public readonly NetIntHashSet achievements;

	[XmlArrayItem("int")]
	public readonly NetStringList specialItems;

	[XmlArrayItem("int")]
	public readonly NetStringList specialBigCraftables;

	public readonly NetStringHashSet mailReceived;

	public readonly NetStringHashSet mailForTomorrow;

	public readonly NetStringList mailbox;

	public readonly NetStringHashSet locationsVisited;

	public readonly NetInt timeWentToBed;

	[XmlIgnore]
	public readonly NetList<Companion, NetRef<Companion>> companions;

	[XmlIgnore]
	public bool hasMoved;

	[XmlIgnore]
	public bool hasBeenBlessedByStatueToday;

	public readonly NetBool sleptInTemporaryBed;

	[XmlIgnore]
	public readonly NetBool requestingTimePause;

	public Stats stats;

	[XmlIgnore]
	public readonly NetRef<Inventory> personalShippingBin;

	[XmlIgnore]
	public IList<Item> displayedShippedItems;

	[XmlElement("biteChime")]
	public NetInt biteChime;

	[XmlIgnore]
	public float usernameDisplayTime;

	[XmlIgnore]
	protected NetRef<Item> _recoveredItem;

	public NetObjectList<Item> itemsLostLastDeath;

	public List<int> movementDirections;

	[XmlElement("farmName")]
	public readonly NetString farmName;

	[XmlElement("favoriteThing")]
	public readonly NetString favoriteThing;

	[XmlElement("horseName")]
	public readonly NetString horseName;

	public string slotName;

	public bool slotCanHost;

	[XmlIgnore]
	public readonly NetString tempFoodItemTextureName;

	[XmlIgnore]
	public readonly NetRectangle tempFoodItemSourceRect;

	[XmlIgnore]
	public bool hasReceivedToolUpgradeMessageYet;

	[XmlIgnore]
	public readonly BuffManager buffs;

	[XmlIgnore]
	public IList<OutgoingMessage> messageQueue;

	[XmlIgnore]
	public readonly NetLong uniqueMultiplayerID;

	[XmlElement("userID")]
	public readonly NetString userID;

	[XmlIgnore]
	public string previousLocationName;

	[XmlIgnore]
	public readonly NetString platformType;

	[XmlIgnore]
	public readonly NetString platformID;

	[XmlIgnore]
	public readonly NetBool hasMenuOpen;

	[XmlIgnore]
	public readonly Color DEFAULT_SHIRT_COLOR;

	public string defaultChatColor;

	[XmlElement("catPerson")]
	public bool? obsolete_catPerson;

	[XmlElement("canUnderstandDwarves")]
	public bool? obsolete_canUnderstandDwarves;

	[XmlElement("hasClubCard")]
	public bool? obsolete_hasClubCard;

	[XmlElement("hasDarkTalisman")]
	public bool? obsolete_hasDarkTalisman;

	[XmlElement("hasMagicInk")]
	public bool? obsolete_hasMagicInk;

	[XmlElement("hasMagnifyingGlass")]
	public bool? obsolete_hasMagnifyingGlass;

	[XmlElement("hasRustyKey")]
	public bool? obsolete_hasRustyKey;

	[XmlElement("hasSkullKey")]
	public bool? obsolete_hasSkullKey;

	[XmlElement("hasSpecialCharm")]
	public bool? obsolete_hasSpecialCharm;

	[XmlElement("HasTownKey")]
	public bool? obsolete_hasTownKey;

	[XmlElement("hasUnlockedSkullDoor")]
	public bool? obsolete_hasUnlockedSkullDoor;

	[XmlElement("friendships")]
	public SerializableDictionary<string, int[]> obsolete_friendships;

	[XmlElement("daysMarried")]
	public int? obsolete_daysMarried;

	public string whichPetType;

	public string whichPetBreed;

	[XmlIgnore]
	public bool isAnimatingMount;

	[XmlElement("acceptedDailyQuest")]
	public readonly NetBool acceptedDailyQuest;

	[XmlIgnore]
	public Item mostRecentlyGrabbedItem;

	[XmlIgnore]
	public Item itemToEat;

	[XmlElement("farmerRenderer")]
	private readonly NetRef<FarmerRenderer> farmerRenderer;

	[XmlIgnore]
	public readonly NetInt toolPower;

	[XmlIgnore]
	public readonly NetInt toolHold;

	public Vector2 mostRecentBed;

	public static Dictionary<int, string> hairStyleMetadataFile;

	public static List<int> allHairStyleIndices;

	[XmlIgnore]
	public static Dictionary<int, HairStyleMetadata> hairStyleMetadata;

	[XmlElement("emoteFavorites")]
	public readonly List<string> emoteFavorites;

	[XmlElement("performedEmotes")]
	public readonly SerializableDictionary<string, bool> performedEmotes;

	[XmlElement("shirt")]
	public readonly NetString shirt;

	[XmlElement("hair")]
	public readonly NetInt hair;

	[XmlElement("skin")]
	public readonly NetInt skin;

	[XmlElement("shoes")]
	public readonly NetString shoes;

	[XmlElement("accessory")]
	public readonly NetInt accessory;

	[XmlElement("facialHair")]
	public readonly NetInt facialHair;

	[XmlElement("pants")]
	public readonly NetString pants;

	[XmlIgnore]
	public int currentEyes;

	[XmlIgnore]
	public int blinkTimer;

	[XmlIgnore]
	public readonly NetInt netFestivalScore;

	public readonly NetRef<WorldDate> lastGotPrizeFromGil;

	public readonly NetRef<WorldDate> lastDesertFestivalFishingQuest;

	[XmlIgnore]
	public float temporarySpeedBuff;

	[XmlElement("hairstyleColor")]
	public readonly NetColor hairstyleColor;

	[XmlIgnore]
	public NetBool prismaticHair;

	[XmlElement("pantsColor")]
	public readonly NetColor pantsColor;

	[XmlElement("newEyeColor")]
	public readonly NetColor newEyeColor;

	[XmlElement("hat")]
	public readonly NetRef<Hat> hat;

	[XmlElement("boots")]
	public readonly NetRef<Boots> boots;

	[XmlElement("leftRing")]
	public readonly NetRef<Ring> leftRing;

	[XmlElement("rightRing")]
	public readonly NetRef<Ring> rightRing;

	[XmlElement("shirtItem")]
	public readonly NetRef<Clothing> shirtItem;

	[XmlElement("pantsItem")]
	public readonly NetRef<Clothing> pantsItem;

	[XmlIgnore]
	public readonly NetDancePartner dancePartner;

	[XmlIgnore]
	public bool ridingMineElevator;

	[XmlIgnore]
	public readonly NetBool exhausted;

	[XmlElement("divorceTonight")]
	public readonly NetBool divorceTonight;

	[XmlElement("changeWalletTypeTonight")]
	public readonly NetBool changeWalletTypeTonight;

	[XmlIgnore]
	public AnimatedSprite.endOfAnimationBehavior toolOverrideFunction;

	[XmlIgnore]
	public NetBool onBridge;

	[XmlIgnore]
	public SuspensionBridge bridge;

	private readonly NetInt netDeepestMineLevel;

	[XmlElement("currentToolIndex")]
	private readonly NetInt currentToolIndex;

	[XmlIgnore]
	private readonly NetRef<Item> temporaryItem;

	[XmlIgnore]
	private readonly NetRef<Item> cursorSlotItem;

	[XmlIgnore]
	public readonly NetBool netItemStowed;

	protected bool _itemStowed;

	public string gameVersion;

	public string gameVersionLabel;

	[XmlIgnore]
	public bool isFakeEventActor;

	[XmlElement("bibberstyke")]
	public readonly NetInt bobberStyle;

	public bool usingRandomizedBobber;

	[XmlElement("caveChoice")]
	public readonly NetInt caveChoice;

	[XmlElement("farmingLevel")]
	public readonly NetInt farmingLevel;

	[XmlElement("miningLevel")]
	public readonly NetInt miningLevel;

	[XmlElement("combatLevel")]
	public readonly NetInt combatLevel;

	[XmlElement("foragingLevel")]
	public readonly NetInt foragingLevel;

	[XmlElement("fishingLevel")]
	public readonly NetInt fishingLevel;

	[XmlElement("luckLevel")]
	public readonly NetInt luckLevel;

	[XmlElement("maxStamina")]
	public readonly NetInt maxStamina;

	[XmlElement("maxItems")]
	public readonly NetInt maxItems;

	[XmlElement("lastSeenMovieWeek")]
	public readonly NetInt lastSeenMovieWeek;

	[XmlIgnore]
	public readonly NetString viewingLocation;

	private readonly NetFloat netStamina;

	[XmlIgnore]
	public bool ignoreItemConsumptionThisFrame;

	[XmlIgnore]
	[NotNetField]
	public NetRoot<FarmerTeam> teamRoot;

	public int clubCoins;

	public int trashCanLevel;

	private NetLong netMillisecondsPlayed;

	[XmlElement("toolBeingUpgraded")]
	public readonly NetRef<Tool> toolBeingUpgraded;

	[XmlElement("daysLeftForToolUpgrade")]
	public readonly NetInt daysLeftForToolUpgrade;

	[XmlElement("houseUpgradeLevel")]
	public readonly NetInt houseUpgradeLevel;

	[XmlElement("daysUntilHouseUpgrade")]
	public readonly NetInt daysUntilHouseUpgrade;

	public bool showChestColorPicker;

	public bool hasWateringCanEnchantment;

	[XmlIgnore]
	public List<BaseEnchantment> enchantments;

	public readonly int BaseMagneticRadius;

	public int temporaryInvincibilityTimer;

	public int currentTemporaryInvincibilityDuration;

	[XmlIgnore]
	public float rotation;

	private int craftingTime;

	private int raftPuddleCounter;

	private int raftBobCounter;

	public int health;

	public int maxHealth;

	private readonly NetInt netTimesReachedMineBottom;

	public float difficultyModifier;

	[XmlIgnore]
	public Vector2 jitter;

	[XmlIgnore]
	public Vector2 lastPosition;

	[XmlIgnore]
	public Vector2 lastGrabTile;

	[XmlIgnore]
	public float jitterStrength;

	[XmlIgnore]
	public float xOffset;

	[XmlElement("gender")]
	public readonly NetEnum<Gender> netGender;

	[XmlIgnore]
	public bool canMove;

	[XmlIgnore]
	public bool running;

	[XmlIgnore]
	public bool ignoreCollisions;

	[XmlIgnore]
	public readonly NetBool usingTool;

	[XmlIgnore]
	public bool isEating;

	[XmlIgnore]
	public readonly NetBool isInBed;

	[XmlIgnore]
	public bool forceTimePass;

	[XmlIgnore]
	public bool isRafting;

	[XmlIgnore]
	public bool usingSlingshot;

	[XmlIgnore]
	public readonly NetBool bathingClothes;

	[XmlIgnore]
	public bool canOnlyWalk;

	[XmlIgnore]
	public bool temporarilyInvincible;

	[XmlIgnore]
	public bool flashDuringThisTemporaryInvincibility;

	private readonly NetBool netCanReleaseTool;

	[XmlIgnore]
	public bool isCrafting;

	[XmlIgnore]
	public bool isEmoteAnimating;

	[XmlIgnore]
	public bool passedOut;

	[XmlIgnore]
	protected int _emoteGracePeriod;

	[XmlIgnore]
	private BoundingBoxGroup temporaryPassableTiles;

	[XmlIgnore]
	public readonly NetBool hidden;

	[XmlElement("basicShipped")]
	public readonly NetStringDictionary<int, NetInt> basicShipped;

	[XmlElement("mineralsFound")]
	public readonly NetStringDictionary<int, NetInt> mineralsFound;

	[XmlElement("recipesCooked")]
	public readonly NetStringDictionary<int, NetInt> recipesCooked;

	[XmlElement("fishCaught")]
	public readonly NetStringIntArrayDictionary fishCaught;

	[XmlElement("archaeologyFound")]
	public readonly NetStringIntArrayDictionary archaeologyFound;

	[XmlElement("callsReceived")]
	public readonly NetStringDictionary<int, NetInt> callsReceived;

	public SerializableDictionary<string, SerializableDictionary<string, int>> giftedItems;

	[XmlElement("tailoredItems")]
	public readonly NetStringDictionary<int, NetInt> tailoredItems;

	[XmlElement("friendshipData")]
	public readonly NetStringDictionary<Friendship, NetRef<Friendship>> friendshipData;

	[XmlIgnore]
	public NetString locationBeforeForcedEvent;

	[XmlIgnore]
	public Vector2 positionBeforeEvent;

	[XmlIgnore]
	public int orientationBeforeEvent;

	[XmlIgnore]
	public int swimTimer;

	[XmlIgnore]
	public int regenTimer;

	[XmlIgnore]
	public int timerSinceLastMovement;

	[XmlIgnore]
	public int noMovementPause;

	[XmlIgnore]
	public int freezePause;

	[XmlIgnore]
	public float yOffset;

	protected readonly NetString netSpouse;

	public string dateStringForSaveGame;

	public int? dayOfMonthForSaveGame;

	public int? seasonForSaveGame;

	public int? yearForSaveGame;

	[XmlIgnore]
	public Vector2 armOffset;

	[XmlIgnore]
	public readonly NetRef<Horse> netMount;

	[XmlIgnore]
	public ISittable sittingFurniture;

	[XmlIgnore]
	public NetBool isSitting;

	[XmlIgnore]
	public NetVector2 mapChairSitPosition;

	[XmlIgnore]
	public NetBool hasCompletedAllMonsterSlayerQuests;

	[XmlIgnore]
	public bool isStopSitting;

	[XmlIgnore]
	protected bool _wasSitting;

	[XmlIgnore]
	public Vector2 lerpStartPosition;

	[XmlIgnore]
	public Vector2 lerpEndPosition;

	[XmlIgnore]
	public float lerpPosition;

	[XmlIgnore]
	public float lerpDuration;

	[XmlIgnore]
	protected Item _lastSelectedItem;

	[XmlIgnore]
	protected internal Tool _lastEquippedTool;

	[XmlElement("qiGems")]
	public NetIntDelta netQiGems;

	[XmlElement("JOTPKProgress")]
	public NetRef<AbigailGame.JOTPKProgress> jotpkProgress;

	[XmlIgnore]
	public NetBool hasUsedDailyRevive;

	[XmlElement("trinketItem")]
	public readonly NetList<Trinket, NetRef<Trinket>> trinketItems;

	private readonly NetEvent0 fireToolEvent;

	private readonly NetEvent0 beginUsingToolEvent;

	private readonly NetEvent0 endUsingToolEvent;

	private readonly NetEvent0 sickAnimationEvent;

	private readonly NetEvent0 passOutEvent;

	private readonly NetEvent0 haltAnimationEvent;

	private readonly NetEvent1Field<Object, NetRef<Object>> drinkAnimationEvent;

	private readonly NetEvent1Field<Object, NetRef<Object>> eatAnimationEvent;

	private readonly NetEvent1Field<string, NetString> doEmoteEvent;

	private readonly NetEvent1Field<long, NetLong> kissFarmerEvent;

	private readonly NetEvent1Field<float, NetFloat> synchronizedJumpEvent;

	public readonly NetEvent1Field<string, NetString> renovateEvent;

	[XmlElement("chestConsumedLevels")]
	public readonly NetIntDictionary<bool, NetBool> chestConsumedMineLevels;

	public int saveTime;

	[XmlIgnore]
	public float drawLayerDisambiguator;

	[XmlElement("isCustomized")]
	public readonly NetBool isCustomized;

	[XmlElement("homeLocation")]
	public readonly NetString homeLocation;

	[XmlElement("lastSleepLocation")]
	public readonly NetString lastSleepLocation;

	[XmlElement("lastSleepPoint")]
	public readonly NetPoint lastSleepPoint;

	[XmlElement("disconnectDay")]
	public readonly NetInt disconnectDay;

	[XmlElement("disconnectLocation")]
	public readonly NetString disconnectLocation;

	[XmlElement("disconnectPosition")]
	public readonly NetVector2 disconnectPosition;

	public static readonly EmoteType[] EMOTES;

	[XmlIgnore]
	public int emoteFacingDirection;

	private int toolPitchAccumulator;

	[XmlIgnore]
	public readonly NetInt toolHoldStartTime;

	private int charactercollisionTimer;

	private NPC collisionNPC;

	public float movementMultiplier;

	public bool hasVisibleQuests
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Item recoveredItem
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

	[XmlElement("isMale")]
	public bool? obsolete_isMale
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

	[XmlIgnore]
	public bool catPerson
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int festivalScore
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

	public int deepestMineLevel
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

	public float stamina
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

	[XmlIgnore]
	public FarmerTeam team
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public uint totalMoneyEarned
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

	public ulong millisecondsPlayed
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

	[XmlIgnore]
	public bool canUnderstandDwarves
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

	[XmlIgnore]
	public bool hasClubCard
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

	[XmlIgnore]
	public bool hasDarkTalisman
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

	[XmlIgnore]
	public bool hasMagicInk
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

	[XmlIgnore]
	public bool hasMagnifyingGlass
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

	[XmlIgnore]
	public bool hasRustyKey
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

	[XmlIgnore]
	public bool hasSkullKey
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

	[XmlIgnore]
	public bool hasSpecialCharm
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

	[XmlIgnore]
	public bool HasTownKey
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

	[XmlIgnore]
	public bool hasUnlockedSkullDoor
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

	[XmlIgnore]
	public bool hasPendingCompletedQuests
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlElement("useSeparateWallets")]
	public bool useSeparateWallets
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

	[XmlElement("theaterBuildDate")]
	public long theaterBuildDate
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

	public int timesReachedMineBottom
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

	[XmlIgnore]
	public bool canReleaseTool
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

	[XmlElement("spouse")]
	public string spouse
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

	[XmlIgnore]
	public bool isUnclaimedFarmhand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public Horse mount
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

	[XmlIgnore]
	public int MaxItems
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

	[XmlIgnore]
	public int Level
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int FarmingLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int MiningLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int CombatLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int ForagingLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int FishingLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int LuckLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public double DailyLuck
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int HouseUpgradeLevel
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

	[XmlIgnore]
	public BoundingBoxGroup TemporaryPassableTiles
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

	[XmlIgnore]
	public Inventory Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int MagneticRadius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public Item ActiveItem
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

	[XmlIgnore]
	public Object ActiveObject
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

	[XmlIgnore]
	public override Gender Gender
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

	[XmlIgnore]
	public bool IsMale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public ISet<string> DialogueQuestionsAnswered
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public bool CanMove
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

	[XmlIgnore]
	public bool UsingTool
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

	[XmlIgnore]
	public Tool CurrentTool
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

	[XmlIgnore]
	public Item TemporaryItem
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

	public Item CursorSlotItem
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

	[XmlIgnore]
	public Item CurrentItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int CurrentToolIndex
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

	[XmlIgnore]
	public float Stamina
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

	[XmlIgnore]
	public int MaxStamina
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int Attack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int Immunity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public override float addedSpeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Player speed can't be changed directly. You can add a speed buff via applyBuff instead (and optionally mark it invisible).")]
		set
		{
		}
	}

	public long UniqueMultiplayerID
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

	[XmlIgnore]
	public bool IsLocalPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public bool IsMainPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public bool IsDedicatedPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public override AnimatedSprite Sprite
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

	[XmlIgnore]
	public FarmerSprite FarmerSprite
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

	[XmlIgnore]
	public FarmerRenderer FarmerRenderer
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

	[XmlElement("money")]
	public int _money
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

	[XmlIgnore]
	public int QiGems
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

	[XmlIgnore]
	public int Money
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

	public override int FacingDirection
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
	public void addUnearnedMoney(int money)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetEmoteFavorites()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer(FarmerSprite sprite, Vector2 position, int speed, string name, List<Item> initialTools, bool isMale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void farmerInit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWarp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Trinket getFirstTrinketWithID(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasTrinketWithID(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetAllTrinketEffects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyAllTrinketEffects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UnapplyAllTrinketEffects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTrinketArrayReplaced(NetList<Trinket, NetRef<Trinket>> list, IList<Trinket> before, IList<Trinket> after)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTrinketChange(NetList<Trinket, NetRef<Trinket>> list, int index, Trinket old_value, Trinket new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanEmote()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LearnDefaultRecipes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddMissedMailAndRecipes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performRenovation(string location_name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performPlayerEmote(string emote_string)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldHandleAnimationSound()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Item> initialTools()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playHarpEmoteSound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void removeLowestUpgradeLevelTool(List<Item> items, Type toolType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeInitialTools(List<Item> items)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getMailboxPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearBuffs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isActive()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setInventory(List<Item> newInventory)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void makeThisTheActiveObject(Object o)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getNumberOfChildren()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setMount(Horse mount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isRidingHorse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Child> getChildren()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getChildrenCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Tool getToolFromName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetMovingDown(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetMovingRight(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetMovingUp(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetMovingLeft(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int? tryGetFriendshipLevelForNPC(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getFriendshipLevelForNPC(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getFriendshipHeartLevelForNPC(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isRoommate(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasCurrentOrPendingRoommate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasRoommate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasAFriendWithFriendshipPoints(int minPoints, bool datablesOnly, int maxPoints = int.MaxValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasAFriendWithHeartLevel(int minHeartLevel, bool datablesOnly, int maxHeartLevel = int.MaxValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shippedBasic(string itemId, int number)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shiftToolbar(bool right)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void foundWalnut(int stack = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveMail(string mail_key, bool from_broadcast_list = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void showNutPickup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void foundArtifact(string itemId, int number)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void cookedRecipe(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool caughtFish(string itemId, int size, bool from_fish_pond = false, int numberCaught = 1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void gainExperience(int which, int howMuch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getEffectiveSkillLevel(int whichSkill)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int checkForLevelGain(int oldXP, int newXP)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getBaseExperienceForLevel(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void revealGiftTaste(string npcName, string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void onGiftGiven(NPC npc, Object item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasGiftTasteBeenRevealed(NPC npc, string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasItemBeenGifted(NPC npc, string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkItemAsTailored(Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasTailoredThisItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void foundMineral(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void increaseBackpackSize(int howMuch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Most code should use Items.CountId instead. However this method works a bit differently in that the item ID can be 858 (Qi Gems), 73 (Golden Walnuts), a category number, or -777 to match seasonal wild seeds.")]
	public int getItemCount(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasItemInInventoryNamed(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int howManyOfItemInInventory(int itemIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int howManyOfItemInList(IList<Item> list, int itemIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Most code should use Items.CountId instead. However this method works a bit differently in that the item ID can be a category number, or -777 to match seasonal wild seeds.")]
	public int getItemCountInList(IList<Item> list, string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int LoseItemsOnDeath(Random random = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowSitting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showRiding()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showCarrying()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showNotCarrying()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDaysMarried()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Friendship GetSpouseFriendship()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasDailyQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showToolUpgradeAvailability()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void dayupdate(int timeWentToSleep)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasSeenActiveDialogueEvent(string eventName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool autoGenerateActiveDialogueEvent(string eventName, int duration = 4)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeDatingActiveDialogueEvents(string npcName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeMarriageActiveDialogueEvents(string npcName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeActiveDialogMemoryEvents(string activeDialogKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doDivorce()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showReceiveNewItemMessage(Farmer who, Item item, int countAdded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showEatingItem(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void eatItem(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasBuff(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void applyBuff(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void applyBuff(Buff buff)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasBuffWithNameContainingString(string idSubstr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasOrWillReceiveMail(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showHoldingItem(Farmer who, Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void holdUpItemThenMessage(Item item, bool showMessage = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void holdUpItemThenMessage(Item item, int countAdded, bool showMessage = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetItemStates()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void clearBackpack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int numberOfItemsInInventory()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int numberOfItemsInInventory<T>() where T : Item
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetFriendshipsForNewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetAppliedMagneticRadius()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateFriendshipGifts(WorldDate date)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasPlayerTalkedToNPC(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fuelLantern(int units)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEquippedItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<Item> GetEquippedItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool collideWith(Object o)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeIntoSwimsuit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeOutOfSwimSuit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showFrame(int frame, bool flip = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void stopShowingFrame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item addItemToInventory(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item addItemToInventory(Item item, List<Item> affected_items_list)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item addItemToInventory(Item item, int position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool addItemToInventoryBool(Item item, bool makeActiveObject = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addItemByMenuIfNecessaryElseHoldUp(Item item, ItemGrabMenu.behaviorOnItemSelect itemSelectedCallback = null, bool forceQueue = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addItemByMenuIfNecessary(Item item, ItemGrabMenu.behaviorOnItemSelect itemSelectedCallback = null, bool forceQueue = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addItemsByMenuIfNecessary(List<Item> itemsToAdd, ItemGrabMenu.behaviorOnItemSelect itemSelectedCallback = null, bool forceQueue = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeginSitting(ISittable furniture)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LerpPosition(Vector2 start_position, Vector2 end_position, float duration)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopSitting(bool animate = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SortSeatExitPositions(List<Vector2> list, Vector2 a, Vector2 b, Vector2 c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsSitting()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isInventoryFull()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool couldInventoryAcceptThisItem(Item item, bool message_if_full = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool couldInventoryAcceptThisItem(string id, int stack, int quality = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC getSpouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int freeSpotsInInventory()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetItemReceiveBehavior(Item item, out bool needsInventorySpace, out bool showNotification)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool fakeAddItemToInventoryBool(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnItemReceived(Item item, int countAdded, Item mergedIntoStack, bool hideHudNotification = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowItemReceivedHudMessageIfNeeded(Item item, int countAdded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowItemReceivedHudMessage(Item item, int countAdded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getIndexOfInventoryItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reduceActiveItemByOne()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReequipEnchantments()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeItemFromInventory(Item which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isMarriedOrRoommates()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isEngaged()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeFirstOfThisItemFromInventory(string itemId, int count = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void rotateShirt(int direction, List<string> validIds = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeShirt(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int rotatePantStyle(int direction, List<string> validIds = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changePantStyle(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConvertClothingOverrideToClothesItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<int, string> GetHairStyleMetadataFile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HairStyleMetadata GetHairStyleMetadata(int hair_index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<int> GetAllHairstyleIndices()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetLastHairStyle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeHairStyle(int whichHair)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsBaldHairStyle(int style)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isBald()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeShoeColor(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeHairColor(Color c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changePantsColor(Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeHat(int newHat)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeAccessory(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeSkinColor(int which, bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool hasDarkSkin()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeEyeColor(Color c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getHair(bool ignore_hat = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeGender(bool male)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeFriendship(int amount, NPC n)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool knowsRecipe(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getUniformPositionAwayFromBox(int direction, int distance)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasTalkedToFriendToday(string npcName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void talkToFriend(NPC n, int friendshipPointChange = 20)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void moveRaft(GameLocation currentLocation, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void warpFarmer(Warp w, int warp_collide_direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void warpFarmer(Warp w)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startToPassOut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performPassOut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void passOutFromTired(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void performPassoutWarp(Farmer who, string bed_location_name, Point bed_point, bool has_bed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void doSleepEmote(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Microsoft.Xna.Framework.Rectangle GetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getPetName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pet getPet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getPetDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasPet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateClothing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOverridingPants(out string id, out Color? color)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanDyePants()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetDisplayPants(out Texture2D texture, out int spriteIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetPantsId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPantsIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOverridingShirt(out string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanDyeShirt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetDisplayShirt(out Texture2D texture, out int spriteIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetShirtId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetShirtIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShirtHasSleeves()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetShirtColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetPantsColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool movedDuringLastTick()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(object obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetOnBridge(bool val)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float getDrawLayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawUsername(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drinkGlug(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void handleDisconnect()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isDivorced()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void wipeExMemories()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void getRidOfChildren()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animateOnce(int whichAnimation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showItemIntake(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void showSwordSwipe(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showToolSwipeEffect(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void canMoveNow(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FireTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void synchronizedJump(float velocity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void performSynchronizedJump(float velocity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performFireTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void useTool(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeginUsingTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performBeginUsingTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndUsingTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performEndUsingTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForExhaustion(float oldStamina)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setMoving(byte command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void toolPowerIncrease()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateIfOtherPlayer(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TItem Equip<TItem>(TItem newItem, NetRef<TItem> slot) where TItem : Item
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Equip<TItem>(TItem oldItem, TItem newItem, Action<TItem> equip) where TItem : Item
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void forceCanMove()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void dropItem(Item i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool addEvent(string eventName, int daysActive)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getMostRecentMovementVector()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSkillLevel(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetUnmodifiedSkillLevel(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillNameFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getSkillNumberFromName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool setSkillLevel(string nameOfSkill, int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillDisplayNameFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasCompletedCommunityCenter()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool localBusMoving()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBeDamaged()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void takeDamage(int damage, bool overrideParry, Monster damager)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEffectsOfRingMultiplier(string ringId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkDamage(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkAction(Farmer who, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateCommon(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsBusyDoingSomething()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateItemStow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addQuest(string questId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeQuest(string questID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void completeQuest(string questID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasQuest(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasNewQuestActivity()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float getMovementSpeed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isWearingRing(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getNumberOfWornRingsWithID(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Halt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void stopJittering()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Microsoft.Xna.Framework.Rectangle nextPosition(int direction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Microsoft.Xna.Framework.Rectangle nextPositionHalf(int direction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getProfessionForSkill(int skillType, int skillLevel)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void behaviorOnMovement(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEmoteAnimationEnd(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndEmoteAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void broadcastHaltAnimation(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performHaltAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performKissFarmer(long otherPlayerID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PerformKiss(int facingDirection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MovePosition(GameTime time, xTile.Dimensions.Rectangle viewport, GameLocation currentLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canStrafeForToolUse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool MovePositionImpl(int direction, float movementSpeedX, float movementSpeedY, GameTime time, xTile.Dimensions.Rectangle viewport)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateMovementAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCarrying()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doneEating()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool NotifyQuests(Func<Quest, bool> check, bool onlyOneQuest = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddCompanion(Companion companion)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveCompanion(Companion companion)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void completelyStopAnimating(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void completelyStopAnimatingOrDoingAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doEmote(int whichEmote)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performTenMinuteUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setRunning(bool isRunning, bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addSeenResponse(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void eatObject(Object o, bool overrideFullness = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DrawShadow(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performDrinkAnimation(Object item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer CreateFakeEventFarmer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performEatAnimation(Object item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void netDoEmote(string emote_type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performSickAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void eatHeldObject()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void grabObject(Object obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayFishBiteChime()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getTitle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void queueMessage(byte messageType, Farmer sourceFarmer, params object[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void queueMessage(OutgoingMessage message)
	{
	}
}
