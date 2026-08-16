using System;
using Microsoft.Xna.Framework;
using StardewValley.Extensions;
using StardewValley.Internal;
using StardewValley.Locations;
using StardewValley.Network;
using StardewValley.Network.Dedicated;

namespace StardewValley;

public class Preconditions
{
	[OtherNames(new string[] { "e" })]
	public static bool SawEvent(GameLocation location, string eventId, string[] args)
	{
		for (int i = 1; i < args.Length; i++)
		{
			if (!ArgUtility.TryGet(args, i, out var value, out var error, allowBlank: false, "string id"))
			{
				return Event.LogPreconditionError(location, eventId, args, error);
			}
			if (Game1.player.eventsSeen.Contains(value))
			{
				return true;
			}
		}
		return false;
	}

	[OtherNames(new string[] { "h" })]
	public static bool MissingPet(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetOptional(args, 1, out var value, out var error, null, allowBlank: false, "string petType"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		if (!Game1.player.hasPet())
		{
			return value?.EqualsIgnoreCase(Game1.player.whichPetType) ?? true;
		}
		return false;
	}

	[OtherNames(new string[] { "H" })]
	public static bool IsHost(GameLocation location, string eventId, string[] args)
	{
		if (Game1.dedicatedServer != null)
		{
			Game1.dedicatedServer.CheckedHostPrecondition = true;
		}
		return Game1.IsMasterGame;
	}

	[OtherNames(new string[] { "Hn" })]
	public static bool HostMail(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string mailId"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.MasterPlayer.mailReceived.Contains(value);
	}

	[Obsolete("New events should use !HostMail instead.")]
	[OtherNames(new string[] { "Hl" })]
	public static bool NotHostMail(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string mailId"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return !Game1.MasterPlayer.mailReceived.Contains(value);
	}

	[OtherNames(new string[] { "*" })]
	public static bool WorldState(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string worldStateId"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return NetWorldState.checkAnywhereForWorldStateID(value);
	}

	[OtherNames(new string[] { "*n" })]
	public static bool HostOrLocalMail(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string mailId"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		if (!Game1.MasterPlayer.mailReceived.Contains(value))
		{
			return Game1.player.mailReceived.Contains(value);
		}
		return true;
	}

	[Obsolete("New events should use !HostOrLocalMail instead.")]
	[OtherNames(new string[] { "*l" })]
	public static bool NotHostOrLocalMail(GameLocation location, string eventId, string[] args)
	{
		return !HostOrLocalMail(location, eventId, args);
	}

	[OtherNames(new string[] { "m" })]
	public static bool EarnedMoney(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int minMoney"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.player.totalMoneyEarned >= value;
	}

	[OtherNames(new string[] { "M" })]
	public static bool HasMoney(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int minMoney"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.player.Money >= value;
	}

	[OtherNames(new string[] { "c" })]
	public static bool FreeInventorySlots(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int minFreeSpots"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.player.freeSpotsInInventory() >= value;
	}

	[OtherNames(new string[] { "C" })]
	public static bool CommunityCenterOrWarehouseDone(GameLocation location, string eventId, string[] args)
	{
		if (!Game1.MasterPlayer.eventsSeen.Contains("191393") && !Game1.MasterPlayer.eventsSeen.Contains("502261"))
		{
			return Game1.MasterPlayer.hasCompletedCommunityCenter();
		}
		return true;
	}

	[Obsolete("New events should use !CommunityCenterOrWarehouseDone instead.")]
	[OtherNames(new string[] { "X" })]
	public static bool NotCommunityCenterOrWarehouseDone(GameLocation location, string eventId, string[] args)
	{
		return !CommunityCenterOrWarehouseDone(location, eventId, args);
	}

	[OtherNames(new string[] { "D" })]
	public static bool Dating(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string npcName"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		if (Game1.player.friendshipData.TryGetValue(value, out var value2))
		{
			return value2.IsDating();
		}
		return false;
	}

	[OtherNames(new string[] { "j" })]
	public static bool DaysPlayed(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int minDaysPlayed"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.stats.DaysPlayed > value;
	}

	[OtherNames(new string[] { "J" })]
	public static bool JojaBundlesDone(GameLocation location, string eventId, string[] args)
	{
		return Utility.hasFinishedJojaRoute();
	}

	[OtherNames(new string[] { "f" })]
	public static bool Friendship(GameLocation location, string eventId, string[] args)
	{
		for (int i = 1; i < args.Length; i += 2)
		{
			if (!ArgUtility.TryGet(args, i, out var value, out var error, allowBlank: false, "string npcName") || !ArgUtility.TryGetInt(args, i + 1, out var value2, out error, "int minPoints"))
			{
				return Event.LogPreconditionError(location, eventId, args, error);
			}
			if (!Game1.player.friendshipData.TryGetValue(value, out var value3) || value3.Points < value2)
			{
				return false;
			}
		}
		return true;
	}

	public static bool FestivalDay(GameLocation location, string eventId, string[] args)
	{
		return Utility.isFestivalDay();
	}

	[Obsolete("New events should use !FestivalDay instead.")]
	[OtherNames(new string[] { "F" })]
	public static bool NotFestivalDay(GameLocation location, string eventId, string[] args)
	{
		return !FestivalDay(location, eventId, args);
	}

	[OtherNames(new string[] { "r" })]
	public static bool Random(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetFloat(args, 1, out var value, out var error, "float probability"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.random.NextDouble() <= (double)value;
	}

	[OtherNames(new string[] { "s" })]
	public static bool Shipped(GameLocation location, string eventId, string[] args)
	{
		for (int i = 1; i < args.Length; i += 2)
		{
			if (!ArgUtility.TryGet(args, i, out var value, out var error, allowBlank: false, "string itemId") || !ArgUtility.TryGetInt(args, i + 1, out var value2, out error, "int minShipped"))
			{
				return Event.LogPreconditionError(location, eventId, args, error);
			}
			if (!Game1.player.basicShipped.TryGetValue(value, out var value3) || value3 < value2)
			{
				return false;
			}
		}
		return true;
	}

	[OtherNames(new string[] { "S" })]
	public static bool SawSecretNote(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int secretNoteId"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.player.secretNotesSeen.Contains(value);
	}

	[OtherNames(new string[] { "q" })]
	public static bool ChoseDialogueAnswers(GameLocation location, string eventId, string[] args)
	{
		for (int i = 1; i < args.Length; i++)
		{
			if (!ArgUtility.TryGet(args, i, out var value, out var error, allowBlank: false, "string answerId"))
			{
				return Event.LogPreconditionError(location, eventId, args, error);
			}
			if (!Game1.player.DialogueQuestionsAnswered.Contains(value))
			{
				return false;
			}
		}
		return true;
	}

	[OtherNames(new string[] { "n" })]
	public static bool LocalMail(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string mailId"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.player.mailReceived.Contains(value);
	}

	[OtherNames(new string[] { "N" })]
	public static bool GoldenWalnuts(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int minWalnuts"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.netWorldState.Value.GoldenWalnutsFound >= value;
	}

	[Obsolete("New events should use !LocalMail instead.")]
	[OtherNames(new string[] { "l" })]
	public static bool NotLocalMail(GameLocation location, string eventId, string[] args)
	{
		return !LocalMail(location, eventId, args);
	}

	[OtherNames(new string[] { "L" })]
	public static bool InUpgradedHouse(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetOptionalInt(args, 1, out var value, out var error, 2, "int minUpgradeLevel"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		FarmHouse obj = location as FarmHouse;
		if (obj == null)
		{
			return false;
		}
		return obj.upgradeLevel >= value;
	}

	[OtherNames(new string[] { "t" })]
	public static bool Time(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int minTime") || !ArgUtility.TryGetInt(args, 2, out var value2, out error, "int maxTime"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		if (Game1.timeOfDay >= value)
		{
			return Game1.timeOfDay <= value2;
		}
		return false;
	}

	[OtherNames(new string[] { "w" })]
	public static bool Weather(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string weather"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		if (!(value == "rainy"))
		{
			if (value == "sunny")
			{
				return !location.IsRainingHere();
			}
			return value == location.GetWeather().Weather;
		}
		return location.IsRainingHere();
	}

	public static bool DayOfWeek(GameLocation location, string eventId, string[] args)
	{
		DayOfWeek dayOfWeek = Game1.Date.DayOfWeek;
		for (int i = 1; i < args.Length; i++)
		{
			if (!ArgUtility.TryGet(args, i, out var value, out var error, allowBlank: false, "string rawDayName"))
			{
				return Event.LogPreconditionError(location, eventId, args, error);
			}
			if (!WorldDate.TryGetDayOfWeekFor(value, out var dayOfWeek2))
			{
				return Event.LogPreconditionError(location, eventId, args, "can't parse '" + value + "' as a day of week");
			}
			if (dayOfWeek == dayOfWeek2)
			{
				return true;
			}
		}
		return false;
	}

	[Obsolete("New events should use !DayOfWeek instead.")]
	[OtherNames(new string[] { "d" })]
	public static bool NotDayOfWeek(GameLocation location, string eventId, string[] args)
	{
		return !DayOfWeek(location, eventId, args);
	}

	[OtherNames(new string[] { "O" })]
	public static bool Spouse(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string npcName"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.player.spouse == value;
	}

	[Obsolete("New events should use !Spouse instead.")]
	[OtherNames(new string[] { "o" })]
	public static bool NotSpouse(GameLocation location, string eventId, string[] args)
	{
		return !Spouse(location, eventId, args);
	}

	[OtherNames(new string[] { "R" })]
	public static bool Roommate(GameLocation location, string eventId, string[] args)
	{
		return Game1.player.hasCurrentOrPendingRoommate();
	}

	[Obsolete("New events should use !Roommate instead.")]
	[OtherNames(new string[] { "Rf" })]
	public static bool NotRoommate(GameLocation location, string eventId, string[] args)
	{
		return !Roommate(location, eventId, args);
	}

	[OtherNames(new string[] { "v" })]
	public static bool NpcVisible(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string npcName"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		NPC characterFromName = Game1.getCharacterFromName(value);
		if (characterFromName == null)
		{
			return false;
		}
		return !characterFromName.IsInvisible;
	}

	[OtherNames(new string[] { "p" })]
	public static bool NpcVisibleHere(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string npcName"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		foreach (NPC character in location.characters)
		{
			if (character.Name == value && !character.IsInvisible)
			{
				return true;
			}
		}
		return false;
	}

	public static bool Season(GameLocation location, string eventId, string[] args)
	{
		for (int i = 1; i < args.Length; i++)
		{
			if (!ArgUtility.TryGetEnum<Season>(args, 1, out var value, out var error, "Season season"))
			{
				return Event.LogPreconditionError(location, eventId, args, error);
			}
			if (Game1.season == value)
			{
				return true;
			}
		}
		return false;
	}

	[Obsolete("New events should use !Season instead.")]
	[OtherNames(new string[] { "z" })]
	public static bool NotSeason(GameLocation location, string eventId, string[] args)
	{
		return !Season(location, eventId, args);
	}

	[OtherNames(new string[] { "B" })]
	public static bool SpouseBed(GameLocation location, string eventId, string[] args)
	{
		return Utility.getHomeOfFarmer(Game1.player).GetSpouseBed() != null;
	}

	[OtherNames(new string[] { "b" })]
	public static bool ReachedMineBottom(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetOptionalInt(args, 1, out var value, out var error, 1, "int minTimes"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.player.timesReachedMineBottom >= value;
	}

	[OtherNames(new string[] { "y" })]
	public static bool Year(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int desiredYear"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		if (value != 1)
		{
			return Game1.year >= value;
		}
		return Game1.year == 1;
	}

	[OtherNames(new string[] { "g" })]
	public static bool Gender(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string gender"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		bool flag = value.EqualsIgnoreCase("male");
		return Game1.player.IsMale == flag;
	}

	[OtherNames(new string[] { "i" })]
	public static bool HasItem(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string itemId"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		if (!Game1.player.Items.ContainsId(value))
		{
			if (Game1.player.ActiveObject != null)
			{
				return ItemRegistry.HasItemId(Game1.player.ActiveObject, value);
			}
			return false;
		}
		return true;
	}

	[Obsolete("New events should use !SawEvent instead.")]
	[OtherNames(new string[] { "k" })]
	public static bool NotSawEvent(GameLocation location, string eventId, string[] args)
	{
		return !SawEvent(location, eventId, args);
	}

	[OtherNames(new string[] { "a" })]
	public static bool Tile(GameLocation location, string eventId, string[] args)
	{
		Point point;
		if (!Game1.isWarping)
		{
			DedicatedServer dedicatedServer = Game1.dedicatedServer;
			if (dedicatedServer == null || !dedicatedServer.FakeWarp)
			{
				point = Game1.player.TilePoint;
				goto IL_0035;
			}
		}
		point = new Point(Game1.xLocationAfterWarp, Game1.yLocationAfterWarp);
		goto IL_0035;
		IL_0035:
		Point point2 = point;
		for (int i = 1; i < args.Length - 1; i += 2)
		{
			if (!ArgUtility.TryGetPoint(args, i, out var value, out var error, "Point tile"))
			{
				return Event.LogPreconditionError(location, eventId, args, error);
			}
			if (value == point2)
			{
				return true;
			}
		}
		return false;
	}

	public static bool ActiveDialogueEvent(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string id"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		return Game1.player.activeDialogueEvents.ContainsKey(value);
	}

	[Obsolete("New events should use !ActiveDialogueEvent instead.")]
	[OtherNames(new string[] { "A" })]
	public static bool NotActiveDialogueEvent(GameLocation location, string eventId, string[] args)
	{
		return !ActiveDialogueEvent(location, eventId, args);
	}

	[Obsolete("This is a deprecated way to send mail using a hidden pseudo-event. Newer code should use Data/TriggerActions instead.")]
	[OtherNames(new string[] { "x" })]
	public static bool SendMail(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string mailId") || !ArgUtility.TryGetOptionalBool(args, 2, out var value2, out error, defaultValue: false, "bool inMailboxToday"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		if (value2)
		{
			Game1.player.mailbox.Add(value);
		}
		else
		{
			Game1.addMailForTomorrow(value);
		}
		Game1.player.eventsSeen.Add(eventId);
		return false;
	}

	[OtherNames(new string[] { "u" })]
	public static bool DayOfMonth(GameLocation location, string eventId, string[] args)
	{
		bool result = false;
		for (int i = 1; i < args.Length; i++)
		{
			if (!ArgUtility.TryGetInt(args, i, out var value, out var error, "int day"))
			{
				return Event.LogPreconditionError(location, eventId, args, error);
			}
			if (Game1.dayOfMonth == value)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public static bool UpcomingFestival(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGetInt(args, 1, out var value, out var error, "int numberOfDays"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		Season season = Game1.season;
		int seasonIndex = Game1.seasonIndex;
		int num = Game1.dayOfMonth;
		for (int i = 0; i < value; i++)
		{
			if (Utility.isFestivalDay(num, season))
			{
				return true;
			}
			num++;
			if (num > 28)
			{
				num = 1;
				season = (Season)((seasonIndex + 1) % 4);
			}
		}
		return false;
	}

	[Obsolete("New events should use !UpcomingFestival instead.")]
	[OtherNames(new string[] { "U" })]
	public static bool NotUpcomingFestival(GameLocation location, string eventId, string[] args)
	{
		return !UpcomingFestival(location, eventId, args);
	}

	[OtherNames(new string[] { "G" })]
	public static bool GameStateQuery(GameLocation location, string eventId, string[] args)
	{
		string text = ArgUtility.UnsplitQuoteAware(args, ' ', 1);
		if (string.IsNullOrWhiteSpace(text))
		{
			return Event.LogPreconditionError(location, eventId, args, "must specify a game state query");
		}
		return StardewValley.GameStateQuery.CheckConditions(text, location);
	}

	public static bool Skill(GameLocation location, string eventId, string[] args)
	{
		if (!ArgUtility.TryGet(args, 1, out var value, out var error, allowBlank: false, "string name") || !ArgUtility.TryGetInt(args, 2, out var value2, out error, "int minSkillLevel"))
		{
			return Event.LogPreconditionError(location, eventId, args, error);
		}
		int skillNumberFromName = Farmer.getSkillNumberFromName(value);
		return Game1.player.GetUnmodifiedSkillLevel(skillNumberFromName) >= value2;
	}
}
