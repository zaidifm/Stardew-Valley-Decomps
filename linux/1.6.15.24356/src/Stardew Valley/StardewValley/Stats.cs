using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Netcode;
using StardewValley.Extensions;
using StardewValley.GameData.Crops;
using StardewValley.GameData.Objects;
using StardewValley.ItemTypeDefinitions;
using StardewValley.Locations;
using StardewValley.TokenizableStrings;

namespace StardewValley;

public class Stats
{
	public StatsDictionary<int> specificMonstersKilled = new StatsDictionary<int>();

	public StatsDictionary<uint> Values = new StatsDictionary<uint>();

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

	public static bool AllowRetroactiveAchievements => Program.sdk.RetroactiveAchievementsAllowed();

	[XmlIgnore]
	public uint AverageBedtime
	{
		get
		{
			return Get("averageBedtime");
		}
		set
		{
			uint num = Get("averageBedtime");
			uint num2 = Get("daysPlayed");
			Set("averageBedtime", (num * (num2 - 1) + value) / Math.Max(1u, num2));
		}
	}

	[XmlIgnore]
	public uint DaysPlayed
	{
		get
		{
			return Get("daysPlayed");
		}
		set
		{
			Set("daysPlayed", value);
		}
	}

	[XmlIgnore]
	public uint IndividualMoneyEarned
	{
		get
		{
			return Get("individualMoneyEarned");
		}
		set
		{
			uint num = Get("individualMoneyEarned");
			Set("individualMoneyEarned", value);
			if (num < 1000000 && value >= 1000000)
			{
				Game1.multiplayer.globalChatInfoMessage("SoloEarned1mil_" + (Game1.player.IsMale ? "Male" : "Female"), Game1.player.Name);
			}
			else if (num < 100000 && value >= 100000)
			{
				Game1.multiplayer.globalChatInfoMessage("SoloEarned100k_" + (Game1.player.IsMale ? "Male" : "Female"), Game1.player.Name);
			}
			else if (num < 10000 && value >= 10000)
			{
				Game1.multiplayer.globalChatInfoMessage("SoloEarned10k_" + (Game1.player.IsMale ? "Male" : "Female"), Game1.player.Name);
			}
			else if (num < 1000 && value >= 1000)
			{
				Game1.multiplayer.globalChatInfoMessage("SoloEarned1k_" + (Game1.player.IsMale ? "Male" : "Female"), Game1.player.Name);
			}
		}
	}

	[XmlIgnore]
	public uint ItemsCooked
	{
		get
		{
			return Get("itemsCooked");
		}
		set
		{
			Set("itemsCooked", value);
		}
	}

	[XmlIgnore]
	public uint ItemsCrafted
	{
		get
		{
			return Get("itemsCrafted");
		}
		set
		{
			Set("itemsCrafted", value);
			checkForCraftingAchievements();
		}
	}

	[XmlIgnore]
	public uint ItemsForaged
	{
		get
		{
			return Get("itemsForaged");
		}
		set
		{
			Set("itemsForaged", value);
		}
	}

	[XmlIgnore]
	public uint ItemsShipped
	{
		get
		{
			return Get("itemsShipped");
		}
		set
		{
			Set("itemsShipped", value);
		}
	}

	[XmlIgnore]
	public uint NotesFound
	{
		get
		{
			return Get("notesFound");
		}
		set
		{
			Set("notesFound", value);
		}
	}

	[XmlIgnore]
	public uint StepsTaken
	{
		get
		{
			return Get("stepsTaken");
		}
		set
		{
			Set("stepsTaken", value);
		}
	}

	[XmlIgnore]
	public uint StumpsChopped
	{
		get
		{
			return Get("stumpsChopped");
		}
		set
		{
			Set("stumpsChopped", value);
		}
	}

	[XmlIgnore]
	public uint TimesUnconscious
	{
		get
		{
			return Get("timesUnconscious");
		}
		set
		{
			Set("timesUnconscious", value);
		}
	}

