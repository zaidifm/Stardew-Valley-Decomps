using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;
using StardewValley.Audio;
using StardewValley.BellsAndWhistles;
using StardewValley.Buildings;
using StardewValley.GameData;
using StardewValley.GameData.Buildings;
using StardewValley.GameData.GarbageCans;
using StardewValley.GameData.LocationContexts;
using StardewValley.GameData.Locations;
using StardewValley.GameData.Minecarts;
using StardewValley.Internal;
using StardewValley.Locations;
using StardewValley.Menus;
using StardewValley.Mobile;
using StardewValley.Mods;
using StardewValley.Monsters;
using StardewValley.Network;
using StardewValley.Objects;
using StardewValley.Projectiles;
using StardewValley.TerrainFeatures;
using xTile;
using xTile.Dimensions;
using xTile.Layers;
using xTile.Tiles;

namespace StardewValley;

[XmlInclude(typeof(ManorHouse))]
[XmlInclude(typeof(LibraryMuseum))]
[XmlInclude(typeof(Mine))]
[XmlInclude(typeof(MermaidHouse))]
[XmlInclude(typeof(JojaMart))]
[XmlInclude(typeof(MineShaft))]
[XmlInclude(typeof(IslandWest))]
[XmlInclude(typeof(IslandSouthEastCave))]
[XmlInclude(typeof(IslandSouth))]
[XmlInclude(typeof(IslandShrine))]
[XmlInclude(typeof(IslandSecret))]
[XmlInclude(typeof(IslandWestCave1))]
[XmlInclude(typeof(Mountain))]
[XmlInclude(typeof(IslandNorth))]
[XmlInclude(typeof(Railroad))]
[XmlInclude(typeof(SeedShop))]
[XmlInclude(typeof(Sewer))]
[XmlInclude(typeof(Shed))]
[XmlInclude(typeof(ShopLocation))]
[XmlInclude(typeof(SlimeHutch))]
[XmlInclude(typeof(Submarine))]
[XmlInclude(typeof(Summit))]
[XmlInclude(typeof(Town))]
[XmlInclude(typeof(WizardHouse))]
[XmlInclude(typeof(Woods))]
[InstanceStatics]
[NotImplicitNetField]
[XmlInclude(typeof(MovieTheater))]
[XmlInclude(typeof(IslandLocation))]
[XmlInclude(typeof(IslandSouthEast))]
[XmlInclude(typeof(IslandForestLocation))]
[XmlInclude(typeof(AbandonedJojaMart))]
[XmlInclude(typeof(AdventureGuild))]
[XmlInclude(typeof(AnimalHouse))]
[XmlInclude(typeof(BathHousePool))]
[XmlInclude(typeof(Beach))]
[XmlInclude(typeof(BeachNightMarket))]
[XmlInclude(typeof(BoatTunnel))]
[XmlInclude(typeof(BugLand))]
[XmlInclude(typeof(BusStop))]
[XmlInclude(typeof(Caldera))]
[XmlInclude(typeof(Cellar))]
[XmlInclude(typeof(Club))]
[XmlInclude(typeof(Cabin))]
[XmlInclude(typeof(DecoratableLocation))]
[XmlInclude(typeof(IslandFieldOffice))]
[XmlInclude(typeof(IslandFarmHouse))]
[XmlInclude(typeof(IslandFarmCave))]
[XmlInclude(typeof(CommunityCenter))]
[XmlInclude(typeof(IslandHut))]
[XmlInclude(typeof(Forest))]
[XmlInclude(typeof(IslandEast))]
[XmlInclude(typeof(FarmHouse))]
[XmlInclude(typeof(FarmCave))]
[XmlInclude(typeof(Farm))]
[XmlInclude(typeof(DesertFestival))]
[XmlInclude(typeof(Desert))]
[XmlInclude(typeof(FishShop))]
public class GameLocation : INetObject<NetFields>, IEquatable<GameLocation>, IAnimalLocation, IHaveModData
{
	public delegate void afterQuestionBehavior(Farmer who, string whichAnswer);

	private struct DamagePlayersEventArg : NetEventArg
	{
		public Microsoft.Xna.Framework.Rectangle Area;

		public int Damage;

		public bool IsBomb;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(BinaryReader reader)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(BinaryWriter writer)
		{
		}
	}

	public const int maxTriesForDebrisPlacement = 3;

	public const string DefaultTileSheetId = "untitled tile sheet";

	public const string OVERRIDE_MAP_TILESHEET_PREFIX = "zzzzz";

	public const string PHONE_DIAL_SOUND = "telephone_buttonPush";

	public const int PHONE_RING_DURATION = 4950;

	public const string PHONE_PICKUP_SOUND = "bigSelect";

	public const string PHONE_HANGUP_SOUND = "openBox";

	public static readonly IList<string> OceanCrabPotFishTypes;

