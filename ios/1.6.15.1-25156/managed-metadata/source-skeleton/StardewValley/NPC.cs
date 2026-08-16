using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Characters;
using StardewValley.GameData.Characters;
using StardewValley.Locations;
using StardewValley.Monsters;
using StardewValley.Pathfinding;
using xTile.Dimensions;

namespace StardewValley;

[XmlInclude(typeof(Raccoon))]
[XmlInclude(typeof(TrashBear))]
[XmlInclude(typeof(Pet))]
[XmlInclude(typeof(JunimoHarvester))]
[XmlInclude(typeof(Junimo))]
[XmlInclude(typeof(Monster))]
[XmlInclude(typeof(Dog))]
[XmlInclude(typeof(Child))]
[XmlInclude(typeof(Cat))]
[XmlInclude(typeof(Horse))]
public class NPC : Character, IComparable
{
	public const int minimum_square_pause = 6000;

	public const int maximum_square_pause = 12000;

	public const int portrait_width = 64;

	public const int portrait_height = 64;

	public const int portrait_neutral_index = 0;

	public const int portrait_happy_index = 1;

	public const int portrait_sad_index = 2;

	public const int portrait_custom_index = 3;

	public const int portrait_blush_index = 4;

	public const int portrait_angry_index = 5;

	public const int startingFriendship = 0;

	public const int defaultSpeed = 2;

	public const int maxGiftsPerWeek = 2;

	public const int friendshipPointsPerHeartLevel = 250;

	public const int maxFriendshipPoints = 2500;

	public const int gift_taste_love = 0;

	public const int gift_taste_like = 2;

	public const int gift_taste_neutral = 8;

	public const int gift_taste_dislike = 4;

	public const int gift_taste_hate = 6;

	public const int gift_taste_stardroptea = 7;

	public const int textStyle_shake = 0;

	public const int textStyle_none = 2;

	public const int adult = 0;

	public const int teen = 1;

	public const int child = 2;

	public const int neutral = 0;

	public const int polite = 1;

	public const int rude = 2;

	public const int outgoing = 0;

	public const int shy = 1;

	public const int positive = 0;

	public const int negative = 1;

	public const string region_desert = "Desert";

	public const string region_town = "Town";

	public const string region_other = "Other";

	public const int defaultSpriteWidth = 16;

	public const int defaultSpriteHeight = 32;

	internal static List<List<string>> routesFromLocationToLocation;

	private Dictionary<int, SchedulePathDescription> schedule;

	private Dictionary<string, string> dialogue;

	private SchedulePathDescription directionsToNewLocation;

	private int lengthOfWalkingSquareX;

	private int lengthOfWalkingSquareY;

	private int squarePauseAccumulation;

	private int squarePauseTotal;

	private int squarePauseOffset;

	public Microsoft.Xna.Framework.Rectangle lastCrossroad;

	private Texture2D portrait;

	private string LastLocationNameForAppearance;

	[XmlIgnore]
	public string LastAppearanceId;

	private Vector2 nextSquarePosition;

	[XmlIgnore]
	public int shakeTimer;

	private bool isWalkingInSquare;

	private readonly NetBool isWalkingTowardPlayer;

	protected string textAboveHead;

	protected int textAboveHeadPreTimer;

	protected int textAboveHeadTimer;

	protected int textAboveHeadStyle;

	protected Color? textAboveHeadColor;

	protected float textAboveHeadAlpha;

	public int daysAfterLastBirth;

	protected Dialogue extraDialogueMessageToAddThisMorning;

	[XmlElement("birthday_Season")]
	public readonly NetString birthday_Season;

	[XmlElement("birthday_Day")]
	public readonly NetInt birthday_Day;

	[XmlElement("age")]
	public readonly NetInt age;

	[XmlElement("manners")]
	public readonly NetInt manners;

	[XmlElement("socialAnxiety")]
	public readonly NetInt socialAnxiety;

	[XmlElement("optimism")]
	public readonly NetInt optimism;

	[XmlElement("gender")]
	public readonly NetEnum<Gender> gender;

	[XmlIgnore]
	public readonly NetBool breather;

	[XmlIgnore]
	public readonly NetBool isSleeping;

	[XmlElement("sleptInBed")]
	public readonly NetBool sleptInBed;

	[XmlIgnore]
	public readonly NetBool hideShadow;

	[XmlElement("isInvisible")]
	public readonly NetBool isInvisible;

	[XmlElement("lastSeenMovieWeek")]
	public readonly NetInt lastSeenMovieWeek;

	public bool? datingFarmer;

	public bool? divorcedFromFarmer;

	[XmlElement("datable")]
	public readonly NetBool datable;

