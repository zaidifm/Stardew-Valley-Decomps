using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace StardewValley;

public class Stats
{
	public StatsDictionary<int> specificMonstersKilled;

	public StatsDictionary<uint> Values;

	[XmlElement("stat_dictionary")]
	public SerializableDictionary<string, uint> obsolete_stat_dictionary;

	[XmlElement("averageBedtime")]
	public uint? obsolete_averageBedtime;

	[XmlElement("beveragesMade")]
	public uint? obsolete_beveragesMade;

	[XmlElement("caveCarrotsFound")]
	public uint? obsolete_caveCarrotsFound;

	[XmlElement("cheeseMade")]
	public uint? obsolete_cheeseMade;

	[XmlElement("chickenEggsLayed")]
	public uint? obsolete_chickenEggsLayed;

	[XmlElement("copperFound")]
	public uint? obsolete_copperFound;

	[XmlElement("cowMilkProduced")]
	public uint? obsolete_cowMilkProduced;

	[XmlElement("cropsShipped")]
	public uint? obsolete_cropsShipped;

	[XmlElement("daysPlayed")]
	public uint? obsolete_daysPlayed;

	[XmlElement("diamondsFound")]
	public uint? obsolete_diamondsFound;

	[XmlElement("dirtHoed")]
	public uint? obsolete_dirtHoed;

	[XmlElement("duckEggsLayed")]
	public uint? obsolete_duckEggsLayed;

	[XmlElement("fishCaught")]
	public uint? obsolete_fishCaught;

	[XmlElement("geodesCracked")]
	public uint? obsolete_geodesCracked;

	[XmlElement("giftsGiven")]
	public uint? obsolete_giftsGiven;

	[XmlElement("goatCheeseMade")]
	public uint? obsolete_goatCheeseMade;

	[XmlElement("goatMilkProduced")]
	public uint? obsolete_goatMilkProduced;

	[XmlElement("goldFound")]
	public uint? obsolete_goldFound;

	[XmlElement("goodFriends")]
	public uint? obsolete_goodFriends;

	[XmlElement("individualMoneyEarned")]
	public uint? obsolete_individualMoneyEarned;

	[XmlElement("iridiumFound")]
	public uint? obsolete_iridiumFound;

	[XmlElement("ironFound")]
	public uint? obsolete_ironFound;

	[XmlElement("itemsCooked")]
	public uint? obsolete_itemsCooked;

	[XmlElement("itemsCrafted")]
	public uint? obsolete_itemsCrafted;

	[XmlElement("itemsForaged")]
	public uint? obsolete_itemsForaged;

	[XmlElement("itemsShipped")]
	public uint? obsolete_itemsShipped;

	[XmlElement("monstersKilled")]
	public uint? obsolete_monstersKilled;

	[XmlElement("mysticStonesCrushed")]
	public uint? obsolete_mysticStonesCrushed;

	[XmlElement("notesFound")]
	public uint? obsolete_notesFound;

	[XmlElement("otherPreciousGemsFound")]
	public uint? obsolete_otherPreciousGemsFound;

	[XmlElement("piecesOfTrashRecycled")]
	public uint? obsolete_piecesOfTrashRecycled;

	[XmlElement("preservesMade")]
	public uint? obsolete_preservesMade;

	[XmlElement("prismaticShardsFound")]
	public uint? obsolete_prismaticShardsFound;

	[XmlElement("questsCompleted")]
	public uint? obsolete_questsCompleted;

	[XmlElement("rabbitWoolProduced")]
	public uint? obsolete_rabbitWoolProduced;

	[XmlElement("rocksCrushed")]
	public uint? obsolete_rocksCrushed;

	[XmlElement("sheepWoolProduced")]
	public uint? obsolete_sheepWoolProduced;

	[XmlElement("slimesKilled")]
	public uint? obsolete_slimesKilled;

	[XmlElement("stepsTaken")]
	public uint? obsolete_stepsTaken;

	[XmlElement("stoneGathered")]
	public uint? obsolete_stoneGathered;

	[XmlElement("stumpsChopped")]
	public uint? obsolete_stumpsChopped;

	[XmlElement("timesFished")]
	public uint? obsolete_timesFished;

	[XmlElement("timesUnconscious")]
	public uint? obsolete_timesUnconscious;

	[XmlElement("totalMoneyGifted")]
	public uint? obsolete_totalMoneyGifted;

	[XmlElement("trufflesFound")]
	public uint? obsolete_trufflesFound;

	[XmlElement("weedsEliminated")]
	public uint? obsolete_weedsEliminated;

	[XmlElement("seedsSown")]
	public uint? obsolete_seedsSown;

	public static bool AllowRetroactiveAchievements
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public uint AverageBedtime
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
	public uint DaysPlayed
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
	public uint IndividualMoneyEarned
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
	public uint ItemsCooked
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
	public uint ItemsCrafted
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
	public uint ItemsForaged
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
	public uint ItemsShipped
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
	public uint NotesFound
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
	public uint StepsTaken
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
	public uint StumpsChopped
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
	public uint TimesUnconscious
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
	public uint BeveragesMade
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
	public uint CheeseMade
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
	public uint ChickenEggsLayed
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
	public uint CowMilkProduced
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
	public uint CropsShipped
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
	public uint DirtHoed
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
	public uint DuckEggsLayed
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
	public uint GoatCheeseMade
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
	public uint GoatMilkProduced
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
	public uint PiecesOfTrashRecycled
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
	public uint PreservesMade
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
	public uint RabbitWoolProduced
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
	public uint SeedsSown
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
	public uint SheepWoolProduced
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
	public uint TrufflesFound
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
	public uint WeedsEliminated
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
	public uint MonstersKilled
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
	public uint SlimesKilled
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
	public uint FishCaught
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
	public uint TimesFished
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
	public uint CaveCarrotsFound
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
	public uint CopperFound
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
	public uint DiamondsFound
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
	public uint GeodesCracked
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
	public uint GoldFound
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
	public uint IridiumFound
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
	public uint IronFound
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
	public uint MysticStonesCrushed
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
	public uint OtherPreciousGemsFound
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
	public uint PrismaticShardsFound
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
	public uint RocksCrushed
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
	public uint StoneGathered
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
	public uint GiftsGiven
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
	public uint GoodFriends
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
	public uint QuestsCompleted
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
	public uint Get(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(string key, uint value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(string key, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint Decrement(string key, uint amount = 1u)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint Increment(string key, uint amount = 1u)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint Increment(string key, int amount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void monsterKilled(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getMonstersKilled(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void onMoneyGifted(uint amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void takeStep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForBooksReadAchievement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForCookingAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForCraftingAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForShippingAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForFishingAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForArchaeologyAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForHeldItemAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForMoneyAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForBuildingUpgradeAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForQuestAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForFriendshipAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForCommunityCenterOrJojaAchievements(bool isDirectUnlock)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForMiniGameAchievements(bool isDirectUnlock)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForFullHouseAchievement(bool isDirectUnlock)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForMineAchievement(bool isDirectUnlock, bool assumeDeepestLevel = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForMonsterSlayerAchievement(bool isDirectUnlock)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForSkillAchievements(bool isDirectUnlock)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForStardropAchievement(bool isDirectUnlock)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isSharedAchievement(int which)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForAchievements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanUnlockPlatformAchievements(bool isDirectUnlock)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Stats()
	{
	}
}