	public static readonly IList<string> DefaultCrabPotFishTypes;

	[XmlIgnore]
	private Lazy<Season?> seasonOverride;

	[XmlIgnore]
	public bool? isMusicTownMusic;

	[XmlIgnore]
	public string locationContextId;

	public readonly NetCollection<Building> buildings;

	[XmlElement("animals")]
	public readonly NetLongDictionary<FarmAnimal, NetRef<FarmAnimal>> animals;

	[XmlElement("piecesOfHay")]
	public readonly NetInt piecesOfHay;

	private readonly List<KeyValuePair<long, FarmAnimal>> tempAnimals;

	[XmlIgnore]
	public readonly NetString parentLocationName;

	[XmlIgnore]
	public Building ParentBuilding;

	[XmlIgnore]
	public List<KeyValuePair<Layer, int>> backgroundLayers;

	[XmlIgnore]
	public List<KeyValuePair<Layer, int>> buildingLayers;

	[XmlIgnore]
	public List<KeyValuePair<Layer, int>> frontLayers;

	[XmlIgnore]
	public List<KeyValuePair<Layer, int>> alwaysFrontLayers;

	[NonInstancedStatic]
	[XmlIgnore]
	protected static Dictionary<string, Action<GameLocation, string[], Farmer, Vector2>> registeredTouchActions;

	[XmlIgnore]
	[NonInstancedStatic]
	protected static Dictionary<string, Func<GameLocation, string[], Farmer, Point, bool>> registeredTileActions;

	[XmlIgnore]
	public NetBool isAlwaysActive;

	[XmlIgnore]
	public afterQuestionBehavior afterQuestion;

	[XmlIgnore]
	public Map map;

	[XmlIgnore]
	public readonly NetString mapPath;

	[XmlIgnore]
	protected string loadedMapPath;

	public readonly NetCollection<NPC> characters;

	[XmlIgnore]
	public readonly NetVector2Dictionary<Object, NetRef<Object>> netObjects;

	[XmlIgnore]
	public readonly OverlayDictionary<Vector2, Object> overlayObjects;

	[XmlElement("objects")]
	public readonly OverlaidDictionary objects;

	[XmlIgnore]
	public NetList<MapSeat, NetRef<MapSeat>> mapSeats;

	protected bool _mapSeatsDirty;

	[XmlIgnore]
	public TemporaryAnimatedSpriteList temporarySprites;

	[XmlIgnore]
	public List<Action> postFarmEventOvernightActions;

	[XmlIgnore]
	public readonly NetObjectList<Warp> warps;

	[XmlIgnore]
	public readonly NetPointDictionary<string, NetString> doors;

	[XmlIgnore]
	public readonly InteriorDoorDictionary interiorDoors;

	[XmlIgnore]
	public readonly FarmerCollection farmers;

	[XmlIgnore]
	public readonly NetCollection<Projectile> projectiles;

	public readonly NetCollection<ResourceClump> resourceClumps;

	public readonly NetCollection<LargeTerrainFeature> largeTerrainFeatures;

	[XmlIgnore]
	public List<TerrainFeature> _activeTerrainFeatures;

	[XmlIgnore]
	public List<Critter> critters;

	[XmlElement("terrainFeatures")]
	public readonly NetVector2Dictionary<TerrainFeature, NetRef<TerrainFeature>> terrainFeatures;

	[XmlIgnore]
	public readonly NetCollection<Debris> debris;

	[XmlIgnore]
	public readonly NetPoint fishSplashPoint;

	private int fishSplashPointTime;

	[XmlIgnore]
	public readonly NetString fishFrenzyFish;

	[XmlIgnore]
	public readonly NetPoint orePanPoint;

	[XmlIgnore]
	public TemporaryAnimatedSprite fishSplashAnimation;

	[XmlIgnore]
	public TemporaryAnimatedSprite orePanAnimation;

	[XmlIgnore]
	public WaterTiles waterTiles;

	[XmlIgnore]
	protected HashSet<string> _appliedMapOverrides;

	[XmlElement("uniqueName")]
	public readonly NetString uniqueName;

	[XmlIgnore]
	protected string _displayName;

	[XmlElement("name")]
	public readonly NetString name;

	[XmlElement("waterColor")]
	public readonly NetColor waterColor;

	[XmlIgnore]
	public string lastQuestionKey;

	[XmlIgnore]
	public Vector2 lastTouchActionLocation;

	[XmlElement("lightLevel")]
	protected readonly NetFloat lightLevel;

	[XmlElement("isFarm")]
	public readonly NetBool isFarm;

	[XmlElement("isOutdoors")]
	public readonly NetBool isOutdoors;

	[XmlIgnore]
	public readonly NetBool isGreenhouse;

	[XmlElement("isStructure")]
	public readonly NetBool isStructure;

	[XmlElement("ignoreDebrisWeather")]
	public readonly NetBool ignoreDebrisWeather;

