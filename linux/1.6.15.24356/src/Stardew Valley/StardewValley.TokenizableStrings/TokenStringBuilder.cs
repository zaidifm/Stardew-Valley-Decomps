namespace StardewValley.TokenizableStrings;

public static class TokenStringBuilder
{
	public static string EscapedText(string value, bool skipIfNotNeeded = true)
	{
		if (!skipIfNotNeeded || (value.IndexOfAny(TokenParser.HeuristicCharactersForEscapableStrings) != -1 && !value.StartsWith("[EscapedText")))
		{
			value = "[EscapedText " + value + "]";
		}
		return value;
	}

	public static string AchievementName(int achievementId)
	{
		return BuildTokenWithArgumentString("AchievementName", achievementId.ToString());
	}

	public static string ArticleFor(string word)
	{
		return BuildTokenWithArgumentString("ArticleFor", word);
	}

	public static string CapitalizeFirstLetter(string text)
	{
		return BuildTokenWithArgumentString("CapitalizeFirstLetter", text);
	}

	public static string ItemName(string itemId, string fallbackItemName = null)
	{
		if (fallbackItemName == null)
		{
			return BuildTokenWithArgumentString("ItemName", itemId);
		}
		return BuildTokenWithArgumentString("ItemName", itemId, fallbackItemName);
	}

	public static string ItemNameWithFlavor(Object.PreserveType preserveType, string preservedId, string fallbackItemName = null)
	{
		if (fallbackItemName == null)
		{
			return BuildTokenWithArgumentString("ItemNameWithFlavor", preserveType.ToString(), preservedId);
		}
		return BuildTokenWithArgumentString("ItemNameWithFlavor", preserveType.ToString(), preservedId, fallbackItemName);
	}

	public static string ItemNameFor(Item item, string fallbackItemName = null)
	{
		if (item is Object obj)
		{
			if (!string.IsNullOrWhiteSpace(obj.displayNameFormat))
			{
				return obj.displayNameFormat;
			}
			if (obj.preserve.Value.HasValue)
			{
				return ItemNameWithFlavor(obj.preserve.Value.Value, obj.preservedParentSheetIndex.Value, fallbackItemName);
			}
		}
		return ItemName(item?.QualifiedItemId, fallbackItemName);
	}

	public static string LocalizedText(string translationKey)
	{
		return BuildTokenWithArgumentString("LocalizedText", translationKey);
	}

	public static string MonsterName(string monsterId, string fallbackText = null)
	{
		if (fallbackText == null)
		{
			return BuildTokenWithArgumentString("MonsterName", monsterId);
		}
		return BuildTokenWithArgumentString("MonsterName", monsterId, fallbackText);
	}

	public static string MovieName(string movieId)
	{
		return BuildTokenWithArgumentString("MovieName", movieId);
	}

	public static string NumberWithSeparators(int number)
	{
		return BuildTokenWithArgumentString("NumberWithSeparators", number.ToString());
	}

	public static string SpecialOrderName(string orderId)
	{
		return BuildTokenWithArgumentString("SpecialOrderName", orderId);
	}

	public static string ToolName(string itemId, int upgradeLevel)
	{
		return BuildTokenWithArgumentString("ToolName", itemId, upgradeLevel.ToString());
	}

	public static string BuildTokenWithArgumentString(string tokenName, string argument)
	{
		return "[" + tokenName + " " + EscapedText(argument) + "]";
	}

	public static string BuildTokenWithArgumentString(string tokenName, string arg1, string arg2)
	{
		return "[" + tokenName + " " + EscapedText(arg1) + " " + EscapedText(arg2) + "]";
	}

	public static string BuildTokenWithArgumentString(string tokenName, string arg1, string arg2, string arg3)
	{
		return "[" + tokenName + " " + EscapedText(arg1) + " " + EscapedText(arg2) + " " + EscapedText(arg3) + "]";
	}
}