	[XmlIgnore]
	public uint BeveragesMade
	{
		get
		{
			return Get("beveragesMade");
		}
		set
		{
			Set("beveragesMade", value);
		}
	}

	[XmlIgnore]
	public uint CheeseMade
	{
		get
		{
			return Get("cheeseMade");
		}
		set
		{
			Set("cheeseMade", value);
		}
	}

	[XmlIgnore]
	public uint ChickenEggsLayed
	{
		get
		{
			return Get("chickenEggsLayed");
		}
		set
		{
			Set("chickenEggsLayed", value);
		}
	}

	[XmlIgnore]
	public uint CowMilkProduced
	{
		get
		{
			return Get("cowMilkProduced");
		}
		set
		{
			Set("cowMilkProduced", value);
		}
	}

	[XmlIgnore]
	public uint CropsShipped
	{
		get
		{
			return Get("cropsShipped");
		}
		set
		{
			Set("cropsShipped", value);
		}
	}

	[XmlIgnore]
	public uint DirtHoed
	{
		get
		{
			return Get("dirtHoed");
		}
		set
		{
			Set("dirtHoed", value);
		}
	}

	[XmlIgnore]
	public uint DuckEggsLayed
	{
		get
		{
			return Get("duckEggsLayed");
		}
		set
		{
			Set("duckEggsLayed", value);
		}
	}

	[XmlIgnore]
	public uint GoatCheeseMade
	{
		get
		{
			return Get("goatCheeseMade");
		}
		set
		{
			Set("goatCheeseMade", value);
		}
	}

	[XmlIgnore]
	public uint GoatMilkProduced
	{
		get
		{
			return Get("goatMilkProduced");
		}
		set
		{
			Set("goatMilkProduced", value);
		}
	}

	[XmlIgnore]
	public uint PiecesOfTrashRecycled
	{
		get
		{
			return Get("piecesOfTrashRecycled");
		}
		set
		{
			Set("piecesOfTrashRecycled", value);
		}
	}

	[XmlIgnore]
	public uint PreservesMade
	{
		get
		{
			return Get("preservesMade");
		}
		set
		{
			Set("preservesMade", value);
		}
	}

	[XmlIgnore]
	public uint RabbitWoolProduced
	{
		get
		{
			return Get("rabbitWoolProduced");
		}
		set
		{
			Set("rabbitWoolProduced", value);
		}
	}

	[XmlIgnore]
	public uint SeedsSown
	{
		get
		{
			return Get("seedsSown");
		}
		set
		{
			Set("seedsSown", value);
		}
	}

	[XmlIgnore]
	public uint SheepWoolProduced
	{
		get
		{
			return Get("sheepWoolProduced");
		}
		set
		{
			Set("sheepWoolProduced", value);
		}
	}

	[XmlIgnore]
	public uint TrufflesFound
	{
		get
		{
			return Get("trufflesFound");
		}
		set
		{
			Set("trufflesFound", value);
		}
	}

	[XmlIgnore]
	public uint WeedsEliminated
	{
		get
		{
			return Get("weedsEliminated");
		}
		set
		{
			Set("weedsEliminated", value);
		}
	}

	[XmlIgnore]
	public uint MonstersKilled
	{
		get
		{
			return Get("monstersKilled");
		}
		set
		{
			Set("monstersKilled", value);
		}
	}

	[XmlIgnore]
	public uint SlimesKilled
	{
		get
		{
			return Get("slimesKilled");
		}
		set
		{
			Set("slimesKilled", value);
		}
	}

	[XmlIgnore]
	public uint FishCaught
	{
		get
		{
			return Get("fishCaught");
		}
		set
		{
			Set("fishCaught", value);
		}
	}

	[XmlIgnore]
	public uint TimesFished
	{
		get
		{
			return Get("timesFished");
		}
		set
		{
			Set("timesFished", value);
		}
	}