	[XmlIgnore]
	public bool updatedDialogueYet;

	[XmlIgnore]
	public bool immediateSpeak;

	[XmlIgnore]
	public bool ignoreScheduleToday;

	protected int defaultFacingDirection;

	private readonly NetVector2 defaultPosition;

	[XmlElement("defaultMap")]
	public readonly NetString defaultMap;

	public string loveInterest;

	public int id;

	public int daysUntilNotInvisible;

	public bool followSchedule;

	[XmlIgnore]
	public PathFindController temporaryController;

	[XmlElement("moveTowardPlayerThreshold")]
	public readonly NetInt moveTowardPlayerThreshold;

	[XmlIgnore]
	public float rotation;

	[XmlIgnore]
	public float yOffset;

	[XmlIgnore]
	public float swimTimer;

	[XmlIgnore]
	public float timerSinceLastMovement;

	[XmlIgnore]
	public string mapBeforeEvent;

	[XmlIgnore]
	public Vector2 positionBeforeEvent;

	[XmlIgnore]
	public Vector2 lastPosition;

	[XmlIgnore]
	public float currentScheduleDelay;

	[XmlIgnore]
	public float scheduleDelaySeconds;

	[XmlIgnore]
	public bool layingDown;

	[XmlIgnore]
	public Vector2 appliedRouteAnimationOffset;

	[XmlIgnore]
	public string[] routeAnimationMetadata;

	[XmlElement("hasSaidAfternoonDialogue")]
	private NetBool hasSaidAfternoonDialogue;

	[XmlIgnore]
	public static bool hasSomeoneWateredCrops;

	[XmlIgnore]
	public static bool hasSomeoneFedThePet;

	[XmlIgnore]
	public static bool hasSomeoneFedTheAnimals;

	[XmlIgnore]
	public static bool hasSomeoneRepairedTheFences;

	[XmlIgnore]
	protected bool _skipRouteEndIntro;

	[NonInstancedStatic]
	public static HashSet<string> invalidDialogueFiles;

	[XmlIgnore]
	protected bool _hasLoadedMasterScheduleData;

	[XmlIgnore]
	protected Dictionary<string, string> _masterScheduleData;

	internal static Stack<Dialogue> _EmptyDialogue;

	[XmlIgnore]
	public Stack<Dialogue> TemporaryDialogue;

	[XmlIgnore]
	public readonly NetList<MarriageDialogueReference, NetRef<MarriageDialogueReference>> currentMarriageDialogue;

	public readonly NetBool hasBeenKissedToday;

	[XmlIgnore]
	public readonly NetRef<MarriageDialogueReference> marriageDefaultDialogue;

	[XmlIgnore]
	public readonly NetBool shouldSayMarriageDialogue;

	public readonly NetEvent0 removeHenchmanEvent;

	private bool isPlayingSleepingAnimation;

	public readonly NetBool shouldPlayRobinHammerAnimation;

	private bool isPlayingRobinHammerAnimation;

	public readonly NetBool shouldPlaySpousePatioAnimation;

	private bool isPlayingSpousePatioAnimation;

	public readonly NetBool shouldWearIslandAttire;

	private bool isWearingIslandAttire;

	public readonly NetBool isMovingOnPathFindPath;

	[XmlIgnore]
	public bool portraitOverridden;

	[XmlIgnore]
	public bool spriteOverridden;

	[XmlIgnore]
	public List<SchedulePathDescription> queuedSchedulePaths;

	[XmlIgnore]
	public int lastAttemptedSchedule;

	[XmlIgnore]
	public readonly NetBool doingEndOfRouteAnimation;

	private bool currentlyDoingEndOfRouteAnimation;

	[XmlIgnore]
	public readonly NetBool goingToDoEndOfRouteAnimation;

	[XmlIgnore]
	public readonly NetString endOfRouteMessage;

	[XmlElement("dayScheduleName")]
	public readonly NetString dayScheduleName;

	[XmlElement("islandScheduleName")]
	public readonly NetString islandScheduleName;

	private int[] routeEndIntro;

	private int[] routeEndAnimation;

	private int[] routeEndOutro;

	[XmlIgnore]
	public string nextEndOfRouteMessage;

	private string loadedEndOfRouteBehavior;

	[XmlIgnore]
	protected string _startedEndOfRouteBehavior;

	[XmlIgnore]
	protected string _finishingEndOfRouteBehavior;

	[XmlIgnore]
	protected int _beforeEndOfRouteAnimationFrame;

	public readonly NetString endOfRouteBehaviorName;

	public Point previousEndPoint;

	public const int NO_TRY = 9999999;

	protected int scheduleTimeToTry;

	public int squareMovementFacingPreference;

	protected bool returningToEndPoint;

