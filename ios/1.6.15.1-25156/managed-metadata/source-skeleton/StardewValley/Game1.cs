using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Netcode;
using StardewValley.Audio;
using StardewValley.BellsAndWhistles;
using StardewValley.Buildings;
using StardewValley.Characters;
using StardewValley.Events;
using StardewValley.GameData;
using StardewValley.GameData.BigCraftables;
using StardewValley.GameData.Buildings;
using StardewValley.GameData.Characters;
using StardewValley.GameData.Crops;
using StardewValley.GameData.FarmAnimals;
using StardewValley.GameData.FloorsAndPaths;
using StardewValley.GameData.FruitTrees;
using StardewValley.GameData.LocationContexts;
using StardewValley.GameData.Locations;
using StardewValley.GameData.Objects;
using StardewValley.GameData.Pants;
using StardewValley.GameData.Pets;
using StardewValley.GameData.Shirts;
using StardewValley.GameData.Tools;
using StardewValley.GameData.Weapons;
using StardewValley.Hashing;
using StardewValley.Locations;
using StardewValley.Logging;
using StardewValley.Menus;
using StardewValley.Minigames;
using StardewValley.Mobile;
using StardewValley.Mods;
using StardewValley.Network;
using StardewValley.Network.Dedicated;
using StardewValley.Network.NetReady;
using StardewValley.Quests;
using StardewValley.SaveMigrations;
using StardewValley.TerrainFeatures;
using StardewValley.Util;
using xTile.Dimensions;
using xTile.Display;

namespace StardewValley;

[InstanceStatics]
public class Game1 : InstanceGame
{
	public enum MusicWaveBankState
	{
		NotInitialised,
		NotDownloaded,
		Created
	}