	[XmlElement("ignoreOutdoorLighting")]
	public readonly NetBool ignoreOutdoorLighting;

	[XmlElement("ignoreLights")]
	public readonly NetBool ignoreLights;

	[XmlElement("treatAsOutdoors")]
	public readonly NetBool treatAsOutdoors;

	[XmlIgnore]
	public bool wasUpdated;

	public int numberOfSpawnedObjectsOnMap;

	[XmlIgnore]
	public bool showDropboxIndicator;

	[XmlIgnore]
	public Vector2 dropBoxIndicatorLocation;

	[XmlElement("miniJukeboxCount")]
	public readonly NetInt miniJukeboxCount;

	[XmlElement("miniJukeboxTrack")]
	public readonly NetString miniJukeboxTrack;

	[XmlIgnore]
	public readonly NetString randomMiniJukeboxTrack;

	[XmlIgnore]
	public Event currentEvent;

	[XmlIgnore]
	public Object actionObjectForQuestionDialogue;

	[XmlIgnore]
	public int waterAnimationIndex;

	[XmlIgnore]
	public int waterAnimationTimer;

	[XmlIgnore]
	public bool waterTileFlip;

	[XmlIgnore]
	public bool forceViewportPlayerFollow;

	[XmlIgnore]
	public bool forceLoadPathLayerLights;

	[XmlIgnore]
	public float waterPosition;

	[XmlIgnore]
	public readonly NetAudio netAudio;

	[XmlIgnore]
	public readonly NetStringDictionary<LightSource, NetRef<LightSource>> sharedLights;

	private readonly NetEvent1Field<int, NetInt> removeTemporarySpritesWithIDEvent;

	private readonly NetEvent1Field<int, NetInt> rumbleAndFadeEvent;

	private readonly NetEvent1<DamagePlayersEventArg> damagePlayersEvent;

	[XmlIgnore]
	public NetVector2HashSet lightGlows;

	public static readonly int JOURNAL_INDEX;

	public static readonly float FIRST_SECRET_NOTE_CHANCE;

	public static readonly float LAST_SECRET_NOTE_CHANCE;

	public static readonly int NECKLACE_SECRET_NOTE_INDEX;

	public static readonly string CAROLINES_NECKLACE_ITEM_QID;

	public static readonly string CAROLINES_NECKLACE_MAIL;

	public static TilePositionComparer tilePositionComparer;

	protected List<Vector2> _startingCabinLocations;

	[XmlIgnore]
	public bool wasInhabited;

	[XmlIgnore]
	protected bool _madeMapModifications;

	[XmlIgnore]
	private bool DefaultConstructed;

	public readonly NetCollection<Furniture> furniture;

	protected readonly NetMutexQueue<Guid> furnitureToRemove;

	protected bool _mapPathDirty;

	protected LocalizedContentManager _structureMapLoader;

	internal bool ignoreWarps;

	protected HashSet<Vector2> _visitedCollisionTiles;

	protected bool _looserBuildRestrictions;

	protected Microsoft.Xna.Framework.Rectangle? _buildableTileRect;

	private bool showedBuildableButNotAlwaysActiveWarning;

	public static bool PlayedNewLocationContextMusic;

	private const int fireIDBase = 944468;

	protected Color indoorLightingColor;

	protected Color indoorLightingNightColor;

	internal static List<KeyValuePair<string, string>> _PagedResponses;

	internal static int _PagedResponsePage;

	internal static int _PagedResponseItemsPerPage;

	public static bool _PagedResponseAddCancel;

	internal static string _PagedResponsePrompt;

	internal static Action<string> _OnPagedResponse;

	protected string _constructLocationBuilderName;

	protected List<Farmer> _currentLocationFarmersForDisambiguating;

	[XmlIgnore]
	public Dictionary<Vector2, float> lightGlowLayerCache;

	private long ticks;

	private bool drawFrameOne;

	public NetLongDictionary<FarmAnimal, NetRef<FarmAnimal>> Animals
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public NetRoot<GameLocation> Root
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int ExtraMillisecondsPerInGameMinute
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
	public string DisplayName
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
	public string NameOrUniqueName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public bool IsTemporary
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[XmlIgnore]
	public float LightLevel
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
	public Map Map
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
	public OverlaidDictionary Objects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public TemporaryAnimatedSpriteList TemporarySprites
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public bool IsFarm
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
	public bool IsOutdoors
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
	public TapToMove tapToMove
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

