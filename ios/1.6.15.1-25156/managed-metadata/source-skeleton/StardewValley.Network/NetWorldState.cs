using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Buildings;
using StardewValley.Quests;

namespace StardewValley.Network;

public class NetWorldState : INetObject<NetFields>
{
	protected readonly NetLong uniqueIDForThisGame;

	protected readonly NetEnum<ServerPrivacy> serverPrivacy;

	protected readonly NetInt whichFarm;

	protected readonly NetString whichModFarm;

	protected string _oldModFarmType;

	public readonly NetEnum<MineChestType> shuffleMineChests;

	public readonly NetInt minesDifficulty;

	public readonly NetInt skullCavesDifficulty;

	public readonly NetInt highestPlayerLimit;

	public readonly NetInt currentPlayerLimit;

	protected readonly NetInt year;

	protected readonly NetEnum<Season> season;

	protected readonly NetInt dayOfMonth;

	protected readonly NetInt timeOfDay;

	protected readonly NetInt daysPlayed;

	public readonly NetInt visitsUntilY1Guarantee;

	protected readonly NetBool isPaused;

	protected readonly NetBool isTimePaused;

	protected readonly NetStringDictionary<LocationWeather, NetRef<LocationWeather>> locationWeather;

	protected readonly NetBool isRaining;

	protected readonly NetBool isSnowing;

	protected readonly NetBool isLightning;

	protected readonly NetBool isDebrisWeather;

	public readonly NetString weatherForTomorrow;

	protected readonly NetBundles bundles;

	protected readonly NetIntDictionary<bool, NetBool> bundleRewards;

	protected readonly NetStringDictionary<string, NetString> netBundleData;

	protected Dictionary<string, string> _bundleData;

	protected bool _bundleDataDirty;

	public readonly NetArray<bool, NetBool> raccoonBundles;

	public readonly NetInt seasonOfCurrentRacconBundle;

	public readonly NetBool parrotPlatformsUnlocked;

	public readonly NetBool goblinRemoved;

	public readonly NetBool submarineLocked;

	public readonly NetInt lowestMineLevel;

	public readonly NetInt lowestMineLevelForOrder;

	protected readonly NetVector2Dictionary<string, NetString> museumPieces;

	protected readonly NetIntDelta lostBooksFound;

	protected readonly NetIntDelta goldenWalnuts;

	protected readonly NetIntDelta goldenWalnutsFound;

	protected readonly NetBool goldenCoconutCracked;

	protected readonly NetStringHashSet foundBuriedNuts;

	protected readonly NetIntDelta miniShippingBinsObtained;

	protected readonly NetIntDelta perfectionWaivers;

	protected readonly NetIntDelta timesFedRaccoons;

	protected readonly NetIntDelta treasureTotemsUsed;

	public NetLongDictionary<Farmer, NetRef<Farmer>> farmhandData;

	public readonly NetStringHashSet locationsWithBuildings;

	public NetStringDictionary<BuilderData, NetRef<BuilderData>> builders;

	public NetStringHashSet activePassiveFestivals;

	protected readonly NetStringHashSet worldStateIDs;

	protected readonly NetStringHashSet islandVisitors;

	protected readonly NetStringHashSet checkedGarbage;

	public readonly NetRef<Object> dishOfTheDay;

	private readonly NetBool activatedGoldenParrot;

	private readonly NetInt daysPlayedWhenLastRaccoonBundleWasFinished;

	public readonly NetBool canDriveYourselfToday;

	public readonly NetBool goldenClocksTurnedOff;

	protected readonly NetRef<Quest> netQuestOfTheDay;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ServerPrivacy ServerPrivacy
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

	public MineChestType ShuffleMineChests
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

	public int MinesDifficulty
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

	public int SkullCavesDifficulty
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

	public int HighestPlayerLimit
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

	public int CurrentPlayerLimit
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

	public WorldDate Date
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int VisitsUntilY1Guarantee
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

	public bool IsPaused
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

	public bool IsTimePaused
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

	public NetStringDictionary<LocationWeather, NetRef<LocationWeather>> LocationWeather
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string WeatherForTomorrow
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

	public NetBundles Bundles
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public NetIntDictionary<bool, NetBool> BundleRewards
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Dictionary<string, string> BundleData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool ParrotPlatformsUnlocked
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

	public bool IsGoblinRemoved
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

	public bool IsSubmarineLocked
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

	public int LowestMineLevel
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

	public int LowestMineLevelForOrder
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

	public NetVector2Dictionary<string, NetString> MuseumPieces
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int LostBooksFound
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

	public int GoldenWalnuts
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

	public int GoldenWalnutsFound
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

	public bool GoldenCoconutCracked
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

	public bool ActivatedGoldenParrot
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

	public ISet<string> FoundBuriedNuts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int MiniShippingBinsObtained
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

	public int PerfectionWaivers
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

	public int TimesFedRaccoons
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

	public int TreasureTotemsUsed
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

	public int SeasonOfCurrentRacconBundle
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

	public int DaysPlayedWhenLastRaccoonBundleWasFinished
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

	public ISet<string> LocationsWithBuildings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public NetStringDictionary<BuilderData, NetRef<BuilderData>> Builders
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ISet<string> ActivePassiveFestivals
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ISet<string> IslandVisitors
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ISet<string> CheckedGarbage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Object DishOfTheDay
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

	public Quest QuestOfTheDay
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetWorldState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RegisterSpecialCurrencies()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetQuestOfTheDay(Quest quest)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBundleData(Dictionary<string, string> data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool checkAnywhereForWorldStateID(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addWorldStateIDEverywhere(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateBundleDisplayNames()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasWorldStateID(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addWorldStateID(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeWorldStateID(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveFarmhand(NetFarmerRoot farmhand)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetFarmhandState(Farmer farmhand)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAssignFarmhandHome(Farmer farmhand)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromGame1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocationWeather GetWeatherForLocation(string locationContextId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteToGame1(bool onLoad = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuilderData GetBuilderData(string builderName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkUnderConstruction(string builderName, Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateUnderConstruction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBuildingCache(GameLocation location)
	{
	}
}