	private class MusicContextComparer : IEqualityComparer<MusicContext>
	{
		public static readonly MusicContextComparer Default;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MusicContext x, MusicContext y)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashCode(MusicContext b)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MusicContextComparer()
		{
		}
	}

	public delegate void afterFadeFunction();

	[CompilerGenerated]
	private sealed class <>c__DisplayClass866_0
	{
		public int overnightMinutesElapsed;

		public NetLongDictionary<NetList<Item, NetRef<Item>>, NetRef<NetList<Item, NetRef<Item>>>> additional_shipped_items;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public <>c__DisplayClass866_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool <_newDayAfterFade>b__2(GameLocation location)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool <_newDayAfterFade>b__3(GameLocation location)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[CompilerGenerated]
	private sealed class <GetLoadContentEnumerator>d__710 : IEnumerator<int>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private int <>2__current;

		public Game1 <>4__this;

		private int <step>5__2;

		int IEnumerator<int>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <GetLoadContentEnumerator>d__710(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class <_newDayAfterFade>d__866 : IEnumerator<int>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private int <>2__current;

		private <>c__DisplayClass866_0 <>8__1;

		private int <timeWentToSleep>5__2;

		private List<NPC> <divorceNPCs>5__3;

		private bool <yesterdayWasGreenRain>5__4;

		int IEnumerator<int>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <_newDayAfterFade>d__866(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class <getAllFarmhands>d__995 : IEnumerable<Farmer>, IEnumerable, IEnumerator<Farmer>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private Farmer <>2__current;

		private int <>l__initialThreadId;

		private NetDictionary<long, Farmer, NetRef<Farmer>, SerializableDictionary<long, Farmer>, NetLongDictionary<Farmer, NetRef<Farmer>>>.ValuesCollection.Enumerator <>7__wrap1;

		Farmer IEnumerator<Farmer>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <getAllFarmhands>d__995(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<Farmer> IEnumerable<Farmer>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[CompilerGenerated]
	private sealed class <getOfflineFarmhands>d__996 : IEnumerable<Farmer>, IEnumerable, IEnumerator<Farmer>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private Farmer <>2__current;

		private int <>l__initialThreadId;

		private NetDictionary<long, Farmer, NetRef<Farmer>, SerializableDictionary<long, Farmer>, NetLongDictionary<Farmer, NetRef<Farmer>>>.ValuesCollection.Enumerator <>7__wrap1;

		Farmer IEnumerator<Farmer>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <getOfflineFarmhands>d__996(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<Farmer> IEnumerable<Farmer>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[NonInstancedStatic]
	public static string savesPath;

	[NonInstancedStatic]
	public static string hiddenSavesPath;

	[NonInstancedStatic]
	public static string screenshotsPath;

	[NonInstancedStatic]
	public static readonly CloudSync CloudSync;

	[NonInstancedStatic]
	public static int xEdge;

	[NonInstancedStatic]
	public static int toolbarPaddingX;

	[NonInstancedStatic]
	public static Microsoft.Xna.Framework.Rectangle clientBounds;

	[NonInstancedStatic]
	internal static bool linkedChallengeNew;

	[NonInstancedStatic]
	internal static MobileChallengeType linkedChallenge;

	[NonInstancedStatic]
	internal static object linkedChallengeMutex;

	private ButtonState _lastBackButtonState;

	public const float tapHoldTime = 0.5f;

	public const int headerOffset = 16;

	[NonInstancedStatic]
	public static int maxItemSlotSize;

	[NonInstancedStatic]
	public static bool skipTutorials;

	[NonInstancedStatic]
	public static bool emergencyLoading;

	public static bool SeenConcernedApeLogo;

	public const string titleButtonsTextureName = "Minigames\\TitleButtons";

	[NonInstancedStatic]
	public static Texture2D titleButtonsTexture;

	[NonInstancedStatic]
	public static int logoFadeTimer;

	private int _greenSquareAnimIndex;

	private long _greenSquareLastUpdateTicks;

	private Object _lastActiveObject;

	private string _lastLocation;

	[NonInstancedStatic]
	private static string _pendingTrackName;

	[NonInstancedStatic]
	private static IEnumerator<int> locationLoader;

	[NonInstancedStatic]
	private static IEnumerator<int> farmerLoader;

	[NonInstancedStatic]
	private static IEnumerator<int> wholeBackupLoader;

	[NonInstancedStatic]
	private static bool unlockedMultiplayer;

	public static VirtualJoypad virtualJoypad;

	public static Texture2D mobileSpriteSheet;

	[NonInstancedStatic]
	public static MusicWaveBankState musicWaveBankState;

	public const bool IncrementalLoadEnabled = true;

	public const int pixelZoom = 4;

	public const int tileSize = 64;

	public const int smallestTileSize = 16;

	public const int up = 0;

	public const int right = 1;

	public const int down = 2;

	public const int left = 3;

	public const int dialogueBoxTileHeight = 5;

	public static int realMilliSecondsPerGameMinute;

	public static int realMilliSecondsPerGameTenMinutes;

	public const int rainDensity = 70;

	public const int rainLoopLength = 70;

	public static readonly int cursor_none;

	public static readonly int cursor_default;

	public static readonly int cursor_wait;

	public static readonly int cursor_grab;

	public static readonly int cursor_gift;

	public static readonly int cursor_talk;

	public static readonly int cursor_look;

	public static readonly int cursor_harvest;

	public static readonly int cursor_gamepad_pointer;

	public static readonly string asianSpacingRegexString;

	public const int legacy_weather_sunny = 0;

	public const int legacy_weather_rain = 1;

	public const int legacy_weather_debris = 2;

	public const int legacy_weather_lightning = 3;

	public const int legacy_weather_festival = 4;

	public const int legacy_weather_snow = 5;

	public const int legacy_weather_wedding = 6;

	public const string weather_sunny = "Sun";

	public const string weather_rain = "Rain";

	public const string weather_green_rain = "GreenRain";

	public const string weather_debris = "Wind";

	public const string weather_lightning = "Storm";

	public const string weather_festival = "Festival";

	public const string weather_snow = "Snow";

	public const string weather_wedding = "Wedding";

	public const string builder_robin = "Robin";

	public const string builder_wizard = "Wizard";

	public const string shop_adventurersGuild = "AdventureShop";

	public const string shop_adventurersGuildItemRecovery = "AdventureGuildRecovery";

	public const string shop_animalSupplies = "AnimalShop";

	public const string shop_blacksmith = "Blacksmith";

	public const string shop_blacksmithUpgrades = "ClintUpgrade";

	public const string shop_boxOffice = "BoxOffice";

	public const string shop_catalogue = "Catalogue";

	public const string shop_carpenter = "Carpenter";

	public const string shop_casino = "Casino";

	public const string shop_desertTrader = "DesertTrade";

	public const string shop_dwarf = "Dwarf";

	public const string shop_fish = "FishShop";

	public const string shop_furnitureCatalogue = "Furniture Catalogue";

	public const string shop_generalStore = "SeedShop";

	public const string shop_hatMouse = "HatMouse";

	public const string shop_hospital = "Hospital";

	public const string shop_iceCreamStand = "IceCreamStand";

	public const string shop_islandTrader = "IslandTrade";

	public const string shop_jojaMart = "Joja";

	public const string shop_krobus = "ShadowShop";

	public const string shop_qiGemShop = "QiGemShop";

	public const string shop_resortBar = "ResortBar";

	public const string shop_sandy = "Sandy";

	public const string shop_saloon = "Saloon";

	public const string shop_travelingCart = "Traveler";

	public const string shop_volcanoShop = "VolcanoShop";

	public const string shop_bookseller = "Bookseller";

	public const string shop_bookseller_trade = "BooksellerTrade";

	public const string shop_jojaCatalogue = "JojaFurnitureCatalogue";

	public const string shop_wizardCatalogue = "WizardFurnitureCatalogue";

	public const string shop_junimoCatalogue = "JunimoFurnitureCatalogue";

	public const string shop_retroCatalogue = "RetroFurnitureCatalogue";

	public const string shop_trashCatalogue = "TrashFurnitureCatalogue";

	public const string shop_petAdoption = "PetAdoption";

	public const byte singlePlayer = 0;

	public const byte multiplayerClient = 1;

	public const byte multiplayerServer = 2;

	public const byte logoScreenGameMode = 4;

	public const byte titleScreenGameMode = 0;

	public const byte loadScreenGameMode = 1;

	public const byte newGameMode = 2;

	public const byte playingGameMode = 3;

	public const byte loadingMode = 6;

	public const byte saveMode = 7;

	public const byte saveCompleteMode = 8;

	public const byte selectGameScreen = 9;

	public const byte creditsMode = 10;

	public const byte errorLogMode = 11;

	public static readonly string GameAssemblyName;

	public static readonly string version;

	public static readonly string versionLabel;

	public static readonly int versionBuildNumber;

	public const float keyPollingThreshold = 650f;

	public const float toolHoldPerPowerupLevel = 600f;

	public const float startingMusicVolume = 1f;

	public LocalizedContentManager xTileContent;

	public static DelayedAction morningSongPlayAction;

	internal static LocalizedContentManager _temporaryContent;

	[NonInstancedStatic]
	private static bool FinishedIncrementalLoad;

	[NonInstancedStatic]
	private static bool FinishedFirstLoadContent;

	[NonInstancedStatic]
	private static volatile bool FinishedFirstInitSounds;

	[NonInstancedStatic]
	private static volatile bool FinishedFirstInitSerializers;

	[NonInstancedStatic]
	private static IEnumerator<int> LoadContentEnumerator;

	[NonInstancedStatic]
	public static GraphicsDeviceManager graphics;

	[NonInstancedStatic]
	public static LocalizedContentManager content;

	public static SpriteBatch spriteBatch;

	[NonInstancedStatic]
	public static readonly Mutex RenderLock;

	public static float MusicDuckTimer;

	public static GamePadState oldPadState;

	public static float thumbStickSensitivity;

	public static float runThreshold;

	public static int rightStickHoldTime;

	public static int emoteMenuShowTime;

	public static int nextFarmerWarpOffsetX;

	public static int nextFarmerWarpOffsetY;

	public static KeyboardState oldKBState;

	public static MouseState oldMouseState;

	[NonInstancedStatic]
	public static Game1 keyboardFocusInstance;

	internal static Farmer _player;

	public static NetFarmerRoot serverHost;

	internal static bool _isWarping;

	[NonInstancedStatic]
	public static bool hasLocalClientsOnly;

	protected bool _instanceIsPlayingBackgroundMusic;

	protected bool _instanceIsPlayingOutdoorsAmbience;

	protected bool _instanceIsPlayingNightAmbience;

	protected bool _instanceIsPlayingTownMusic;

	protected bool _instanceIsPlayingMorningSong;

	public static bool isUsingBackToFrontSorting;

	internal static StringBuilder _debugStringBuilder;

	[NonInstancedStatic]
	internal static readonly DebugTimings debugTimings;

	public static Dictionary<string, GameLocation> _locationLookup;

	public readonly List<GameLocation> _locations;

	public static Regex asianSpacingRegex;

	public static Viewport defaultDeviceViewport;

	public static LocationRequest locationRequest;

	public static bool warpingForForcedRemoteEvent;

	internal static GameLocation _PreviousNonNullLocation;

	public GameLocation instanceGameLocation;

	public static IDisplayDevice mapDisplayDevice;

	public static xTile.Dimensions.Rectangle viewport;

	public static xTile.Dimensions.Rectangle uiViewport;

	public static Texture2D objectSpriteSheet;

	public static Texture2D cropSpriteSheet;

	public static Texture2D emoteSpriteSheet;

	public static Texture2D debrisSpriteSheet;

	public static Texture2D rainTexture;

	public static Texture2D bigCraftableSpriteSheet;

	public static Texture2D buffsIcons;

	public static Texture2D daybg;

	public static Texture2D nightbg;

	public static Texture2D menuTexture;

	public static Texture2D uncoloredMenuTexture;

	public static Texture2D lantern;

	public static Texture2D windowLight;

	public static Texture2D sconceLight;

	public static Texture2D cauldronLight;

	public static Texture2D shadowTexture;

	public static Texture2D mouseCursors;

	public static Texture2D mouseCursors2;

	public static Texture2D mouseCursors_1_6;

	public static Texture2D giftboxTexture;

	public static Texture2D controllerMaps;

	public static Texture2D indoorWindowLight;

	public static Texture2D animations;

	public static Texture2D concessionsSpriteSheet;

	public static Texture2D birdsSpriteSheet;

	public static Texture2D objectSpriteSheet_2;

	public static Texture2D bobbersTexture;

	public static Dictionary<string, Stack<Dialogue>> npcDialogues;

	protected readonly List<Farmer> _farmerShadows;

	public static Queue<Action> morningQueue;

	[NonInstancedStatic]
	protected internal static ModHooks hooks;

	public static InputState input;

	internal static IInputSimulator inputSimulator;

	public const string concessionsSpriteSheetName = "LooseSprites\\Concessions";

	public const string cropSpriteSheetName = "TileSheets\\crops";

	public const string objectSpriteSheetName = "Maps\\springobjects";

	public const string animationsName = "TileSheets\\animations";

	public const string mouseCursorsName = "LooseSprites\\Cursors";

	public const string mouseCursors2Name = "LooseSprites\\Cursors2";

	public const string mouseCursors1_6Name = "LooseSprites\\Cursors_1_6";

	public const string giftboxName = "LooseSprites\\Giftbox";

	public const string toolSpriteSheetName = "TileSheets\\tools";

	public const string bigCraftableSpriteSheetName = "TileSheets\\Craftables";

	public const string debrisSpriteSheetName = "TileSheets\\debris";

	public const string parrotSheetName = "LooseSprites\\parrots";

	public const string hatsSheetName = "Characters\\Farmer\\hats";

	public const string bobbersTextureName = "TileSheets\\bobbers";

	internal static Texture2D _toolSpriteSheet;

	public static Dictionary<Vector2, int> crabPotOverlayTiles;

	internal static bool _setSaveName;

	internal static string _currentSaveName;

	public static List<string> mailDeliveredFromMailForTomorrow;

	internal static RenderTarget2D _lightmap;

	public static Texture2D[] dynamicPixelRects;

	public static Texture2D fadeToBlackRect;

	public static Texture2D staminaRect;

	public static Texture2D lightingRect;

	public static SpriteFont dialogueFont;

	public static SpriteFont smallFont;

	public static SpriteFont tinyFont;

	public static float screenGlowAlpha;

	public static float flashAlpha;

	public static float noteBlockTimer;

	public static int currentGemBirdIndex;

	public Dictionary<string, object> newGameSetupOptions;

	public static bool dialogueUp;

	public static bool dialogueTyping;

	public static bool isQuestion;

	public static bool newDay;

	public static bool eventUp;

	public static bool viewportFreeze;

	public static bool eventOver;

	public static bool screenGlow;

	public static bool screenGlowHold;

	public static bool screenGlowUp;

	public static bool killScreen;

	public static bool messagePause;

	public static bool weddingToday;

	public static bool exitToTitle;

	public static bool debugMode;

	public static bool displayHUD;

	public static bool displayFarmer;

	public static bool dialogueButtonShrinking;

	public static bool drawLighting;

	public static bool quit;

	public static bool drawGrid;

	public static bool freezeControls;

	public static bool saveOnNewDay;

	public static bool panMode;

	public static bool showingEndOfNightStuff;

	public static bool wasRainingYesterday;

	public static bool hasLoadedGame;

	public static bool isActionAtCurrentCursorTile;

	public static bool isInspectionAtCurrentCursorTile;

	public static bool isSpeechAtCurrentCursorTile;

	public static bool paused;

	public static bool isTimePaused;

	public static bool frameByFrame;

	public static bool lastCursorMotionWasMouse;

	public static bool showingHealth;

	public static bool cabinsSeparate;

	public static bool showingHealthBar;

	public static bool hasStartedDay;

	public static HashSet<string> eventsSeenSinceLastLocationChange;

	internal static bool hasApplied1_3_UpdateChanges;

	internal static bool hasApplied1_4_UpdateChanges;

	internal static Action postExitToTitleCallback;

	protected int _lastUsedDisplay;

	public bool wasAskedLeoMemory;

	public float controllerSlingshotSafeTime;

	public static BundleType bundleType;

	public static bool isRaining;

	public static bool isSnowing;

	public static bool isLightning;

	public static bool isDebrisWeather;

	internal static bool _isGreenRain;

	internal static bool wasGreenRain;

	internal static bool greenRainNeedsCleanup;

	public static Season? debrisWeatherSeason;

	public static string weatherForTomorrow;

	public float zoomModifier;

	internal static ScreenFade screenFade;

	public static Season season;

	public static SerializableDictionary<string, string> bannedUsers;

	internal static object _debugOutputLock;

	internal static string _debugOutput;

	public static string requestedMusicTrack;

	public static string messageAfterPause;

	public static string samBandName;

	public static string loadingMessage;

	public static string errorMessage;

	protected Dictionary<MusicContext, KeyValuePair<string, bool>> _instanceRequestedMusicTracks;

	protected MusicContext _instanceActiveMusicContext;

	public static bool requestedMusicTrackOverrideable;

	public static bool currentTrackOverrideable;

	public static bool requestedMusicDirty;

	protected bool _useUnscaledLighting;

	public bool _didInitiateItemStow;

	public bool instanceIsOverridingTrack;

	[NonInstancedStatic]
	private static string[] _shortDayDisplayName;

	public static Queue<string> currentObjectDialogue;

	public static HashSet<string> worldStateIDs;

	public static List<Response> questionChoices;

	public static int xLocationAfterWarp;

	public static int yLocationAfterWarp;

	public static int gameTimeInterval;

	public static int currentQuestionChoice;

	public static int currentDialogueCharacterIndex;

	public static int dialogueTypingInterval;

	public static int dayOfMonth;

	public static int year;

	public static int timeOfDay;

	public static int timeOfDayAfterFade;

	public static int dialogueWidth;

	public static int facingDirectionAfterWarp;

	public static int mouseClickPolling;

	public static int gamePadXButtonPolling;

	public static int gamePadAButtonPolling;

	public static int weatherIcon;

	public static int hitShakeTimer;

	public static int staminaShakeTimer;

	public static int pauseThenDoFunctionTimer;

	public static int cursorTileHintCheckTimer;

	public static int timerUntilMouseFade;

	public static int whichFarm;

	public static int startingCabins;

	public static ModFarmType whichModFarm;

	public static ulong? startingGameSeed;

	public static int elliottPiano;

	public static Microsoft.Xna.Framework.Rectangle viewportClampArea;

	public static SaveFixes lastAppliedSaveFix;

	public static Color eveningColor;

	public static Color unselectedOptionColor;

	public static Color screenGlowColor;

	public static NPC currentSpeaker;

	public static Random random;

	public static Random recentMultiplayerRandom;

	public static Dictionary<int, string> achievements;

	public static IDictionary<string, BigCraftableData> bigCraftableData;

	public static IDictionary<string, BuildingData> buildingData;

	public static IDictionary<string, CharacterData> characterData;

	public static IDictionary<string, CropData> cropData;

	public static IDictionary<string, FarmAnimalData> farmAnimalData;

	public static IDictionary<string, FloorPathData> floorPathData;

	public static IDictionary<string, FruitTreeData> fruitTreeData;

	public static IDictionary<string, JukeboxTrackData> jukeboxTrackData;

	public static IDictionary<string, LocationData> locationData;

	public static IDictionary<string, LocationContextData> locationContextData;

	public static IDictionary<string, string> NPCGiftTastes;

	public static IDictionary<string, ObjectData> objectData;

	public static IDictionary<string, PantsData> pantsData;

	public static IDictionary<string, PetData> petData;

	public static IDictionary<string, ShirtData> shirtData;

	public static IDictionary<string, ToolData> toolData;

	public static IDictionary<string, WeaponData> weaponData;

	public static List<HUDMessage> hudMessages;

	public static float musicPlayerVolume;

	public static float ambientPlayerVolume;

	public static float pauseAccumulator;

	public static float pauseTime;

	public static float upPolling;

	public static float downPolling;

	public static float rightPolling;

	public static float leftPolling;

	public static float debrisSoundInterval;

	public static float windGust;

	public static float dialogueButtonScale;

	public ICue instanceCurrentSong;

	public static IAudioCategory musicCategory;

	public static IAudioCategory soundCategory;

	public static IAudioCategory ambientCategory;

	public static IAudioCategory footstepCategory;

	public PlayerIndex instancePlayerOneIndex;

	[NonInstancedStatic]
	public static IAudioEngine audioEngine;

	[NonInstancedStatic]
	public static WaveBank waveBank;

	[NonInstancedStatic]
	public static WaveBank waveBank1_4;

	[NonInstancedStatic]
	public static ISoundBank soundBank;

	public static Vector2 previousViewportPosition;

	public static Vector2 currentCursorTile;

	public static Vector2 lastCursorTile;

	public static Vector2 snowPos;

	public Microsoft.Xna.Framework.Rectangle localMultiplayerWindow;

	public static List<RainDrop> rainDrops;

	public static ICue chargeUpSound;

	public static ICue wind;

	public static LoopingCueManager loopingLocationCues;

	public static ISoundsHelper sounds;

	[NonInstancedStatic]
	public static AudioCueModificationManager CueModification;

	public static int baseDebrisWeatherCount;

	public static List<WeatherDebris> debrisWeatherPool;

	public static List<RainDrop> rainDropPool;

	public static List<WeatherDebris> debrisWeather;

	public static TemporaryAnimatedSpriteList screenOverlayTempSprites;

	public static TemporaryAnimatedSpriteList uiOverlayTempSprites;

	internal static byte _gameMode;

	private bool _isSaving;

	[NonInstancedStatic]
	protected internal static IGameLogger log;

	[NonInstancedStatic]
	public static IHashUtility hash;

	protected internal static Multiplayer multiplayer;

	public static byte multiplayerMode;

	public static IEnumerator<int> currentLoader;

	public static ulong uniqueIDForThisGame;

	public static int[] directionKeyPolling;

	public static Dictionary<string, LightSource> currentLightSources;

	public static Color ambientLight;

	public static Color outdoorLight;

	public static Color textColor;

	public static Color textShadowColor;

	public static Color textShadowDarkerColor;

	public static IClickableMenu overlayMenu;

	internal static IClickableMenu _activeClickableMenu;

	public static List<IClickableMenu> nextClickableMenu;

	public static List<Action> actionsWhenPlayerFree;

	public static bool isCheckingNonMousePlacement;

	internal static IMinigame _currentMinigame;

	protected static float _beforeMinigameScale;

	public static List<IClickableMenu> onScreenMenus;

	private const int _fpsHistory = 120;

	internal static List<float> _fpsList;

	internal static Stopwatch _fpsStopwatch;

	internal static float _fps;

	public static BuffsDisplay buffsDisplay;

	public static DayTimeMoneyBox dayTimeMoneyBox;

	public static NetRootDictionary<long, Farmer> otherFarmers;

	private static readonly FarmerCollection _onlineFarmers;

	public static IGameServer server;

	public static Client client;

	public KeyboardDispatcher instanceKeyboardDispatcher;

	public static Background background;

	public static FarmEvent farmEvent;

	public static FarmEvent farmEventOverride;

	public static afterFadeFunction afterFade;

	public static afterFadeFunction afterDialogues;

	public static afterFadeFunction afterViewport;

	public static afterFadeFunction viewportReachedTarget;

	public static afterFadeFunction afterPause;

	public static GameTime currentGameTime;

	public static IList<DelayedAction> delayedActions;

	public static Stack<IClickableMenu> endOfNightMenus;

	public Options instanceOptions;

	[NonInstancedStatic]
	public static SerializableDictionary<long, Options> splitscreenOptions;

	public static Game1 game1;

	public static Point lastMousePositionBeforeFade;

	public static int ticks;

	public static EmoteMenu emoteMenu;

	[NonInstancedStatic]
	public static SerializableDictionary<string, string> CustomData;

	public static ReadySynchronizer netReady;

	public static DedicatedServer dedicatedServer;

	public static NetRoot<NetWorldState> netWorldState;

	public static ChatBox chatBox;

	public TextEntryMenu instanceTextEntry;

	public static SpecialCurrencyDisplay specialCurrencyDisplay;

	public static bool drawbounds;

	internal static string debugPresenceString;

	public static List<Action> remoteEventQueue;

	public static List<long> weddingsToday;

	public int instanceIndex;

	public int instanceId;

	public static bool overrideGameMenuReset;

	protected bool _windowResizing;

	protected Point _oldMousePosition;

	protected bool _oldGamepadConnectedState;

	protected int _oldScrollWheelValue;

	public static Point viewportCenter;

	public static Vector2 viewportTarget;

	public static float viewportSpeed;

	public static int viewportHold;

	internal static bool _cursorDragEnabled;

	internal static bool _cursorDragPrevEnabled;

	internal static bool _cursorSpeedDirty;

	private const float CursorBaseSpeed = 16f;

	internal static float _cursorSpeed;

	internal static float _cursorSpeedScale;

	internal static float _cursorUpdateElapsedSec;

	internal static int thumbstickPollingTimer;

	public static bool toggleFullScreen;

	public static string whereIsTodaysFest;

	public const string NO_LETTER_MAIL = "%&NL&%";

	public const string BROADCAST_MAIL_FOR_TOMORROW_PREFIX = "%&MFT&%";

	public const string BROADCAST_SEEN_MAIL_PREFIX = "%&SM&%";

	public const string BROADCAST_MAILBOX_PREFIX = "%&MB&%";

	public bool isLocalMultiplayerNewDayActive;

	internal static Task _newDayTask;

	internal static Action _afterNewDayAction;

	public static NewDaySynchronizer newDaySync;

	public static bool forceSnapOnNextViewportUpdate;

	public static Vector2 currentViewportTarget;

	public static Vector2 viewportPositionLerp;

	public static float screenGlowRate;

	public static float screenGlowMax;

	public static bool haltAfterCheck;

	public static bool uiMode;

	public static RenderTarget2D nonUIRenderTarget;

	public static int uiModeCount;

	internal static int _oldUIModeCount;

	internal string panModeString;

	public static bool conventionMode;

	internal static EventTest eventTest;

	internal bool panFacingDirectionWait;

	public static bool isRunningMacro;

	public static int thumbstickMotionMargin;

	public static float thumbstickMotionAccell;

	public static int triggerPolling;

	public static int rightClickPolling;

	private RenderTarget2D _screen;

	private RenderTarget2D _uiScreen;

	public static Color bgColor;

	protected readonly BlendState lightingBlend;

	public bool isDrawing;

	[NonInstancedStatic]
	public static bool isRenderingScreenBuffer;

	protected bool _lastDrewMouseCursor;

	internal static int _activatedTick;

	public static int mouseCursor;

	internal static float _mouseCursorTransparency;

	public static bool wasMouseVisibleThisFrame;

	public static NPC objectDialoguePortraitPerson;

	internal static StringBuilder _ParseTextStringBuilder;

	internal static StringBuilder _ParseTextStringBuilderLine;

	internal static StringBuilder _ParseTextStringBuilderWord;

	public bool ScreenshotBusy;

	public bool takingMapScreenshot;

	public static bool UnlockedMultiplayer
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

	public static bool IsActiveClickableMenuNativeScaled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsActiveClickableMenuUnscaled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static float NativeZoomLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static float DateTimeScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static float DefaultMenuButtonScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsActiveNoOverlay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static LocalizedContentManager temporaryContent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private bool ShouldLoadIncrementally
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Farmer player
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

	public static bool IsPlayingBackgroundMusic
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

	public static bool IsPlayingOutdoorsAmbience
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

	public static bool IsPlayingNightAmbience
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

	public static bool IsPlayingTownMusic
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

	public static bool IsPlayingMorningSong
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

	public static bool isWarping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static List<GameLocation> locations
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static GameLocation currentLocation
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

	public static Texture2D toolSpriteSheet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static RenderTarget2D lightmap
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsHudDrawn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool isGreenRain
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

	public static bool spawnMonstersAtNight
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

	public static bool UseLegacyRandom
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

	public static bool fadeToBlack
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

	public static bool fadeIn
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

	public static bool globalFade
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

	public static bool nonWarpFade
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

	public static float fadeToBlackAlpha
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

	public static float globalFadeSpeed
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

	public static string CurrentSeasonDisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static string currentSeason
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

	public static int seasonIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static string debugOutput
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

	public static string elliottBookName
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

	protected static Dictionary<MusicContext, KeyValuePair<string, bool>> _requestedMusicTracks
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

	protected static MusicContext _activeMusicContext
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

	public static bool isOverridingTrack
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

	public bool useUnscaledLighting
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

	public static IList<string> mailbox
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static ICue currentSong
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

	public static PlayerIndex playerOneIndex
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

	public static int gameModeTicks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
		}
	}

	public static byte gameMode
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

	public bool IsSaving
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

	public static Multiplayer Multiplayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Stats stats
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Quest questOfTheDay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static IClickableMenu activeClickableMenu
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

	public static IMinigame currentMinigame
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

	public static Object dishOfTheDay
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

	public static KeyboardDispatcher keyboardDispatcher
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

	public static Options options
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

	public static TextEntryMenu textEntry
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

	public static WorldDate Date
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool NetTimePaused
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool HostPaused
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsMultiplayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsClient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsServer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsMasterGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsOnlineMultiplayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool HasDedicatedHost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsDedicatedHost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Farmer MasterPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsChatting
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

	public static Event CurrentEvent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static MineShaft mine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static int CurrentMineLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static int CurrentPlayerLimit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private static float thumbstickToMouseModifier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool isFullscreen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsSummer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsSpring
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsFall
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsWinter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public RenderTarget2D screen
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

	public RenderTarget2D uiScreen
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

	public static float mouseCursorTransparency
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

	public static bool ShowJustTheMinimalButtons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isGamePadConnected()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitializeRunner()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MobileLoadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _updateTapToMove(GameTime gameTime, MouseState currentMouseState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SetCurrentViewportTargetToCenterOnPlayer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _mobileUpdateControlInput(MouseState currentMouseState, out TapState tapState, ref bool moveupPressed, ref bool movedownPressed, ref bool moveleftPressed, ref bool moverightPressed, ref bool moveupReleased, ref bool movedownReleased, ref bool moveleftReleased, ref bool moverightReleased, ref bool moveupHeld, ref bool movedownHeld, ref bool moveleftHeld, ref bool moverightHeld, ref bool actionButtonPressed, ref bool useToolButtonPressed, ref bool useToolButtonReleased, ref bool useToolHeld)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _mobileProcessTaps(TapState tapState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetHasRoomAnotherFarm()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void askedToQuit(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _updateMobileMenus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadNewGameFromCharacterCustomization()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTapToMoveTarget()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawGreenPlacementBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckToClearLastObjectGreenPlacementSquares()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateMusicWaveBank()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeMusicWaveBank()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string FetchMusicXWBPath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _updateTutorialManager(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetLinkedChallenge()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void loadTitleTexture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void saveWholeBackup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void emergencyBackup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _updateWholeBackupLoader(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MakeFullBackup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawVirtualJoypad()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetHasRoomAnotherFarmAsync(ReportHasRoomAnotherFarmDelegate callback)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GameModeToString(byte mode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetVersionString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetToolSpriteSheet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetSaveName(string new_save_name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSaveGameName(bool set_value = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void allocateLightmap(int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool canHaveWeddingOnDay(int day, Season season)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RefreshQuestOfTheDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExitToTitle(Action postExitCallback = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Game1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Game1(PlayerIndex player_index, int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Game1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TranslateFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void exitEvent(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void refreshWindowSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Window_ClientSizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetWindowSize(int w, int h)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Game1_Exiting(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setGameMode(byte mode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateViewportForScreenSizeChange(bool fullscreenChange, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Instance_Initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsFading()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsFakedBlackScreen()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoThreadedInitTask(ThreadStart initTask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeSounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeSerializers()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void pauseThenDoFunction(int pauseTime, afterFadeFunction function)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected internal virtual LocalizedContentManager CreateContentManager(IServiceProvider serviceProvider, string rootDirectory)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected internal virtual IDisplayDevice CreateDisplayDevice(ContentManager content, GraphicsDevice graphicsDevice)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Instance_LoadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LoadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AfterLoadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<GetLoadContentEnumerator>d__710))]
	private IEnumerator<int> GetLoadContentEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetPlayer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetVariables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool playSound(string cueName, int? pitch = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool playSound(string cueName, out ICue cue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool playSound(string cueName, int pitch, out ICue cue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setRichPresence(string friendlyName, object argument = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GenerateBundles(BundleType bundle_type, bool use_seed = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNewGameOption<T>(string key, T val)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetNewGameOption<T>(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void loadForNewGame(bool loadedGame = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLocalCoopJoinable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartLocalMultiplayerIfNecessary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EndLocalMultiplayer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdatePassiveFestivalStates()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Instance_UnloadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UnloadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showRedMessage(string message, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showRedMessageUsingLoadString(string loadString, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool didPlayerJustLeftClick(bool ignoreNonMouseHeldInput = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool didPlayerJustRightClick(bool ignoreNonMouseHeldInput = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool didPlayerJustClickAtAll(bool ignoreNonMouseHeldInput = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showGlobalMessage(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void globalFadeToBlack(afterFadeFunction afterFade = null, float fadeSpeed = 0.02f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void globalFadeToClear(afterFadeFunction afterFade = null, float fadeSpeed = 0.02f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGamepadMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Instance_Update(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Instance_OnActivated(object sender, EventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnActivated(object sender, EventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasKeyboardFocus()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _update(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnDayStarted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PerformPassiveFestivalSetup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showTextEntry(TextBox text_box)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void closeTextEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isDarkOut(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isTimeToTurnOffLighting(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isStartingToGetDarkOut(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getStartingToGetDarkTime(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateCellarAssignments()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getModeratelyDarkTime(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getTrulyDarkTime(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void playMorningSong(bool ignoreDelay = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void doMorningStuff()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addMorningFluffFunction(Action action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Point getViewportCenter()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void afterFadeReturnViewportToPlayer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isViewportOnCustomPath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void moveViewportTo(Vector2 target, float speed, int holdTimer = 0, afterFadeFunction reachedTarget = null, afterFadeFunction endFunction = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Farm getFarm()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setMousePosition(int x, int y, bool ui_scale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setMousePosition(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setMousePosition(Point position, bool ui_scale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setMousePosition(Point position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setMousePositionRaw(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point getMousePositionRaw()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point getMousePosition(bool ui_scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point getMousePosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ComputeCursorSpeed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SetFreeCursorElapsed(float elapsedSec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetFreeCursorDrag()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetFreeCursorDrag()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateActiveMenu(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShowLocalCoopJoinMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateTextEntry(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DateCompiled()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updatePause(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void toggleNonBorderlessWindowedFullscreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void toggleFullscreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkForEscapeKeys()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPressEvent(ref KeyboardState state, Keys key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPressEvent(ref GamePadState state, Buttons btn)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isOneOfTheseKeysDown(KeyboardState state, InputButton[] keys)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool areAllOfTheseKeysUp(KeyboardState state, InputButton[] keys)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void UpdateTitleScreen(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void UpdateTitleScreenDuringLoadingMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsThereABuildingUnderConstruction(string builder = "Robin")
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Building GetBuildingUnderConstruction(string builder = "Robin")
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBuildingConstructed(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetNumberBuildingsConstructed(bool includeUnderConstruction = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetNumberBuildingsConstructed(string name, bool includeUnderConstruction = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateLocations(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _UpdateLocation(GameLocation location, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void performTenMinuteClockUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool shouldPlayMorningSong(bool loading_game = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateGameClock(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Event getAvailableWeddingEvent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void exitActiveMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void fadeScreenIn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PerformActionWhenPlayerFree(Action action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void fadeScreenToBlack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void fadeClear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool onFadeToBlackComplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnLocationChanged(GameLocation oldLocation, GameLocation newLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearDebrisWeather(List<WeatherDebris> debris)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void onFadedBackInComplete()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateOther(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateWeather(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateCursorTileHint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateMusic()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetDefaultSongPriority(string song_name, bool is_playing_override, Game1 instance)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateRainDropPositionForPlayerMovement(int direction, float speed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void initializeVolumeLevels()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateDebrisWeatherForMovement(List<WeatherDebris> debris, int direction, float speed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 updateFloatingObjectPositionForMovement(Vector2 w, Vector2 current, Vector2 previous, float speed)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateRaindropPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateDebrisWeatherForMovement(List<WeatherDebris> debris)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void randomizeRainPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void randomizeDebrisWeatherPositions(List<WeatherDebris> debris)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void eventFinished()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void populateDebrisWeatherArray(List<WeatherDebris> debris = null, int base_debris_count = -1, int debris_index = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetDebrisWeatherIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnNewSeason()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void prepareSpouseForWedding(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AddCharacterIfNecessary(string characterId, bool bypassConditions = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameLocation CreateGameLocation(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameLocation CreateGameLocation(string id, CreateLocationData createData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddNPCs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddModNPCs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void fixProblems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void checkIsMissingTool(Dictionary<Type, int> missingTools, ref int missingScythes, Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void newDayAfterFade(Action after)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanAcceptDailyQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<_newDayAfterFade>d__866))]
	private static IEnumerator<int> _newDayAfterFade()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateDishOfTheDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateFarmPerfection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGreenRainingHere(GameLocation location = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsRainingHere(GameLocation location = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsLightningHere(GameLocation location = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSnowingHere(GameLocation location = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsDebrisWeatherHere(GameLocation location = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getWeatherModificationsForDate(WorldDate date, string default_weather)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateWeatherForNewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ApplyWeatherForNewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateShopPlayerItemInventory(string location_name, HashSet<NPC> purchased_item_npcs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void handlePostFarmEventActions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReceiveMailForTomorrow(string mail_to_transfer = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveDeliveredMailForTomorrow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void queueWeddingsForToday()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PollForEndOfNewDaySync()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateWeatherIcon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showEndOfNightStuff()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setGraphicsForSeason(bool onLoad = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void pauseThenMessage(int millisecondsPause, string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsVisitingIslandToday(string npc_name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool shouldTimePass(bool ignore_multiplayer = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Farmer getPlayerOrEventFarmer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateViewPort(bool overrideFreeze, Point centerPoint)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateCharacters(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addMail(string mailName, bool noLetter = false, bool sendToEveryone = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addMailForTomorrow(string mailName, bool noLetter = false, bool sendToEveryone = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawDialogue(NPC speaker)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void multipleDialogues(string[] messages)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawDialogueNoTyping(string dialogue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawDialogueNoTyping(List<string> dialogues)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawAnsweringMachineDialogue(NPC npc, string translationKey, params object[] substitutions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawDialogue(NPC npc, string translationKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawDialogue(NPC npc, string translationKey, params object[] substitutions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawDialogue(Dialogue dialogue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void checkIfDialogueIsQuestion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawLetterMessage(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawObjectDialogue(string dialogue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawObjectDialogue(List<string> dialogue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawObjectQuestionDialogue(string dialogue, Response[] choices, int width)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawObjectQuestionDialogue(string dialogue, Response[] choices)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpCharacter(NPC character, string targetLocationName, Point position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpCharacter(NPC character, string targetLocationName, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpCharacter(NPC character, GameLocation targetLocation, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LocationRequest getLocationRequest(string locationName, bool isStructure = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpHome()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpFarmer(string locationName, int tileX, int tileY, bool flip)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpFarmer(string locationName, int tileX, int tileY, int facingDirectionAfterWarp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpFarmer(string locationName, int tileX, int tileY, int facingDirectionAfterWarp, bool isStructure)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldDismountOnWarp(Horse mount, GameLocation old_location, GameLocation new_location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpFarmer(LocationRequest locationRequest, int tileX, int tileY, int facingDirectionAfterWarp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void performWarpFarmer(LocationRequest locationRequest, int tileX, int tileY, int facingDirectionAfterWarp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void notifyServerOfWarp(bool needsLocationInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void requestLocationInfoFromServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetCharacterWhere<T>(Func<T, bool> check, bool includeEventActors = false) where T : NPC
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetCharacterOfType<T>(bool includeEventActors = false) where T : NPC
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T getCharacterFromName<T>(string name, bool mustBeVillager = true, bool includeEventActors = false) where T : NPC
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static NPC getCharacterFromName(string name, bool mustBeVillager = true, bool includeEventActors = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static NPC RequireCharacter(string name, bool mustBeVillager = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T RequireCharacter<T>(string name, bool mustBeVillager = true) where T : NPC
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameLocation RequireLocation(string name, bool isStructure = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TLocation RequireLocation<TLocation>(string name, bool isStructure = false) where TLocation : GameLocation
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameLocation getLocationFromName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameLocation getLocationFromName(string name, bool isStructure)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameLocation getLocationFromNameInLocationsList(string name, bool isStructure = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void flushLocationLookup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeLocationFromLocationLookup(string nameOrUniqueName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeLocationFromLocationLookup(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameLocation findStructure(GameLocation parentLocation, string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addNewFarmBuildingMaps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PassOutNewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void NewDay(float timeToPause)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void screenGlowOnce(Color glowColor, bool hold, float rate = 0.005f, float maxAlpha = 0.3f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string shortDayNameFromDayOfSeason(int dayOfSeason)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string shortDayDisplayNameFromDayOfSeason(int dayOfSeason)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void runTestEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isMusicContextActiveButNotPlaying(MusicContext music_context = MusicContext.Default)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsMusicContextActive(MusicContext music_context = MusicContext.Default)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool doesMusicContextHaveTrack(MusicContext music_context = MusicContext.Default)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getMusicTrackName(MusicContext music_context = MusicContext.Default)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void stopMusicTrack(MusicContext music_context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void changeMusicTrack(string newTrackName, bool track_interruptable = false, MusicContext music_context = MusicContext.Default)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateRequestedMusicTrack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void enterMine(int whatLevel, int? forceLayout = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Season GetSeasonForLocation(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetSeasonIndexForLocation(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSeasonKeyForLocation(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void getPlatformAchievement(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void getSteamAchievement(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void getAchievement(int which, bool allowBroadcasting = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createMultipleObjectDebris(string id, int xTile, int yTile, int number)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createMultipleObjectDebris(string id, int xTile, int yTile, int number, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createMultipleObjectDebris(string id, int xTile, int yTile, int number, float velocityMultiplier)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createMultipleObjectDebris(string id, int xTile, int yTile, int number, long who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createMultipleObjectDebris(string id, int xTile, int yTile, int number, long who, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createDebris(int debrisType, int xTile, int yTile, int numberOfChunks)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createDebris(int debrisType, int xTile, int yTile, int numberOfChunks, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Debris createItemDebris(Item item, Vector2 pixelOrigin, int direction, GameLocation location = null, int groundLevel = -1, bool flopFish = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createMultipleItemDebris(Item item, Vector2 pixelOrigin, int direction, GameLocation location = null, int groundLevel = -1, bool flopFish = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createRadialDebris(GameLocation location, int debrisType, int xTile, int yTile, int numberOfChunks, bool resource, int groundLevel = -1, bool item = false, Color? color = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createRadialDebris(GameLocation location, string texture, Microsoft.Xna.Framework.Rectangle sourcerectangle, int xTile, int yTile, int numberOfChunks)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createRadialDebris(GameLocation location, string texture, Microsoft.Xna.Framework.Rectangle sourcerectangle, int xTile, int yTile, int numberOfChunks, int groundLevelTile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createRadialDebris(GameLocation location, string texture, Microsoft.Xna.Framework.Rectangle sourcerectangle, int sizeOfSourceRectSquares, int xPosition, int yPosition, int numberOfChunks, int groundLevelTile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createRadialDebris_MoreNatural(GameLocation location, string texture, Microsoft.Xna.Framework.Rectangle sourcerectangle, int sizeOfSourceRectSquares, int xPosition, int yPosition, int numberOfChunks, int groundLevel)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createRadialDebris(GameLocation location, string texture, Microsoft.Xna.Framework.Rectangle sourcerectangle, int sizeOfSourceRectSquares, int xPosition, int yPosition, int numberOfChunks, int groundLevelTile, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createRadialDebris(GameLocation location, string texture, Microsoft.Xna.Framework.Rectangle sourcerectangle, int sizeOfSourceRectSquares, int xPosition, int yPosition, int numberOfChunks, int groundLevelTile, Color color, float scale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createObjectDebris(string id, int xTile, int yTile, long whichPlayer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createObjectDebris(string id, int xTile, int yTile, long whichPlayer, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createObjectDebris(string id, int xTile, int yTile, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createObjectDebris(string id, int xTile, int yTile, int groundLevel = -1, int itemQuality = 0, float velocityMultiplyer = 1f, GameLocation location = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Use GetPlayer instead. Equivalent usage: `GetPlayer(id, onlineOnly: true) ?? Game1.MasterPlayer`.")]
	public static Farmer getFarmer(long id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Use GetPlayer instead.")]
	public static Farmer getFarmerMaybeOffline(long id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Farmer? GetPlayer(long id, bool onlyOnline = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Farmer> getAllFarmers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FarmerCollection getOnlineFarmers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<getAllFarmhands>d__995))]
	public static IEnumerable<Farmer> getAllFarmhands()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<getOfflineFarmhands>d__996))]
	public static IEnumerable<Farmer> getOfflineFarmhands()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void farmerFindsArtifact(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool doesHUDMessageExist(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addHUDMessage(HUDMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showSwordswipeAnimation(int direction, Vector2 source, float animationSpeed, bool flip)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeDebris(Debris.DebrisType type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void toolAnimationDone(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool pressActionButton(KeyboardState currentKBState, MouseState currentMouseState, GamePadState currentPadState)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPerformingMousePlacement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 GetPlacementGrabTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool tryToCheckAt(Vector2 grabTile, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void pressSwitchToolButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool pressUseToolButton()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanPlayerStowItem(Vector2 position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMouseXRaw()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMouseYRaw()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsOnMainThread()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PushUIMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PopUIMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetRenderTarget(RenderTarget2D target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InUIMode(Action action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartWorldDrawInUI(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EndWorldDrawInUI(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMouseX()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMouseX(bool ui_scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getOldMouseX()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getOldMouseX(bool ui_scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMouseY()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMouseY(bool ui_scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getOldMouseY()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getOldMouseY(bool ui_scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PlayEvent(string eventId, GameLocation location, out bool validEvent, bool checkPreconditions = true, bool checkSeen = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PlayEvent(string eventId, bool checkPreconditions = true, bool checkSeen = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int numberOfPlayers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isFestival()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool parseDebugInput(string debugInput, IGameLogger log = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecountWalnuts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetIslandLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowTelephoneMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void requestDebugInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WeatherDebris GetWeatherDebris(Vector2 position, int which, float rotationVelocity, float dx, float dy)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RainDrop GetRainDrop(int x, int y, int frame, int accumulator)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panModeSuccess(KeyboardState currentKBState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updatePanModeControls(MouseState currentMouseState, KeyboardState currentKBState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isLocationAccessible(string locationName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isDPadPressed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isDPadPressed(GamePadState pad_state)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isGamePadThumbstickInMotion(double threshold = 0.2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isAnyGamePadButtonBeingPressed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isAnyGamePadButtonBeingHeld()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void UpdateChatBox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static KeyboardState GetKeyboardState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateControlInput(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanShowPauseMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void addHour()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void addMinute()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void checkForRunButton(KeyboardState kbState, bool ignoreKeyPressQualifier = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 getMostRecentViewportMotion()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DrawOverlays(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setBGColor(byte r, byte g, byte b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Instance_Draw(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Draw(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldDrawOnBuffer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ShouldShowOnscreenUsernames()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool checkCharacterTilesForShadowDrawFlag(Character character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _draw(GameTime gameTime, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawLoadScreen(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawMenu(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawScreenOverlaySprites(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawWorld(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawCharacterEmotes(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawLightmapOnScreen(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawDebugUIs(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawGlobalFade(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawLighting(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawWeather(GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void renderScreenBuffer(RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawSplitScreenWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawWithBorder(string message, Color borderColor, Color insideColor, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawWithBorder(string message, Color borderColor, Color insideColor, Vector2 position, float rotate, float scale, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawWithBorder(string message, Color borderColor, Color insideColor, Vector2 position, float rotate, float scale, float layerDepth, bool tiny)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isOutdoorMapSmallerThanViewport()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void drawHUD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InvalidateOldMouseMovement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsRenderingNonNativeUIScale()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawMouseCursor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void panScreen(int x, int y, int yOffset = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void clampViewportToGameMap(int yOffset = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 ClampViewportCornerToGameMap(Vector2 viewport_corner)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawDialogueBox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawDialogueBox(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawDialogueBox(int centerX, int centerY, bool speaker, bool drawOnlyBox, string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawBox(int x, int y, int width, int height, Color? color = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawDialogueBox(int x, int y, int width, int height, bool speaker, bool drawOnlyBox, string message = null, bool objectDialogueWithPortrait = false, bool ignoreTitleSafe = false, int r = -1, int g = -1, int b = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawPlayerHeldObject(Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawTool(Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawTool(Farmer f, int currentToolIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 GlobalToLocal(xTile.Dimensions.Rectangle viewport, Vector2 globalPosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsEnglish()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 GlobalToLocal(Vector2 globalPosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle GlobalToLocal(xTile.Dimensions.Rectangle viewport, Microsoft.Xna.Framework.Rectangle globalPosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string parseText(string text, SpriteFont whichFont, int width, float scale = 1f)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateHorseOwnership()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LoadStringByGender(Gender npcGender, string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LoadStringByGender(Gender npcGender, string key, params object[] substitutions)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string parseText(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle getSourceRectForStandardTileSheet(Texture2D tileSheet, int tilePosition, int width = -1, int height = -1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle getSquareSourceRectForNonStandardTileSheet(Texture2D tileSheet, int tileWidth, int tileHeight, int tilePosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle getArbitrarySourceRect(Texture2D tileSheet, int tileWidth, int tileHeight, int tilePosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getTimeOfDayString(int time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool[,] getCircleOutlineGrid(int radius)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFarmTypeID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFarmTypeKey()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PerformRemoveNormalItemOvernight(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _PerformRemoveNormalItemFromWorldOvernight(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _PerformRemoveNormalItemFromFarmerOvernight(Farmer farmer, string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool _RecursiveRemoveThisNormalItemItem(Item this_item, string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _RecursiveRemoveThisNormalItemDirt(HoeDirt dirt, GameLocation location, Vector2 coord, string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _RecursiveRemoveThisNormalItemLocation(GameLocation l, string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void _UpdateDebrisWeatherAndRainDropsForResize(xTile.Dimensions.Rectangle old_viewport, xTile.Dimensions.Rectangle new_viewport)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateDebrisWeatherForResize(List<WeatherDebris> debris, xTile.Dimensions.Rectangle old_viewport, xTile.Dimensions.Rectangle new_viewport, int base_count = -1, int debris_type = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static bool _IsWeatherDebrisOffScreen(Vector2 position, xTile.Dimensions.Rectangle viewport, int buffer = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static int _GetWeatherDebrisCountForViewportSize(int base_count, xTile.Dimensions.Rectangle screen)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static Vector2 _GetRandomPositionBetweenRectanglesForWeatherDebris(xTile.Dimensions.Rectangle a, xTile.Dimensions.Rectangle b, bool weather_particle = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetGameStateOnTitleScreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CleanupReturningToTitle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanTakeScreenshots()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetScreenshotFolder(bool createIfMissing = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanBrowseScreenshots()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanZoomScreenshots()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BrowseScreenshots()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string takeMapScreenshot(float? in_scale, string screenshot_name, Action onDone)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string takeMapScreenshot(GameLocation screenshotLocation, float scale, string screenshot_name, Action onDone)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void GetScreenshotRegion(GameLocation screenshotLocation, out int startX, out int startY, out int width, out int height)
	{
	}
}