	[XmlIgnore]
	public uint CaveCarrotsFound
	{
		get
		{
			return Get("caveCarrotsFound");
		}
		set
		{
			Set("caveCarrotsFound", value);
		}
	}

	[XmlIgnore]
	public uint CopperFound
	{
		get
		{
			return Get("copperFound");
		}
		set
		{
			Set("copperFound", value);
		}
	}

	[XmlIgnore]
	public uint DiamondsFound
	{
		get
		{
			return Get("diamondsFound");
		}
		set
		{
			Set("diamondsFound", value);
		}
	}

	[XmlIgnore]
	public uint GeodesCracked
	{
		get
		{
			return Get("geodesCracked");
		}
		set
		{
			Set("geodesCracked", value);
		}
	}

	[XmlIgnore]
	public uint GoldFound
	{
		get
		{
			return Get("goldFound");
		}
		set
		{
			Set("goldFound", value);
		}
	}

	[XmlIgnore]
	public uint IridiumFound
	{
		get
		{
			return Get("iridiumFound");
		}
		set
		{
			Set("iridiumFound", value);
		}
	}

	[XmlIgnore]
	public uint IronFound
	{
		get
		{
			return Get("ironFound");
		}
		set
		{
			Set("ironFound", value);
		}
	}

	[XmlIgnore]
	public uint MysticStonesCrushed
	{
		get
		{
			return Get("mysticStonesCrushed");
		}
		set
		{
			Set("mysticStonesCrushed", value);
		}
	}

	[XmlIgnore]
	public uint OtherPreciousGemsFound
	{
		get
		{
			return Get("otherPreciousGemsFound");
		}
		set
		{
			Set("otherPreciousGemsFound", value);
		}
	}

	[XmlIgnore]
	public uint PrismaticShardsFound
	{
		get
		{
			return Get("prismaticShardsFound");
		}
		set
		{
			Set("prismaticShardsFound", value);
		}
	}

	[XmlIgnore]
	public uint RocksCrushed
	{
		get
		{
			return Get("rocksCrushed");
		}
		set
		{
			Set("rocksCrushed", value);
		}
	}

	[XmlIgnore]
	public uint StoneGathered
	{
		get
		{
			return Get("stoneGathered");
		}
		set
		{
			Set("stoneGathered", value);
		}
	}

	[XmlIgnore]
	public uint GiftsGiven
	{
		get
		{
			return Get("giftsGiven");
		}
		set
		{
			Set("giftsGiven", value);
		}
	}

	[XmlIgnore]
	public uint GoodFriends
	{
		get
		{
			return Get("goodFriends");
		}
		set
		{
			Set("goodFriends", value);
		}
	}

	[XmlIgnore]
	public uint QuestsCompleted
	{
		get
		{
			return Get("questsCompleted");
		}
		set
		{
			Set("questsCompleted", value);
			checkForQuestAchievements();
		}
	}

	public uint Get(string key)
	{
		if (!Values.TryGetValue(key, out var value))
		{
			return 0u;
		}
		return value;
	}

	public void Set(string key, uint value)
	{
		if (value != 0)
		{
			Values[key] = value;
		}
		else
		{
			Values.Remove(key);
		}
	}

	public void Set(string key, int value)
	{
		if (value <= 0)
		{
			Set(key, 0u);
		}
		else
		{
			Set(key, (uint)value);
		}
	}

	public uint Decrement(string key, uint amount = 1u)
	{
		uint num = Get(key);
		num = ((amount < num) ? (num - amount) : 0u);
		Set(key, num);
		return num;
	}

	public uint Increment(string key, uint amount = 1u)
	{
		uint num = Get(key) + amount;
		Set(key, num);
		return num;
	}

	public uint Increment(string key, int amount)
	{
		if (amount >= 0)
		{
			return Increment(key, (uint)amount);
		}
		return Decrement(key, (uint)(-amount));
	}