	private bool wasKissedYesterday;

	public SchedulePathDescription DirectionsToNewLocation
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

	public int DefaultFacingDirection
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
	public Dictionary<string, string> Dialogue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public string LoadedDialogueKey
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

	[XmlIgnore]
	public string DefaultMap
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

	public Vector2 DefaultPosition
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
	public Texture2D Portrait
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
	public bool AllowDynamicAppearance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	public override bool IsVillager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public Dictionary<int, SchedulePathDescription> Schedule
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

	[XmlIgnore]
	public string ScheduleKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsWalkingInSquare
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

	public bool IsWalkingTowardPlayer
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
	public virtual Stack<Dialogue> CurrentDialogue
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
	public string Birthday_Season
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
	public int Birthday_Day
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
	public int Age
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
	public int Manners
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
	public int SocialAnxiety
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
	public int Optimism
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
	public bool Breather
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
	public bool HideShadow
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
	public bool HasPartnerForDance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public bool IsInvisible
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

	public virtual bool CanSocialize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC(AnimatedSprite sprite, Vector2 position, int facingDir, string name, LocalizedContentManager content = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC(AnimatedSprite sprite, Vector2 position, string defaultMap, int facingDirection, string name, bool datable, Texture2D portrait)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC(AnimatedSprite sprite, Vector2 position, string defaultMap, int facingDir, string name, Texture2D portrait, bool eventActor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void reloadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void reloadDefaultLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ReadNpcHomeData(CharacterData data, GameLocation currentLocation, out string locationName, out Point tile, out int direction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canTalk()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChooseAppearance(LocalizedContentManager content = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string translateName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getTextureName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getTextureNameForCharacter(string character_name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetSeasonalDialogue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void findRightSchedule()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performSpecialScheduleChanges()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryLoadPortraits(string assetName, out string error, LocalizedContentManager content = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryLoadSprites(string assetName, out string error, LocalizedContentManager content = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateConstructionAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doPlayRobinHammerAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showTextAboveHead(string text, Color? spriteTextColor = null, int style = 2, int duration = 3000, int preTimer = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool hitWithTool(Tool t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanReceiveGifts()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getGiftTasteForThisItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckTaste(IEnumerable<string> list, Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CheckTasteContextTags(Item item, string[] list)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void goblinDoorEndBehavior(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performRemoveHenchman()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void engagementResponse(Farmer who, bool asRoommate = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool tryToReceiveActiveObject(Farmer who, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDispositionModifiedString(string path, params object[] substitutions)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void haltMe(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool checkAction(Farmer who, GameLocation l)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void grantConversationFriendship(Farmer who, int amount = 20)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AskLeoMemoryPrompt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanRevisitLeoMemory(KeyValuePair<string, string>? event_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyValuePair<string, string>? GetUnseenLeoEvent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLeoMemoryResponse(Farmer who, string whichAnswer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isDivorcedFrom(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsDivorcedFrom(Farmer player, string npcName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MovePosition(GameTime time, xTile.Dimensions.Rectangle viewport, GameLocation currentLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameLocation getHome()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canPassThroughActionTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void behaviorOnFarmerPushing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void behaviorOnFarmerLocationEntry(GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void behaviorOnLocalFarmerLocationEntry(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateMovement(GameLocation location, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void facePlayer(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doneFacingPlayer(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void wearIslandAttire()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void wearNormalClothes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performTenMinuteUpdate(int timeOfDay, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sayHiTo(Character c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getHi(string nameToGreet)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isFacingToward(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void arriveAt(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Halt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addExtraDialogue(Dialogue dialogue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PerformDivorce()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue tryToGetMarriageSpecificDialogue(string dialogueKey)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetCurrentDialogue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Stack<Dialogue> loadCurrentDialogue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkForNewCurrentDialogue(int heartLevel, bool noPreface = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue TryGetDialogue(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue TryGetDialogueByGiftTaste(int giftTaste, Func<string, string> getKey)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue TryGetDialogue(string key, params object[] substitutions)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue tryToRetrieveDialogue(string preface, int heartLevel, string appendToEnd = "")
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void checkSchedule(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void finishEndOfRouteAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void prepareToDisembarkOnNewSchedulePath()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForMarriageDialogue(int timeOfDay, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void routeEndAnimationFinished(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isOnSilentTemporaryMessage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasTemporaryMessageAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool setTemporaryMessages(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _PushTemporaryDialogue(string translationKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void walkInSquareAtEndOfRoute(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doAnimationAtEndOfScheduleRoute(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void reallyDoAnimationAtEndOfScheduleRoute()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doMiddleAnimation(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void startRouteBehavior(string behaviorName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playSleepingAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void finishRouteBehavior(string behaviorName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsReturningToEndPoint()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartActivityWalkInSquare(int square_width, int square_height, int pause_offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndActivityRouteEndBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartActivityRouteEndBehavior(string behavior_name, string end_message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathFindController.endBehavior getRouteEndBehaviorFunction(string behaviorName, string endMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadEndOfRouteBehavior(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shake(int duration)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setNewDialogue(string translationKey, bool add = false, bool clearOnMovement = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setNewDialogue(Dialogue dialogue, bool add = false, bool clearOnMovement = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setNewDialogue(string dialogueSheetName, string dialogueSheetKey, bool clearOnMovement = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDialogueSheetName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setSpouseRoomMarriageDialogue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setRandomAfternoonMarriageDialogue(int time, GameLocation location, bool countAsDailyAfternoon = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBirthday()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item getFavoriteItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string name, out CharacterData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDisplayName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanSocializePerData(string name, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTokenizedDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SpeaksDwarvish()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveGift(Object o, Farmer giver, bool updateGiftLimitInfo = true, float friendshipChangeMultiplier = 1f, bool showResponse = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Dialogue GetGiftReaction(Farmer giver, Object gift, int taste)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawBreathing(SpriteBatch b, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawGlow(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawEmote(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool NeedsBirdieEmoteHack()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void warpToPathControllerDestination()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Microsoft.Xna.Framework.Rectangle getMugShotSourceRect()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void getHitByPlayer(Farmer who, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void walkInSquare(int squareWidth, int squareHeight, int squarePauseOffset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void moveTowardPlayer(int threshold)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Farmer findPlayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool withinPlayerThreshold()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool withinPlayerThreshold(int threshold)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Stack<Point> addToStackForSchedule(Stack<Point> original, Stack<Point> toAdd, string location, Stack<string> originalLocNames, out Stack<string> locNames)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual SchedulePathDescription pathfindToNextScheduleLocation(string scheduleKey, string startingLocation, int startingX, int startingY, string endingLocation, int endingX, int endingY, int finalFacingDirection, string endBehavior, string endMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Stack<string> addLocationNamesToPath(Stack<Point> path, string startingLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] getLocationRoute(string startingLocation, string endingLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool changeScheduleForLocationAccessibility(ref string locationName, ref int tileX, ref int tileY, ref int facingDirection)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Dictionary<int, SchedulePathDescription> parseMasterSchedule(string scheduleKey, string rawData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Dictionary<int, SchedulePathDescription> parseMasterScheduleImpl(string scheduleKey, string rawData, List<string> visited)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] SplitScheduleCommands(string rawScript)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryLoadSchedule()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryLoadSchedule(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryLoadSchedule(string key, string rawSchedule)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryLoadSchedule(string key, Dictionary<int, SchedulePathDescription> schedule)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSchedule()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void handleMasterScheduleFileLoadError(Exception e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InvalidateMasterSchedule()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, string> getMasterScheduleRawData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getMasterScheduleEntry(string schedule_key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasMasterScheduleEntry(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isRoommate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isMarried()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isMarriedOrEngaged()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDayStarted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void UpdateInvisibilityOnNewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetForNewDay(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void returnHomeFromFarmPosition(Farm farm)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetSpousePatioPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpForOutdoorPatioActivity()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doPlaySpousePatioAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool hasDarkSkin()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isAdoptionSpouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canGetPregnant()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void marriageDuties()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void popOffAnyNonEssentialItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool checkTileOccupancyForSpouse(GameLocation location, Vector2 point, string characterToIgnore = "")
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addMarriageDialogue(string dialogue_file, string dialogue_key, bool gendered = false, params string[] substitutions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void clearTextAboveHead()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Use IsVillager instead.")]
	public bool isVillager()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldCollideWithBuildingLayer(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void arriveAtFarmHouse(FarmHouse farmHouse)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer getSpouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getTermOfSpousalEndearment(bool happy = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool spouseObstacleCheck(MarriageDialogueReference backToBedMessage, GameLocation currentLocation, bool force = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTilePosition(Point p)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTilePosition(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void clintHammerSound(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void robinHammerSound(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void robinVariablePause(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void randomSquareMovement(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void returnToEndPoint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMovingOnlyUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMovingOnlyRight()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMovingOnlyDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMovingOnlyLeft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTimeFarmerMustPushBeforePassingThrough()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTimeFarmerMustPushBeforeStartShaking()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(object obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Removed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void populateRoutesFromLocationToLocationList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool exploreWarpPoints(GameLocation l, List<string> route)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool doesRoutesListContain(List<string> route)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
