using System;
using System.Linq;
using StardewValley.Extensions;
using StardewValley.TokenizableStrings;

namespace StardewValley.BellsAndWhistles;

public class Lexicon
{
	public static string getRandomNegativeItemSlanderNoun()
	{
		Random random = Utility.CreateDaySaveRandom();
		string[] options = Game1.content.LoadString("Strings\\Lexicon:RandomNegativeItemNoun").Split('#');
		return random.Choose(options);
	}

	public static string getProperArticleForWord(string word)
	{
		if (LocalizedContentManager.CurrentLanguageCode != LocalizedContentManager.LanguageCode.en)
		{
			return "";
		}
		if (word != null && word.Length > 0)
		{
			switch (word.ToLower()[0])
			{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
				return "an";
			}
		}
		return "a";
	}

	public static string capitalize(string text)
	{
		if (string.IsNullOrEmpty(text) || LocalizedContentManager.CurrentLanguageCode != LocalizedContentManager.LanguageCode.en)
		{
			return text;
		}
		int num = 0;
		for (int i = 0; i < text.Length; i++)
		{
			if (char.IsLetter(text[i]))
			{
				num = i;
				break;
			}
		}
		if (num == 0)
		{
			return text[0].ToString().ToUpper() + text.Substring(1);
		}
		return text.Substring(0, num) + text[num].ToString().ToUpper() + text.Substring(num + 1);
	}

	public static string makePlural(string word, bool ignore = false)
	{
		if (ignore || LocalizedContentManager.CurrentLanguageCode != LocalizedContentManager.LanguageCode.en || word == null)
		{
			return word;
		}
		switch (word)
		{
		case "Dragon Tooth":
			return "Dragon Teeth";
		case "Rice Pudding":
			return "bowls of Rice Pudding";
		case "Algae Soup":
			return "bowls of Algae Soup";
		case "Coal":
			return "lumps of Coal";
		case "Salt":
			return "pieces of Salt";
		case "Jelly":
			return "Jellies";
		case "Wheat":
			return "bushels of Wheat";
		case "Ginger":
			return "pieces of Ginger";
		case "Garlic":
			return "bulbs of Garlic";
		case "Glass Shards":
		case "Hashbrowns":
		case "Tea Leaves":
		case "Crab Cakes":
		case "Carp":
		case "Chub":
		case "Clay":
		case "Hops":
		case "Bream":
		case "Weeds":
		case "Bok Choy":
		case "Pancakes":
		case "Sandfish":
		case "Broken Glasses":
		case "Pepper Poppers":
		case "Cranberries":
		case "Glazed Yams":
		case "Green Canes":
		case "Mixed Seeds":
		case "Star Shards":
		case "Dried Cranberries":
		case "Roasted Hazelnuts":
		case "Driftwood":
		case "Ghostfish":
		case "Red Canes":
		case "Fossilized Ribs":
		case "Largemouth Bass":
		case "Smallmouth Bass":
		case "Dried Sunflowers":
		case "Hay":
		case "Pickles":
		case "Warp Totem: Mountains":
			return word;
		default:
			switch (word.Last())
			{
			case 'y':
				return word.Substring(0, word.Length - 1) + "ies";
			case 's':
				if (!word.EndsWith(" Seeds") && !word.EndsWith(" Shorts") && !word.EndsWith(" Bass") && !word.EndsWith(" Flowers") && !word.EndsWith(" Peach"))
				{
					return word + "es";
				}
				return word;
			case 'x':
			case 'z':
				return word + "es";
			default:
				if (word.Length > 2)
				{
					string text = word.Substring(word.Length - 2);
					if (text == "sh" || text == "ch")
					{
						return word + "es";
					}
				}
				return word + "s";
			}
		}
	}

	public static string prependArticle(string word)
	{
		if (LocalizedContentManager.CurrentLanguageCode != LocalizedContentManager.LanguageCode.en)
		{
			return word;
		}
		return getProperArticleForWord(word) + " " + word;
	}