	public void monsterKilled(string name)
	{
		if (AdventureGuild.willThisKillCompleteAMonsterSlayerQuest(name))
		{
			Game1.showGlobalMessage(Game1.content.LoadString("Strings\\StringsFromCSFiles:Stats.cs.5129"));
			Game1.multiplayer.globalChatInfoMessage("MonsterSlayer" + Game1.random.Next(4), Game1.player.Name, TokenStringBuilder.MonsterName(name));
		}
		specificMonstersKilled[name] = getMonstersKilled(name) + 1;
		checkForMonsterSlayerAchievement(isDirectUnlock: true);
	}

	public int getMonstersKilled(string name)
	{
		return specificMonstersKilled.GetValueOrDefault(name);
	}

	public void onMoneyGifted(uint amount)
	{
		uint num = Get("totalMoneyGifted");
		uint num2 = Increment("totalMoneyGifted", amount);
		if (num <= 1000000 && num2 > 1000000)
		{
			Game1.multiplayer.globalChatInfoMessage("Gifted1mil", Game1.player.Name);
		}
		else if (num <= 100000 && num2 > 100000)
		{
			Game1.multiplayer.globalChatInfoMessage("Gifted100k", Game1.player.Name);
		}
		else if (num <= 10000 && num2 > 10000)
		{
			Game1.multiplayer.globalChatInfoMessage("Gifted10k", Game1.player.Name);
		}
		else if (num <= 1000 && num2 > 1000)
		{
			Game1.multiplayer.globalChatInfoMessage("Gifted1k", Game1.player.Name);
		}
	}

	public void takeStep()
	{
		switch (Increment("stepsTaken"))
		{
		case 10000u:
			Game1.multiplayer.globalChatInfoMessage("Walked10k", Game1.player.Name);
			break;
		case 100000u:
			Game1.multiplayer.globalChatInfoMessage("Walked100k", Game1.player.Name);
			break;
		case 1000000u:
			Game1.multiplayer.globalChatInfoMessage("Walked1m", Game1.player.Name);
			break;
		case 10000000u:
			Game1.multiplayer.globalChatInfoMessage("Walked10m", Game1.player.Name);
			break;
		}
	}

	public void checkForBooksReadAchievement()
	{
		if (Game1.player.stats.Get("Book_Trash") != 0 && Game1.player.stats.Get("Book_Crabbing") != 0 && Game1.player.stats.Get("Book_Bombs") != 0 && Game1.player.stats.Get("Book_Roe") != 0 && Game1.player.stats.Get("Book_WildSeeds") != 0 && Game1.player.stats.Get("Book_Woodcutting") != 0 && Game1.player.stats.Get("Book_Defense") != 0 && Game1.player.stats.Get("Book_Friendship") != 0 && Game1.player.stats.Get("Book_Void") != 0 && Game1.player.stats.Get("Book_Speed") != 0 && Game1.player.stats.Get("Book_Marlon") != 0 && Game1.player.stats.Get("Book_PriceCatalogue") != 0 && Game1.player.stats.Get("Book_Diamonds") != 0 && Game1.player.stats.Get("Book_Mystery") != 0 && Game1.player.stats.Get("Book_AnimalCatalogue") != 0 && Game1.player.stats.Get("Book_Speed2") != 0 && Game1.player.stats.Get("Book_Artifact") != 0 && Game1.player.stats.Get("Book_Horse") != 0 && Game1.player.stats.Get("Book_Grass") != 0)
		{
			Game1.getAchievement(35);
		}
	}

	public void checkForCookingAchievements()
	{
		Dictionary<string, string> cookingRecipes = CraftingRecipe.cookingRecipes;
		int num = 0;
		int num2 = 0;
		foreach (KeyValuePair<string, string> item in cookingRecipes)
		{
			if (Game1.player.cookingRecipes.ContainsKey(item.Key))
			{
				string key = ArgUtility.SplitBySpaceAndGet(item.Value.Split('/')[2], 0);
				if (Game1.player.recipesCooked.TryGetValue(key, out var value))
				{
					num2 += value;
					num++;
				}
			}
		}
		Set("itemsCooked", num2);
		if (num >= cookingRecipes.Count)
		{
			Game1.getAchievement(17);
		}
		if (num >= 25)
		{
			Game1.getAchievement(16);
		}
		if (num >= 10)
		{
			Game1.getAchievement(15);
		}
	}

