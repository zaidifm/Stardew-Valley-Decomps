using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using StardewValley.Characters;
using StardewValley.GameData.Characters;
using StardewValley.Locations;
using StardewValley.Menus;
using StardewValley.Minigames;
using StardewValley.Network;
using StardewValley.SaveMigrations;
using StardewValley.SpecialOrders;
using StardewValley.Util;

namespace StardewValley;

public class SaveGame
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass114_0
	{
		public IEnumerator<int> loader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public <>c__DisplayClass114_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void <Save>b__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass122_0
	{
		public string file;

		public bool loadEmergencySave;

		public bool loadBackupSave;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public <>c__DisplayClass122_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void <getLoadEnumerator>b__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass122_1
	{
		public string error;

		public bool autoRecovered;

		public <>c__DisplayClass122_0 CS$<>8__locals1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public <>c__DisplayClass122_1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void <getLoadEnumerator>b__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class <Save>d__114 : IEnumerator<int>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private int <>2__current;

		public bool wholeBackup;

		public bool emergencyBackup;

		private <>c__DisplayClass114_0 <>8__1;

		private IEnumerator<int> <save>5__2;

		private Task <saveTask>5__3;

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
		public <Save>d__114(int <>1__state)
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
	private sealed class <getLoadEnumerator>d__122 : IEnumerator<int>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private int <>2__current;

		public string file;

		public bool loadEmergencySave;

		public bool loadBackupSave;

		private <>c__DisplayClass122_0 <>8__1;

		private <>c__DisplayClass122_1 <>8__2;

		private Stopwatch <stopwatch>5__2;

		private Task <readSaveTask>5__3;

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
		public <getLoadEnumerator>d__122(int <>1__state)
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
	private sealed class <getSaveEnumerator>d__116 : IEnumerator<int>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private int <>2__current;

		public bool emergencyBackup;

		public bool wholeBackup;

		private SaveGame <saveData>5__2;

		private string <finalDataName>5__3;

		private string <saveDirPath>5__4;

		private string <finalFarmerPath>5__5;

		private string <finalDataPath>5__6;

		private string <tempFarmerPath>5__7;

		private string <tempDataPath>5__8;

		private MemoryStream <mstream1>5__9;

		private MemoryStream <mstream2>5__10;

		private Stream <stream2>5__11;

		private byte[] <buffer1>5__12;

		private byte[] <buffer2>5__13;

		private XmlWriterSettings <settings>5__14;

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
		public <getSaveEnumerator>d__116(int <>1__state)
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

	public const string backupString = "_SVBAK";

	public const string emergencyBackupString = "_SVEMERG";

	public static string emergencySaveIndexPath;

	public static string backupSaveIndexPath;

	private static string tempCurrentLocationName;

	private static bool tempIsStructure;

	private static int tempTileX;

	private static int tempTileY;

	private static int tempDayOfMonth;

	private static int tempTimeOfDay;

	private static string tempCurrentSeason;

	private static bool tempOnHorseback;

	private static Horse loadedHorse;

	public static bool saveInProgress;

	public static string tempFilename;

	public static bool tempLoadEmergencySave;

	public static bool tempLoadBackupSave;

	public const string TempNameSuffix = "_STARDEWVALLEYSAVETMP";

	public const string BackupNameSuffix = "_old";

	public const bool PlatformSupportsBackups = true;

	[InstancedStatic]
	public static bool IsProcessing;

	[InstancedStatic]
	public static bool CancelToTitle;

	public Farmer player;

	public List<Farmer> farmhands;

	public List<GameLocation> locations;

	public string currentSeason;

	public string samBandName;

	public string elliottBookName;

	[XmlArray("mailbox")]
	public List<string> obsolete_mailbox;

	public HashSet<string> broadcastedMail;

	public HashSet<string> constructedBuildings;

	public HashSet<string> worldStateIDs;

	public int lostBooksFound;

	public int goldenWalnuts;

	public int goldenWalnutsFound;

	public int miniShippingBinsObtained;

	public bool mineShrineActivated;

	public bool skullShrineActivated;

	public bool goldenCoconutCracked;

	public bool parrotPlatformsUnlocked;

	public bool farmPerfect;

	public List<string> foundBuriedNuts;

	public List<string> checkedGarbage;

	public int visitsUntilY1Guarantee;

	public MineChestType shuffleMineChests;

	public int dayOfMonth;

	public int year;

	public int? countdownToWedding;

	public double dailyLuck;

	public ulong uniqueIDForThisGame;

	public bool weddingToday;

	public bool isRaining;

	public bool isDebrisWeather;

	public bool isLightning;

	public bool isSnowing;

	public bool shouldSpawnMonsters;

	public bool hasApplied1_3_UpdateChanges;

	public bool hasApplied1_4_UpdateChanges;

	public List<long> weddingsToday;

	[XmlElement("stats")]
	public Stats obsolete_stats;

	[InstancedStatic]
	public static SaveGame loaded;

	public float musicVolume;

	public float soundVolume;

	public Object dishOfTheDay;

	public int highestPlayerLimit;

	public int moveBuildingPermissionMode;

	public bool useLegacyRandom;

	public bool allowChatCheats;

	public bool hasDedicatedHost;

	public SerializableDictionary<string, LocationWeather> locationWeather;

	[XmlArrayItem("item")]
	public SaveablePair<string, BuilderData>[] builders;

	[XmlArrayItem("item")]
	public SaveablePair<string, string>[] bannedUsers;

	[XmlArrayItem("item")]
	public SaveablePair<string, string>[] bundleData;

	[XmlArrayItem("item")]
	public SaveablePair<string, int>[] limitedNutDrops;

	public long latestID;

	public Options options;

	[XmlArrayItem("item")]
	public SaveablePair<long, Options>[] splitscreenOptions;

	public SerializableDictionary<string, string> CustomData;

	[XmlArrayItem("item")]
	public SaveablePair<int, MineInfo>[] mine_permanentMineChanges;

	public int mine_lowestLevelReached;

	public string weatherForTomorrow;

	public string whichFarm;

	public int mine_lowestLevelReachedForOrder;

	public int skullCavesDifficulty;

	public int minesDifficulty;

	public int currentGemBirdIndex;

	public NetLeaderboards junimoKartLeaderboards;

	public List<SpecialOrder> specialOrders;

	public List<SpecialOrder> availableSpecialOrders;

	public List<string> completedSpecialOrders;

	public List<string> acceptedSpecialOrderTypes;

	public List<Item> returnedDonations;

	public List<Item> junimoChest;

	public Item[] shippingBin;

	[XmlArrayItem("item")]
	public SaveablePair<string, Item[]>[] globalInventories;

	public List<string> collectedNutTracker;

	[XmlArrayItem("item")]
	public SaveablePair<FarmerPair, Friendship>[] farmerFriendships;

	[XmlArrayItem("item")]
	public SaveablePair<int, long>[] cellarAssignments;

	public int timesFedRaccoons;

	public int treasureTotemsUsed;

	public int perfectionWaivers;

	public int seasonOfCurrentRaccoonBundle;

	public bool[] raccoonBundles;

	public bool activatedGoldenParrot;

	public int daysPlayedWhenLastRaccoonBundleWasFinished;

	public int lastAppliedSaveFix;

	public string gameVersion;

	public List<TutorialType> tutorialData;

	public List<TutorialShopLocation> shopLocationsVisited;

	public bool showTutorials;

	public static bool adjustForEmergencyWarp;

	public static bool saveFaulted;

	public string gameVersionLabel;

	public static bool emergencyBackupRestore;

	private static Vector2 emergencyPlayerPos;

	private static string emergencyPlayerLocationName;

	private static bool emergencyPlayerLocationIsStructure;

	private static int emergencyDayOfMonth;

	private static int emergencyTimeOfDay;

	private static string emergencySeason;

	public const long MEGS_SPACE_FOR_SAVE = 20L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSaveFix(SaveFixes fix)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<Save>d__114))]
	public static IEnumerator<int> Save(bool wholeBackup = false, bool emergencyBackup = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string FilterFileName(string fileName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<getSaveEnumerator>d__116))]
	public static IEnumerator<int> getSaveEnumerator(bool wholeBackup = false, bool emergencyBackup = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsNewGameSaveNameCollision(string save_name, string ps4_root)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Load(string filename, bool loadEmergencySave = false, bool loadBackupSave = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadFarmType()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SaveGame TryReadSaveFile(string file, string fileNameSuffix, bool loadEmergencySave, bool loadBackupSave, out string error)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SaveGame TryReadSaveFileWithFallback(string file, bool loadEmergencySave, bool loadBackupSave, out string error, out bool autoRecovered)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<getLoadEnumerator>d__122))]
	public static IEnumerator<int> getLoadEnumerator(string file, bool loadEmergencySave, bool loadBackupSave)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void loadDataToFarmer(Farmer target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void loadDataToLocations(List<GameLocation> fromLocations)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void initializeCharacter(NPC c, GameLocation location, bool emergencyLoad = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void backupSelected(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void mainSelected(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool checkForAndLoadEmergencySave()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool swapForOldSave()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string newerBackUpExists(string file)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void deleteEmergencySaveIfCalled(string saveName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setEmergencyDayAndTime()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DoEmergencyLoadRepair()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string oldBackUpExists(string file)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string partialOldBackUpExists(string file)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void HandleLoadError(string fileName, bool loadEmergencySave, bool loadBackupSave, bool partialBackup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeCharactersWithNullLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void forceCharactersToDefaultLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void deleteBackupIndices()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool checkForDiskFull()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MigrateLostVillagers(Dictionary<string, Tuple<NPC, GameLocation>> lostVillagers)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> GetFormerLocationNames()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> GetFormerNpcNames(Func<string, CharacterData, bool> filter)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LogVerbose(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LogDebug(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LogWarn(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LogError(string message, Exception exception = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveGame()
	{
	}
}