	public static string prependTokenizedArticle(string word)
	{
		if (LocalizedContentManager.CurrentLanguageCode != LocalizedContentManager.LanguageCode.en)
		{
			return word;
		}
		return TokenStringBuilder.ArticleFor(word) + " " + word;
	}

	public static string getRandomPositiveAdjectiveForEventOrPerson(NPC n = null)
	{
		Random random = Utility.CreateDaySaveRandom();
		string[] options = ((n != null && n.Age != 0) ? Game1.content.LoadString("Strings\\Lexicon:RandomPositiveAdjective_Child").Split('#') : (n?.Gender switch
		{
			Gender.Male => Game1.content.LoadString("Strings\\Lexicon:RandomPositiveAdjective_AdultMale").Split('#'), 
			Gender.Female => Game1.content.LoadString("Strings\\Lexicon:RandomPositiveAdjective_AdultFemale").Split('#'), 
			_ => Game1.content.LoadString("Strings\\Lexicon:RandomPositiveAdjective_PlaceOrEvent").Split('#'), 
		}));
		return random.Choose(options);
	}

	public static string getRandomDeliciousAdjective(NPC n = null)
	{
		Random random = Utility.CreateDaySaveRandom();
		string[] options = ((n == null || n.Age != 2) ? Game1.content.LoadString("Strings\\Lexicon:RandomDeliciousAdjective").Split('#') : Game1.content.LoadString("Strings\\Lexicon:RandomDeliciousAdjective_Child").Split('#'));
		return random.Choose(options);
	}

	public static string getRandomNegativeFoodAdjective(NPC n = null)
	{
		Random random = Utility.CreateDaySaveRandom();
		string[] options = ((n != null && n.Age == 2) ? Game1.content.LoadString("Strings\\Lexicon:RandomNegativeFoodAdjective_Child").Split('#') : ((n == null || n.Manners != 1) ? Game1.content.LoadString("Strings\\Lexicon:RandomNegativeFoodAdjective").Split('#') : Game1.content.LoadString("Strings\\Lexicon:RandomNegativeFoodAdjective_Polite").Split('#')));
		return random.Choose(options);
	}

	public static string getRandomSlightlyPositiveAdjectiveForEdibleNoun(NPC n = null)
	{
		Random random = Utility.CreateDaySaveRandom();
		string[] options = Game1.content.LoadString("Strings\\Lexicon:RandomSlightlyPositiveFoodAdjective").Split('#');
		return random.Choose(options);
	}

	public static string getGenderedChildTerm(bool isMale)
	{
		return Game1.content.LoadString(isMale ? "Strings\\Lexicon:ChildTerm_Male" : "Strings\\Lexicon:ChildTerm_Female");
	}

	public static string getTokenizedGenderedChildTerm(bool isMale)
	{
		return TokenStringBuilder.LocalizedText(isMale ? "Strings\\Lexicon:ChildTerm_Male" : "Strings\\Lexicon:ChildTerm_Female");
	}

	public static string getPronoun(bool isMale)
	{
		return Game1.content.LoadString(isMale ? "Strings\\Lexicon:Pronoun_Male" : "Strings\\Lexicon:Pronoun_Female");
	}

	public static string getTokenizedPronoun(bool isMale)
	{
		return TokenStringBuilder.LocalizedText(isMale ? "Strings\\Lexicon:Pronoun_Male" : "Strings\\Lexicon:Pronoun_Female");
	}

	public static string getPossessivePronoun(bool isMale)
	{
		return Game1.content.LoadString(isMale ? "Strings\\Lexicon:Possessive_Pronoun_Male" : "Strings\\Lexicon:Possessive_Pronoun_Female");
	}

	public static string getTokenizedPossessivePronoun(bool isMale)
	{
		return TokenStringBuilder.LocalizedText(isMale ? "Strings\\Lexicon:Possessive_Pronoun_Male" : "Strings\\Lexicon:Possessive_Pronoun_Female");
	}
}