	public void checkForCraftingAchievements()
	{
		Dictionary<string, string> craftingRecipes = CraftingRecipe.craftingRecipes;
		int num = 0;
		int num2 = 0;
		foreach (string key in craftingRecipes.Keys)
		{
			if (!(key == "Wedding Ring") && Game1.player.craftingRecipes.TryGetValue(key, out var value))
			{
				num2 += value;
				if (Game1.player.craftingRecipes[key] > 0)
				{
					num++;
				}
			}
		}
		Set("itemsCrafted", num2);
		if (num >= craftingRecipes.Count - 1)
		{
			Game1.getAchievement(22);
		}
		if (num >= 30)
		{
			Game1.getAchievement(21);
		}
		if (num >= 15)
		{
			Game1.getAchievement(20);
		}
	}

	public void checkForShippingAchievements()
	{
		bool flag = true;
		bool flag2 = false;
		foreach (CropData value in Game1.cropData.Values)
		{
			if (value.CountForPolyculture)
			{
				flag = flag && DidFarmerShip(value.HarvestItemId, 15);
			}
			if (value.CountForMonoculture)
			{
				flag2 = flag2 || DidFarmerShip(value.HarvestItemId, 300);
			}
		}
		if (flag)
		{
			Game1.getAchievement(31);
		}
		if (flag2)
		{
			Game1.getAchievement(32);
		}
		if (Utility.hasFarmerShippedAllItems())
		{
			Game1.getAchievement(34);
		}
		static bool DidFarmerShip(string itemId, int number)
		{
			return Game1.player.basicShipped.GetValueOrDefault(itemId, 0) >= number;
		}
	}

