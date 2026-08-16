using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework.Content;
using StardewValley.BellsAndWhistles;
using StardewValley.Extensions;
using StardewValley.ItemTypeDefinitions;
using StardewValley.Locations;
using StardewValley.SpecialOrders;

namespace StardewValley.TokenizableStrings;

public class TokenParser
{
	public static class DefaultResolvers
	{
		public static bool AchievementName(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGetInt(query, 1, out var value, out var error, "int achievementId"))
			{
				return LogTokenError(query, error, out replacement);
			}
			if (!Game1.achievements.TryGetValue(value, out var value2))
			{
				return LogTokenError(query, $"unknown achievement ID '{value}'", out replacement);
			}
			replacement = value2.Split('^', 2)[0];
			return true;
		}

		public static bool ArticleFor(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string word"))
			{
				return LogTokenError(query, error, out replacement);
			}
			replacement = Lexicon.getProperArticleForWord(value);
			return true;
		}

		public static bool CapitalizeFirstLetter(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGetRemainder(query, 1, out var value, out var error, ' ', "string text"))
			{
				return LogTokenError(query, error, out replacement);
			}
			replacement = Utility.capitalizeFirstLetter(value);
			return true;
		}

		public static bool EscapedText(string[] query, out string replacement, Random random, Farmer player)
		{
			replacement = string.Join(" ", query.Skip(1));
			replacement = EscapeSpaces(replacement);
			return true;
		}

		public static bool GenderedText(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string maleStr") || !ArgUtility.TryGet(query, 2, out var value2, out error, allowBlank: true, "string femaleStr") || !ArgUtility.TryGetOptional(query, 3, out var value3, out error, null, allowBlank: true, "string otherStr"))
			{
				return LogTokenError(query, error, out replacement);
			}
			switch (player.Gender)
			{
			case Gender.Male:
				replacement = value;
				break;
			case Gender.Female:
				replacement = value2;
				break;
			default:
				replacement = value3 ?? value2;
				break;
			}
			return true;
		}

		public static bool ItemName(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string itemId") || !ArgUtility.TryGetOptional(query, 2, out var value2, out error, null, allowBlank: true, "string fallbackItemName"))
			{
				return LogTokenError(query, error, out replacement);
			}
			replacement = ItemRegistry.GetData(value)?.DisplayName ?? value2 ?? ItemRegistry.GetErrorItemName(value);
			return true;
		}

		public static bool ItemNameWithFlavor(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGetEnum<Object.PreserveType>(query, 1, out var value, out var error, "Object.PreserveType preserveType") || !ArgUtility.TryGet(query, 2, out var value2, out error, allowBlank: true, "string preservedId") || !ArgUtility.TryGetOptional(query, 3, out var value3, out error, null, allowBlank: true, "string fallbackItemName"))
			{
				return LogTokenError(query, error, out replacement);
			}
			string baseItemIdForFlavoredItem = ItemRegistry.GetObjectTypeDefinition().GetBaseItemIdForFlavoredItem(value, value2);
			replacement = Object.GetObjectDisplayName(baseItemIdForFlavoredItem, value, value2, null, value3);
			return true;
		}

		public static bool LocalizedText(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string key"))
			{
				return LogTokenError(query, error, out replacement);
			}
			object[] array;
			if (query.Length > 2)
			{
				array = new object[query.Length - 2];
				for (int i = 2; i < query.Length; i++)
				{
					array[i - 2] = query[i];
				}
			}
			else
			{
				array = LegacyShims.EmptyArray<object>();
			}
			try
			{
				replacement = ((array.Length != 0) ? Game1.content.LoadString(value, array) : Game1.content.LoadString(value));
				return true;
			}
			catch (ContentLoadException)
			{
				return LogTokenError(query, "the key '" + value + "' doesn't match an existing asset", out replacement);
			}
			catch (InvalidCastException)
			{
				return LogTokenError(query, "the key '" + value + "' matches an asset, but it isn't of the required type 'Dictionary<string, string>'", out replacement);
			}
		}

		public static bool MonsterName(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string monsterId") || !ArgUtility.TryGetOptional(query, 2, out var value2, out error, null, allowBlank: true, "string fallbackText"))
			{
				return LogTokenError(query, error, out replacement);
			}
			replacement = (DataLoader.Monsters(Game1.content).TryGetValue(value, out var value3) ? ArgUtility.Get(value3.Split('/'), 14) : null);
			replacement = replacement ?? value2 ?? value;
			return true;
		}

		public static bool MovieName(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string movieId"))
			{
				return LogTokenError(query, error, out replacement);
			}
			if (!MovieTheater.TryGetMovieData(value, out var data))
			{
				return LogTokenError(query, "unknown movie ID '" + value + "'", out replacement);
			}
			replacement = ParseText(data.Title);
			return true;
		}

		public static bool NumberWithSeparators(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGetInt(query, 1, out var value, out var error, "int number"))
			{
				return LogTokenError(query, error, out replacement);
			}
			replacement = Utility.getNumberWithCommas(value);
			return true;
		}

		public static bool PositiveAdjective(string[] query, out string replacement, Random random, Farmer player)
		{
			replacement = Lexicon.getRandomPositiveAdjectiveForEventOrPerson();
			return true;
		}

		public static bool SpecialOrderName(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string orderId"))
			{
				return LogTokenError(query, error, out replacement);
			}
			foreach (SpecialOrder specialOrder in Game1.player.team.specialOrders)
			{
				if (specialOrder.questKey.Value == value)
				{
					replacement = specialOrder.GetName();
					return true;
				}
			}
			if (SpecialOrder.TryGetData(value, out var data))
			{
				replacement = SpecialOrder.MakeLocalizationReplacements(ParseText(data.Name));
				return true;
			}
			return LogTokenError(query, "unknown special order ID '" + value + "'", out replacement);
		}

		public static bool SpouseFarmerText(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string playerSpouse") || !ArgUtility.TryGet(query, 2, out var value2, out error, allowBlank: true, "string npcSpouse"))
			{
				return LogTokenError(query, error, out replacement);
			}
			if (player.team.GetSpouse(player.UniqueMultiplayerID).HasValue)
			{
				replacement = value;
				return true;
			}
			if (player.getSpouse() != null)
			{
				replacement = value2;
				return true;
			}
			return LogTokenError(query, "the target player '" + player.Name + "' isn't married", out replacement);
		}

		public static bool SpouseGenderedText(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string maleStr") || !ArgUtility.TryGet(query, 2, out var value2, out error, allowBlank: true, "string femaleStr") || !ArgUtility.TryGetOptional(query, 3, out var value3, out error, null, allowBlank: true, "string otherStr"))
			{
				return LogTokenError(query, error, out replacement);
			}
			Gender? gender = null;
			long? spouse = player.team.GetSpouse(player.UniqueMultiplayerID);
			gender = ((!spouse.HasValue) ? player.getSpouse()?.Gender : new Gender?(Game1.GetPlayer(spouse.Value)?.Gender ?? Gender.Male));
			if (gender.HasValue)
			{
				switch (gender)
				{
				case Gender.Male:
					replacement = value;
					break;
				case Gender.Female:
					replacement = value2;
					break;
				default:
					replacement = value3 ?? value2;
					break;
				}
				return true;
			}
			return LogTokenError(query, "the target player '" + player.Name + "' isn't married", out replacement);
		}

		public static bool ToolName(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string itemId") || !ArgUtility.TryGetOptionalInt(query, 2, out var _, out error, -1, "int upgradeLevel"))
			{
				return LogTokenError(query, error, out replacement);
			}
			ParsedItemData dataOrErrorItem = ItemRegistry.GetDataOrErrorItem(value);
			if (!dataOrErrorItem.HasTypeId("(T)"))
			{
				return LogTokenError(query, "the item ID '" + value + "' matches a non-tool item", out replacement);
			}
			replacement = dataOrErrorItem.DisplayName;
			return true;
		}

		public static bool DayOfMonth(string[] query, out string replacement, Random random, Farmer player)
		{
			replacement = Game1.dayOfMonth.ToString();
			return true;
		}

		public static bool Season(string[] query, out string replacement, Random random, Farmer player)
		{
			replacement = Game1.CurrentSeasonDisplayName;
			return true;
		}

		public static bool CharacterName(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string npcName"))
			{
				return LogTokenError(query, error, out replacement);
			}
			NPC characterFromName = Game1.getCharacterFromName(value);
			if (characterFromName == null)
			{
				return LogTokenError(query, "no character found with name '" + value + "'", out replacement);
			}
			replacement = characterFromName.displayName;
			return true;
		}

		public static bool FarmName(string[] query, out string replacement, Random random, Farmer player)
		{
			replacement = player.farmName.Value;
			return true;
		}

		public static bool FarmerUniqueId(string[] query, out string replacement, Random random, Farmer player)
		{
			replacement = player.UniqueMultiplayerID.ToString();
			return true;
		}

		public static bool LocationName(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string locationKey"))
			{
				return LogTokenError(query, error, out replacement);
			}
			GameLocation locationFromName = Game1.getLocationFromName(value);
			if (locationFromName == null)
			{
				return LogTokenError(query, "no location found with name '" + value + "'", out replacement);
			}
			replacement = locationFromName.DisplayName;
			return true;
		}

		public static bool FarmerStat(string[] query, out string replacement, Random random, Farmer player)
		{
			if (!ArgUtility.TryGet(query, 1, out var value, out var error, allowBlank: true, "string statName"))
			{
				return LogTokenError(query, error, out replacement);
			}
			replacement = player.stats.Get(value).ToString();
			return true;
		}
	}

	private static readonly Dictionary<string, TokenParserDelegate> Parsers;

	private const char EscapedSpace = '\u00a0';

	private const char EscapedEmpty = '\u200b';

	private static readonly string EscapedEmptyStr;

	internal const char StartTokenChar = '[';

	internal const char EndTokenChar = ']';

	internal static readonly char[] HeuristicCharactersForEscapableStrings;

	static TokenParser()
	{
		Parsers = new Dictionary<string, TokenParserDelegate>(StringComparer.OrdinalIgnoreCase);
		EscapedEmptyStr = '\u200b'.ToString();
		HeuristicCharactersForEscapableStrings = new char[2] { ' ', '[' };
		MethodInfo[] methods = typeof(DefaultResolvers).GetMethods(BindingFlags.Static | BindingFlags.Public);
		foreach (MethodInfo methodInfo in methods)
		{
			TokenParserDelegate value = (TokenParserDelegate)Delegate.CreateDelegate(typeof(TokenParserDelegate), methodInfo);
			Parsers[methodInfo.Name] = value;
		}
	}

	public static void RegisterParser(string tokenKey, TokenParserDelegate parser)
	{
		if (string.IsNullOrWhiteSpace(tokenKey))
		{
			throw new ArgumentException("The token key can't be empty.", "tokenKey");
		}
		if (parser == null)
		{
			throw new ArgumentException("The parser callback for token key '" + tokenKey + "' can't be null.", "parser");
		}
		tokenKey = tokenKey.Trim();
		if (!Parsers.TryAdd(tokenKey, parser))
		{
			throw new ArgumentException("Can't add token parser for key '" + tokenKey + "' because one is already registered for it.");
		}
	}

	public static string EscapeSpaces(string text)
	{
		if (text.Length <= 0)
		{
			return EscapedEmptyStr;
		}
		return text.Replace(' ', '\u00a0');
	}

	public static string ParseText(string text, Random random = null, TokenParserDelegate customParser = null, Farmer player = null)
	{
		if (text == null)
		{
			return null;
		}
		int num = text.IndexOf('[');
		if (num == -1)
		{
			return text;
		}
		for (int i = num; i < text.Length; i++)
		{
			if (text[i] == '[')
			{
				i = ParseTagStartingAt(ref text, i, random ?? Game1.random, customParser, player ?? Game1.player);
			}
		}
		return UnescapeText(text.Replace("\\n", "\n"));
	}

	public static bool LogTokenError(string[] query, string error, out string replacement)
	{
		Game1.log.Error($"Failed parsing [{string.Join(" ", query)}]: {error}.");
		replacement = null;
		return false;
	}

	public static bool LogTokenError(string[] query, Exception error, out string replacement)
	{
		Game1.log.Error("Failed parsing [" + string.Join(" ", query) + "].", error);
		replacement = null;
		return false;
	}

	private static int ParseTagStartingAt(ref string text, int startIndex, Random random, TokenParserDelegate customParser, Farmer player)
	{
		for (int i = startIndex + 1; i < text.Length; i++)
		{
			switch (text[i])
			{
			case '[':
				i = ParseTagStartingAt(ref text, i, random, customParser, player);
				break;
			case ']':
			{
				if (ParseTag(text.Substring(startIndex + 1, i - startIndex - 1), out var replacement, random, customParser, player))
				{
					text = text.Remove(startIndex, i - startIndex + 1);
					text = text.Insert(startIndex, replacement);
					return startIndex + replacement.Length - 1;
				}
				return i;
			}
			}
		}
		return text.Length - 1;
	}

	private static bool ParseTag(string tag, out string replacement, Random random, TokenParserDelegate customParser, Farmer player)
	{
		string[] array = ArgUtility.SplitBySpace(tag);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = UnescapeText(array[i]);
		}
		if (customParser != null && customParser(array, out replacement, random, player))
		{
			return true;
		}
		if (Parsers.TryGetValue(array[0], out var value) && value(array, out replacement, random, player))
		{
			return true;
		}
		replacement = null;
		return false;
	}

	private static string UnescapeText(string text)
	{
		return text.Replace('\u00a0', ' ').Replace(EscapedEmptyStr, "");
	}
}