	public bool IsGreenhouse
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
	public ModDataDictionary modData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlElement("modData")]
	public ModDataDictionary modDataForSerialization
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
	public virtual string GetDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool SeedsIgnoreSeasonsHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanPlantSeedsHere(string itemId, int tileX, int tileY, bool isGardenPot, out string deniedMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanPlantTreesHere(string itemId, int tileX, int tileY, out string deniedMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckItemPlantRules(string itemId, bool isGardenPot, bool defaultAllowed, out string deniedMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckItemPlantRules(List<PlantableRule> rules, bool isGardenPot, bool defaultAllowed, out string deniedMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InvalidateCachedMultiplayerMap(Dictionary<string, CachedMultiplayerMap> cached_data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ApplyCachedMultiplayerMap(Dictionary<string, CachedMultiplayerMap> cached_data, string requested_map_path)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StoreCachedMultiplayerMap(Dictionary<string, CachedMultiplayerMap> cached_data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnNameChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnParentLocationChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnParentBuildingUpgraded(Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRemoved()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnObjectAdded(Vector2 tile, Object obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnResourceClumpAdded(ResourceClump resourceClump)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnResourceClumpRemoved(ResourceClump resourceClump)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTerrainFeatureAdded(TerrainFeature feature, Vector2 location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTerrainFeatureRemoved(TerrainFeature feature)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateTerrainFeatureUpdateSubscription(TerrainFeature feature)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSeasonIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Season? LoadSeasonOverride()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Season GetSeason()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSeasonKey()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSpringHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSummerHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFallHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsWinterHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocationWeather GetWeather()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRainingHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGreenRainingHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLightningHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSnowingHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDebrisWeatherHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTemporaryName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateFishSplashAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateOrePanAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameLocation(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddDefaultBuildings(bool load = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddDefaultBuilding(string id, Vector2 tile, bool load = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playSound(string audioName, Vector2? position = null, int? pitch = null, SoundContext context = SoundContext.Default)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void localSound(string audioName, Vector2? position = null, int? pitch = null, SoundContext context = SoundContext.Default)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual LocalizedContentManager getMapLoader()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void cleanUpTileForMapOverride(Point tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void cleanUpTileForMapOverride(Point tile, string exceptItemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyMapOverride(Map override_map, string override_key, Microsoft.Xna.Framework.Rectangle? source_rect = null, Microsoft.Xna.Framework.Rectangle? dest_rect = null, Action<Point> perTileCustomAction = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetAddedMapOverrideTilesheetId(string overrideKey, string tilesheetId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool RunLocationSpecificEventCommand(Event current_event, string command_string, bool first_run, params string[] args)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasActiveFireplace()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyMapOverride(string map_name, Microsoft.Xna.Framework.Rectangle? source_rect = null, Microsoft.Xna.Framework.Rectangle? destination_rect = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyMapOverride(string map_name, string override_key_name, Microsoft.Xna.Framework.Rectangle? source_rect = null, Microsoft.Xna.Framework.Rectangle? destination_rect = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateMapSeats()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SortLayers()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMapLoad(Map map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadMap(string mapPath, bool force_reload = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HandleGrassGrowth(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reloadMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canSlimeMateHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canSlimeHatchHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addCharacter(NPC character)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle getSourceRectForObject(int tileIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Warp isCollidingWithWarp(Microsoft.Xna.Framework.Rectangle position, Character character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Warp isCollidingWithWarpOrDoor(Microsoft.Xna.Framework.Rectangle position, Character character = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Warp isCollidingWithDoors(Microsoft.Xna.Framework.Rectangle position, Character character = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Warp getWarpFromDoor(Point door, Character character = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Warp GetFirstPlayerWarp()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addResourceClumpAndRemoveUnderlyingTerrain(int resourceClumpIndex, int width, int height, Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canFishHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanWakeUpHere(Farmer who, Point? tile = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanRefillWateringCanOnTile(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isTileBuildingFishable(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isTileFishable(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isFarmerCollidingWithAnyCharacter()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, Character character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool _TestCornersWorld(int top, int bottom, int left, int right, Func<int, int, bool> action)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool _TestCornersTiles(Vector2 top_right, Vector2 top_left, Vector2 bottom_right, Vector2 bottom_left, Vector2 top_mid, Vector2 bottom_mid, Vector2? player_top_right, Vector2? player_top_left, Vector2? player_bottom_right, Vector2? player_bottom_left, Vector2? player_top_mid, Vector2? player_bottom_mid, bool bigger_than_tile, Func<Vector2, bool> action)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Furniture GetFurnitureAt(Vector2 tile_position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Microsoft.Xna.Framework.Rectangle GetBuildableRectangle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsBuildableLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsOutOfBounds(Microsoft.Xna.Framework.Rectangle pixelPosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false, bool skipCollisionEffects = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTilePassable(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTilePassable(Location tileLocation, xTile.Dimensions.Rectangle viewport)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isPointPassable(Location location, xTile.Dimensions.Rectangle viewport)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTilePassable(Microsoft.Xna.Framework.Rectangle nextPosition, xTile.Dimensions.Rectangle viewport)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileOnMap(Vector2 position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileOnMap(Point tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileOnMap(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int numberOfObjectsWithName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point getWarpPointTo(string location, Character character = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getWarpPointTarget(Point warpPointLocation, Character character = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasLocationOverrideDialogue(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetLocationOverrideDialogue(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC doesPositionCollideWithCharacter(Microsoft.Xna.Framework.Rectangle r, bool ignoreMonsters = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void switchOutNightTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetMorningSong()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void HandleMusicChange(GameLocation oldLocation, GameLocation newLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void checkForMusic(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetLocationSpecificMusic()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC isCollidingWithCharacter(Microsoft.Xna.Framework.Rectangle box)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool moveContents(int oldX, int oldY, int newX, int newY, string unlessItemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void getGalaxySword()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterTouchAction(string key, Action<GameLocation, string[], Farmer, Vector2> action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterTileAction(string key, Func<GameLocation, string[], Farmer, Point, bool> action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IgnoreTouchActions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performTouchAction(string fullActionString, Vector2 playerStandingPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performTouchAction(string[] action, Vector2 playerStandingPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateLayout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LargeTerrainFeature getLargeTerrainFeatureAt(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateWater(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC getCharacterFromName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void updateCharacters(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Projectile getProjectileFromID(int uniqueID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameLocation GetParentLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameLocation GetRootLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Response[] createYesNoResponses()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void customQuestCompleteBehavior(string questId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createQuestionDialogue(string question, Response[] answerChoices, string dialogKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createQuestionDialogueWithCustomWidth(string question, Response[] answerChoices, string dialogKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createQuestionDialogue(string question, Response[] answerChoices, afterQuestionBehavior afterDialogueBehavior, NPC speaker = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createQuestionDialogue(string question, Response[] answerChoices, string dialogKey, Object actionObject)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void monsterDrop(Monster monster, int x, int y, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasUnlockedAreaSecretNotes(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool damageMonster(Microsoft.Xna.Framework.Rectangle areaOfEffect, int minDamage, int maxDamage, bool isBomb, Farmer who, bool isProjectile = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isMonsterDamageApplicable(Farmer who, Monster monster, bool horizontalBias = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool BlocksDamageLOS(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool damageMonster(Microsoft.Xna.Framework.Rectangle areaOfEffect, int minDamage, int maxDamage, bool isBomb, float knockBackModifier, int addedPrecision, float critChance, float critMultiplier, bool triggerMonsterInvincibleTimer, Farmer who, bool isProjectile = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void onMonsterKilled(Farmer who, Monster monster, Microsoft.Xna.Framework.Rectangle monsterBox, bool killedByBomb)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void growWeedGrass(int iterations)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tryPlaceObject(Vector2 tile, Object o)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeDamageDebris(Monster monster)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void spawnWeeds(bool weedsOnly)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMiniJukeboxAdded()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMiniJukeboxRemoved()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateMiniJukebox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsMiniJukeboxPlaying()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual double GetDirtDecayChance(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RespawnStumpsFromMapProperty()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addLightGlows()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC isCharacterAtTile(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCharacterDialogues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getMapProperty(string propertyName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetMapProperty(string propertyName, out string propertyValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] GetMapPropertySplitBySpaces(string propertyName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetMapPropertyAs(string key, out bool parsed, bool required = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetMapPropertyAs(string key, out double parsed, bool required = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetMapPropertyAs(string key, out Point parsed, bool required = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetMapPropertyAs(string key, out Vector2 parsed, bool required = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetMapPropertyAs(string key, out Microsoft.Xna.Framework.Rectangle parsed, bool required = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasMapPropertyWithValue(string propertyName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void tryToAddCritters(bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addClouds(double chance, bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addOwl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setFireplace(bool on, int tileLocationX, int tileLocationY, bool playSound = true, int xOffset = 0, int yOffset = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addWoodpecker(double chance, bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addSquirrels(double chance, bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addBunnies(double chance, bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addOpossums(double chance, bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void instantiateCrittersList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addCritter(Critter c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addButterflies(double chance, bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tryAddPrismaticButterfly()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addBirdies(double chance, bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addJumperFrog(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addFrog()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForSpecialCharacterIconAtThisTile(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addCrittersStartingAtTile(Vector2 tile, List<Critter> crittersToAdd)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isAreaClear(Microsoft.Xna.Framework.Rectangle area)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performGreenRainUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performDayAfterGreenRainUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getRandomTile(Random r = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpLocationSpecificFlair()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void hostSetup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetForEvent(Event ev)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasFarmerWatchingBroadcastEventReturningHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetForPlayerEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _updateAmbientLighting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TryGetAmbientLightFromMap(out Color color, string propertyName = "AmbientLight")
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectRandomMiniJukeboxTrack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightSource getLightSource([NotNullWhen(true)] string identifier)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasLightSource([NotNullWhen(true)] string identifier)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeLightSource([NotNullWhen(true)] string identifier)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void repositionLightSource([NotNullWhen(true)] string identifier, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanSpawnCharacterHere(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanItemBePlacedHere(Vector2 tile, bool itemIsPassable = false, CollisionMask collisionMask = CollisionMask.All, CollisionMask ignorePassables = ~CollisionMask.Objects, bool useFarmerTile = false, bool ignorePassablesExactly = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTileBlockedBy(Vector2 tile, CollisionMask collisionMask = CollisionMask.All, CollisionMask ignorePassables = CollisionMask.None, bool useFarmerTile = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTileOccupiedBy(Vector2 tile, CollisionMask collisionMask = CollisionMask.All, CollisionMask ignorePassables = CollisionMask.None, bool useFarmerTile = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsLocationSpecificOccupantOnTile(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsLocationSpecificPlacementRestriction(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer isTileOccupiedByFarmer(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HoeDirt GetHoeDirtAtTile(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileHoeDirt(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileLocationOpen(Location location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isTileOccupiedIgnoreFloorsAndHorse(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileLocationOpen(Vector2 location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanPlaceThisFurnitureHere(Furniture furniture)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isTilePlaceable(Vector2 v, bool itemIsPassable = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isTilePlaceable(Vector2 v, Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playTerrainSound(Vector2 tileLocation, Character who = null, bool showTerrainDisturbAnimation = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkTileIndexAction(int tileIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkForTerrainFeaturesAndObjectsButDestroyNonPlayerItems(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetHarvestSpawnedObjectQuality(Farmer who, bool isForage, Vector2 tile, Random random = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnHarvestedForage(Farmer who, Object forage)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanFreePlaceFurniture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool LowPriorityLeftClick(int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("These values returned by this function are no longer used by the game (except for rare, backwards compatibility related cases.) Check DecoratableLocation's wallpaper/flooring related functionality instead.")]
	public virtual List<Microsoft.Xna.Framework.Rectangle> getWalls()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void removeQueuedFurniture(Guid guid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool leftClick(int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool shouldShadowBeDrawnAboveBuildingsLayer(Vector2 p)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Chest GetFridge(bool onlyUnlocked = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point? GetFridgePosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateKitchen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void openDoor(Location tileLocation, bool playSound)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doStarpoint(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string FormatCompletionLine(Func<Farmer, float> check)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string FormatCompletionLine(Func<Farmer, bool> check, string true_value, string false_value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowQiCat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CheckGarbage(string id, Vector2 tile, Farmer who, bool playAnimations = true, bool reactNpcs = true, Action<string> logError = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TryGetGarbageItem(string id, double dailyLuck, out Item item, out GarbageCanItemData selected, out Random garbageRandom, Action<string> logError = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performAction(string fullActionString, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldIgnoreAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowLockedDoorMessage(string[] action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showPrairieKingMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowMineCartMenu(string networkId, string excludeDestinationId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MinecartWarp(MinecartDestinationData destination)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void lockedDoorWarp(Point tile, string locationName, int openTime, int closeTime, string npcName, int minFriendship)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playElliottPiano(int key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void readNote(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void mailbox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void farmerFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTotalCrops()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTotalCropsReadyForHarvest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTotalUnwateredCrops()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int? getTotalGreenhouseCropsReadyForHarvest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTotalOpenHoeDirt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTotalForageItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getNumberOfMachinesReadyForHarvest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void openCraftingMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HandleBuyAction(string which)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isObjectAt(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isObjectAtTile(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Object getObjectAt(int x, int y, bool ignorePassables = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object getObjectAtTile(int x, int y, bool ignorePassables = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool saloon(Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void adventureShop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool carpenters(Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool blacksmith(Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool animalShop(Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeTile(Location tileLocation, string layer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeTile(int x, int y, string layer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void characterTrampleTile(Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool characterDestroyObjectWithinRectangle(Microsoft.Xna.Framework.Rectangle rect, bool showDestroyedObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool checkDestroyTerrainFeature(TerrainFeature tf, Vector2 tilePositionToTry)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool checkDestroyItem(Object o, Vector2 tilePositionToTry, bool showDestroyedObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object removeObject(Vector2 location, bool showDestroyedObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeTileProperty(int tileX, int tileY, string layer, string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTileProperty(int tileX, int tileY, string layer, string key, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setObjectAt(float x, float y, Object o)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void cleanupBeforeSave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void cleanupForVacancy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getWeedForSeason(Random r, Season season)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void startSleep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _CleanupPagedResponses()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowPagedResponses(string prompt, List<KeyValuePair<string, string>> responses, Action<string> on_response, bool auto_select_single_choice = false, bool addCancel = true, int itemsPerPage = 5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _ShowPagedResponses(int page = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowConstructOptions(string builder, int page = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowAnimalShopMenu(Action<PurchaseAnimalsMenu> onMenuOpened = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doSleep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playShopPhoneNumberSounds(string whichShop)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool answerDialogue(Response answer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AreStoresClosedForFestival()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveProfession(int profession)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool canRespec(int skill_index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setObject(Vector2 v, Object o)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void houseUpgradeOffer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void communityUpgradeOffer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool catchOceanCrabPotFishFromThisSpot(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void communityUpgradeAccept()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void houseUpgradeAccept()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void destroyObject(Vector2 tileLocation, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void destroyObject(Vector2 tileLocation, bool hardDestroy, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addOneTimeGiftBox(Item i, int x, int y, int whichGiftBox = 2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetLocationContextId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual LocationContextData GetLocationContext()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InDesertContext()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InIslandContext()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InValleyContext()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool sinkDebris(Debris debris, Vector2 chunkTile, Vector2 chunkPosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool doesTileSinkDebris(int xTile, int yTile, Debris.DebrisType type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isTileUpperWaterBorder(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool doesEitherTileOrTileIndexPropertyEqual(int xTile, int yTile, string propertyName, string layerName, string propertyValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsNoSpawnTile(Vector2 tile, string type = "All", bool ignoreTileSheetProperties = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string doesTileHaveProperty(int xTile, int yTile, string propertyName, string layerName, bool ignoreTileSheetProperties = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string doesTileHavePropertyNoNull(int xTile, int yTile, string propertyName, string layerName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] GetTilePropertySplitBySpaces(string propertyName, string layerId, int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isWaterTile(int xTile, int yTile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsWaterTile(Location location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isOpenWater(int xTile, int yTile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isCropAtTile(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HandleViewportSizeChange(xTile.Dimensions.Rectangle old_viewport, xTile.Dimensions.Rectangle new_viewport)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateLocationSpecificWeatherDebris()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool dropObject(Object obj, Vector2 dropLocation, xTile.Dimensions.Rectangle viewport, bool initialPlacement, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rumbleAndFade(int milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performRumbleAndFade(int milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void damagePlayers(Microsoft.Xna.Framework.Rectangle area, int damage, bool isBomb = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performDamagePlayers(DamagePlayersEventArg arg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void explode(Vector2 tileLocation, int radius, Farmer who, bool damageFarmers = true, int damage_amount = -1, bool destroyObjects = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void explosionAt(float x, float y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeTemporarySpritesWithID(int id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeTemporarySpritesWithIDLocal(int id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool makeHoeDirt(Vector2 tileLocation, bool ignoreChecks = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int numberOfObjectsOfType(string itemId, bool bigCraftable)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void timeUpdate(int timeElapsed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void passTimeForObjects(int timeElapsed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performOrePanTenMinuteUpdate(Random r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IList<string> GetCrabPotFishForTile(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TryGetFishAreaForTile(Vector2 tile, out string id, out FishAreaData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetFishingAreaDisplayName(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string locationName = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item GetFishFromLocationData(string locationName, Vector2 bobberTile, int waterDepth, Farmer player, bool isTutorialCatch, bool isInherited, GameLocation location = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Item GetFishFromLocationData(string locationName, Vector2 bobberTile, int waterDepth, Farmer player, bool isTutorialCatch, bool isInherited, GameLocation location, ItemQueryContext itemQueryContext)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckGenericFishRequirements(Item fish, Dictionary<string, string> allFishData, GameLocation location, Farmer player, SpawnFishData spawn, int waterDepth, bool usingMagicBait, bool hasCuriosityLure, bool usingTargetBait, bool isTutorialCatch)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isActionableTile(int xTile, int yTile, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item tryGetRandomArtifactFromThisLocation(Farmer who, Random r, double chanceMultipler = 1.0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void digUpArtifactSpot(int xLocation, int yLocation, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocationData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LocationData GetData(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldExcludeFromNpcPathfinding()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string HandleTreasureTileProperty(int xLocation, int yLocation, bool detectOnly)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AllowMapModificationsInResetState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeMapTile(int tileX, int tileY, string layer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StaticTile setMapTile(int tileX, int tileY, int index, string layer, string tileSheetId, string action = null, bool copyProperties = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimatedTile setAnimatedMapTile(int tileX, int tileY, int[] animationTileIndexes, long interval, string layer, string tileSheetId, string action = null, bool copyProperties = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void shiftContents(int dx, int dy, Func<Vector2, object, bool> where = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void moveFurniture(int oldX, int oldY, int newX, int newY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasTileAt(int x, int y, string layer, string tilesheetId = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasTileAt(Location tile, string layer, string tilesheetId = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasTileAt(Point tile, string layer, string tilesheetId = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTileIndexAt(Location p, string layer, string tilesheetId = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTileIndexAt(Point p, string layer, string tilesheetId = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTileIndexAt(int x, int y, string layer, string tilesheetId = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getTileSheetIDAt(int x, int y, string layer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBuildingConstructed(Building building, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBuildingMoved(Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBuildingDemolished(string type, Guid id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDayStarted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStoneDestroyed(string stoneId, int x, int y, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool breakStone(string stoneId, int x, int y, Farmer who, Random r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBehindBush(Vector2 Tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBehindTree(Vector2 Tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnObjects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNotWaterTileAndNotNullTile(Location location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOnMap(Location location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool NeighboursLand(Location location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DistanceToNeighboursLand(Location location, int distance = 2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void spawnWeedsAndStones(int numDebris = -1, bool weedsOnly = false, bool spawnFromOldWeeds = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Use removeObjectsAndSpawned instead.")]
	public virtual void removeEverythingExceptCharactersFromThisTile(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void removeObjectsAndSpawned(int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getFootstepSoundReplacement(string footstep)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void removeEverythingFromThisTile(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TryGetLocationEvents(out string assetName, out Dictionary<string, string> events)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidLocationEvent(string key, string eventScript)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void checkForEvents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Event findEventById(string id, Farmer farmerActor = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void startEvent(Event evt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawBackground(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawWater(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawWaterTile(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawWaterTile(SpriteBatch b, int x, int y, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawFloorDecorations(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite getTemporarySpriteByID(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawDebris(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool shouldHideCharacters()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void drawCharacters(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void drawFarmers(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawFarmerUsernames(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawOverlays(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawAboveFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawLightGlows(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object tryToCreateUnseenSecretNote(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performToolAction(Tool t, int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void seasonUpdate(bool onLoad = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<FarmAnimal> getAllFarmAnimals()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetHayCapacity()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckPetAnimal(Vector2 position, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckPetAnimal(Microsoft.Xna.Framework.Rectangle rect, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInspectAnimal(Vector2 position, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInspectAnimal(Microsoft.Xna.Framework.Rectangle rect, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateSeasonalTileSheets(Map map = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSeasonalTilesheetName(string sheet_path, string current_season)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string checkEventPrecondition(string precondition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string checkEventPrecondition(string precondition, bool check_seen)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Object GetHayFromAnySilo(GameLocation currentLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int StoreHayInAnySilo(int count, GameLocation currentLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int tryToAddHay(int num)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Building getBuildingAt(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Building getBuildingByType(string type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Building getBuildingById(Guid id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Building getBuildingByName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool destroyStructure(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool destroyStructure(Building building)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool buildStructure(Building building, Vector2 tileLocation, Farmer who, bool skipSafetyChecks = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool buildStructure(string typeId, BuildingData data, Vector2 tileLocation, Farmer who, out Building constructed, bool magicalConstruction = false, bool skipSafetyChecks = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool buildStructure(string typeId, Vector2 tileLocation, Farmer who, out Building constructed, bool magicalConstruction = false, bool skipSafetyChecks = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBuildingConstructed(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasMinBuildings(string buildingType, int minCount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasMinBuildings(Func<Building, bool> match, int minCount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getNumberBuildingsConstructed(bool includeUnderConstruction = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getNumberBuildingsConstructed(string name, bool includeUnderConstruction = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isThereABuildingUnderConstruction()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GameLocation> GetInstancedBuildingInteriors()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForEachInstancedInterior(Func<GameLocation, bool> action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForEachDirt(Func<HoeDirt, bool> action, bool includeGardenPots = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isPath(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBuildable(Vector2 tileLocation, bool onlyNeedsToBePassable = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void pokeTileForConstruction(Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateWarps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadWeeds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanLoadPathObjectHere(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadObjects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadPathsLayerObjectsInArea(int startingX, int startingY, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetTreeIdForTile(Tile tile, out string treeId, out int? growthStageOnLoad, out int? growthStageOnRegrow, out bool isFruitTree)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuildStartingCabins()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateDoors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Use removeObjectsAndSpawned instead.")]
	private void clearArea(int startingX, int startingY, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTerrainFeatureAt(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadLights()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isFarmBuildingInterior()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActiveLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBeRemotedlyViewed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void adjustMapLightPropertiesForLamp(int tile, int x, int y, string layer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void changeMapProperties(string propertyName, string toAdd)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogMapPropertyError(string name, string value, string error)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogMapPropertyError(string name, string[] value, string error, char delimiter = ' ')
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTilePropertyError(string name, string layerId, int x, int y, string value, string error)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTilePropertyError(string name, string layerId, int x, int y, string[] value, string error, char delimiter = ' ')
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void testToDrawShopIconAnim(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool npcAtCounter(string name, int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void drawShopIconAnim(SpriteBatch b, int tileX, int tileY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool containsNPCAlready(NPC npc)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeCharactersWithNullLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTileActionError(string[] action, int x, int y, string error)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTileTouchActionError(string[] action, Vector2 tile, string error)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(GameLocation other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