	public void checkForFishingAchievements()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (ParsedItemData allDatum in ItemRegistry.GetObjectTypeDefinition().GetAllData())
		{
			if (allDatum.ObjectType == "Fish" && !(allDatum.RawData is ObjectData { ExcludeFromFishingCollection: not false }))
			{
				num3++;
				if (Game1.player.fishCaught.TryGetValue(allDatum.QualifiedItemId, out var value))
				{
					num += value[0];
					num2++;
				}
			}
		}
		Set("fishCaught", num);
		if (num >= 100)
		{
			Game1.getAchievement(27);
		}
		if (num2 >= num3)
		{
			Game1.getAchievement(26);
			if (!Game1.player.hasOrWillReceiveMail("CF_Fish"))
			{
				Game1.addMailForTomorrow("CF_Fish");
			}
		}
		if (num2 >= 24)
		{
			Game1.getAchievement(25);
		}
		if (num2 >= 10)
		{
			Game1.getAchievement(24);
		}
	}

	public void checkForArchaeologyAchievements()
	{
		int length = Game1.netWorldState.Value.MuseumPieces.Length;
		if (length >= LibraryMuseum.totalArtifacts)
		{
			Game1.getAchievement(5);
		}
		if (length >= 40)
		{
			Game1.getAchievement(28);
		}
	}

	public void checkForHeldItemAchievements()
	{
		if (Game1.player.Items.ContainsId("(W)62") || Game1.player.Items.ContainsId("(W)63") || Game1.player.Items.ContainsId("(W)64"))
		{
			Game1.getAchievement(42);
		}
	}

	public void checkForMoneyAchievements()
	{
		if (Game1.player.totalMoneyEarned >= 10000000)
		{
			Game1.getAchievement(4);
		}
		if (Game1.player.totalMoneyEarned >= 1000000)
		{
			Game1.getAchievement(3);
		}
		if (Game1.player.totalMoneyEarned >= 250000)
		{
			Game1.getAchievement(2);
		}
		if (Game1.player.totalMoneyEarned >= 50000)
		{
			Game1.getAchievement(1);
		}
		if (Game1.player.totalMoneyEarned >= 15000)
		{
			Game1.getAchievement(0);
		}
	}

	public void checkForBuildingUpgradeAchievements()
	{
		if (Game1.player.HouseUpgradeLevel >= 2)
		{
			Game1.getAchievement(19);
		}
		if (Game1.player.HouseUpgradeLevel >= 1)
		{
			Game1.getAchievement(18);
		}
	}

	public void checkForQuestAchievements()
	{
		if (QuestsCompleted >= 40)
		{
			Game1.getAchievement(30);
			Game1.addMailForTomorrow("quest35");
		}
		if (QuestsCompleted >= 10)
		{
			Game1.getAchievement(29);
			Game1.addMailForTomorrow("quest10");
		}
	}

	public void checkForFriendshipAchievements()
	{
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		foreach (Friendship value3 in Game1.player.friendshipData.Values)
		{
			if (value3.Points >= 2500)
			{
				num3++;
			}
			if (value3.Points >= 2000)
			{
				num2++;
			}
			if (value3.Points >= 1250)
			{
				num++;
			}
		}
		GoodFriends = num2;
		if (num >= 20)
		{
			Game1.getAchievement(13);
		}
		if (num >= 10)
		{
			Game1.getAchievement(12);
		}
		if (num >= 4)
		{
			Game1.getAchievement(11);
		}
		if (num >= 1)
		{
			Game1.getAchievement(6);
		}
		if (num3 >= 8)
		{
			Game1.getAchievement(9);
		}
		if (num3 >= 1)
		{
			Game1.getAchievement(7);
		}
		foreach (KeyValuePair<string, string> cookingRecipe in CraftingRecipe.cookingRecipes)
		{
			string key = cookingRecipe.Key;
			string[] array = ArgUtility.SplitBySpace(ArgUtility.Get(cookingRecipe.Value.Split('/'), 3));
			if (!(ArgUtility.Get(array, 0) != "f"))
			{
				string text = ArgUtility.Get(array, 1);
				int num4 = ArgUtility.GetInt(array, 2);
				if (text != null && Game1.player.friendshipData.TryGetValue(text, out var value) && value.Points >= num4 * 250 && !Game1.player.cookingRecipes.ContainsKey(key) && !Game1.player.hasOrWillReceiveMail(text + "Cooking"))
				{
					Game1.addMailForTomorrow(text + "Cooking");
				}
			}
		}
		foreach (KeyValuePair<string, string> craftingRecipe in CraftingRecipe.craftingRecipes)
		{
			string key2 = craftingRecipe.Key;
			string[] array2 = ArgUtility.SplitBySpace(ArgUtility.Get(craftingRecipe.Value.Split('/'), 4));
			if (!(ArgUtility.Get(array2, 0) != "f"))
			{
				string text2 = ArgUtility.Get(array2, 1);
				int num5 = ArgUtility.GetInt(array2, 2);
				if (text2 != null && Game1.player.friendshipData.TryGetValue(text2, out var value2) && value2.Points >= num5 * 250 && !Game1.player.craftingRecipes.ContainsKey(key2) && !Game1.player.hasOrWillReceiveMail(text2 + "Crafting"))
				{
					Game1.addMailForTomorrow(text2 + "Crafting");
				}
			}
		}
	}

	public void checkForCommunityCenterOrJojaAchievements(bool isDirectUnlock)
	{
		if (CanUnlockPlatformAchievements(isDirectUnlock))
		{
			if (Game1.player.eventsSeen.Contains("191393"))
			{
				Game1.getSteamAchievement("Achievement_LocalLegend");
			}
			if (Game1.player.eventsSeen.Contains("502261"))
			{
				Game1.getSteamAchievement("Achievement_Joja");
			}
		}
	}

	public void checkForMiniGameAchievements(bool isDirectUnlock)
	{
		if (CanUnlockPlatformAchievements(isDirectUnlock))
		{
			if (Game1.player.stats.Get("completedPrairieKing") != 0)
			{
				Game1.getSteamAchievement("Achievement_PrairieKing");
			}
			if (Game1.player.stats.Get("completedPrairieKingWithoutDying") != 0)
			{
				Game1.getSteamAchievement("Achievement_FectorsChallenge");
			}
		}
	}

	public void checkForFullHouseAchievement(bool isDirectUnlock)
	{
		if (CanUnlockPlatformAchievements(isDirectUnlock) && Game1.player.isMarriedOrRoommates() && Game1.player.getChildrenCount() >= 2)
		{
			Game1.getSteamAchievement("Achievement_FullHouse");
		}
	}

	public void checkForMineAchievement(bool isDirectUnlock, bool assumeDeepestLevel = false)
	{
		if (CanUnlockPlatformAchievements(isDirectUnlock) && (assumeDeepestLevel || Game1.player.deepestMineLevel >= 120))
		{
			Game1.getSteamAchievement("Achievement_TheBottom");
		}
	}

	public void checkForMonsterSlayerAchievement(bool isDirectUnlock)
	{
		if (CanUnlockPlatformAchievements(isDirectUnlock) && AdventureGuild.areAllMonsterSlayerQuestsComplete())
		{
			Game1.player.hasCompletedAllMonsterSlayerQuests.Value = true;
			Game1.getSteamAchievement("Achievement_KeeperOfTheMysticRings");
		}
	}

	public void checkForSkillAchievements(bool isDirectUnlock)
	{
		if (!CanUnlockPlatformAchievements(isDirectUnlock))
		{
			return;
		}
		NetInt[] obj = new NetInt[5]
		{
			Game1.player.farmingLevel,
			Game1.player.miningLevel,
			Game1.player.fishingLevel,
			Game1.player.foragingLevel,
			Game1.player.combatLevel
		};
		bool flag = false;
		bool flag2 = true;
		NetInt[] array = obj;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].Value >= 10)
			{
				flag = true;
			}
			else
			{
				flag2 = false;
			}
		}
		if (flag)
		{
			Game1.getSteamAchievement("Achievement_SingularTalent");
			if (flag2)
			{
				Game1.getSteamAchievement("Achievement_MasterOfTheFiveWays");
			}
		}
	}

	public void checkForStardropAchievement(bool isDirectUnlock)
	{
		if (CanUnlockPlatformAchievements(isDirectUnlock) && Utility.foundAllStardrops())
		{
			Game1.getSteamAchievement("Achievement_Stardrop");
		}
	}

	public bool isSharedAchievement(int which)
	{
		if ((uint)which <= 5u || which == 28)
		{
			return true;
		}
		return false;
	}

	public void checkForAchievements()
	{
		checkForBooksReadAchievement();
		checkForCookingAchievements();
		checkForCraftingAchievements();
		checkForShippingAchievements();
		checkForFishingAchievements();
		checkForArchaeologyAchievements();
		checkForHeldItemAchievements();
		checkForMoneyAchievements();
		checkForBuildingUpgradeAchievements();
		checkForQuestAchievements();
		checkForFriendshipAchievements();
		checkForCommunityCenterOrJojaAchievements(isDirectUnlock: false);
		checkForMiniGameAchievements(isDirectUnlock: false);
		checkForFullHouseAchievement(isDirectUnlock: false);
		checkForMineAchievement(isDirectUnlock: false);
		checkForMonsterSlayerAchievement(isDirectUnlock: false);
		checkForSkillAchievements(isDirectUnlock: false);
		checkForStardropAchievement(isDirectUnlock: false);
	}

	public bool CanUnlockPlatformAchievements(bool isDirectUnlock)
	{
		return AllowRetroactiveAchievements | isDirectUnlock;
	}
}
