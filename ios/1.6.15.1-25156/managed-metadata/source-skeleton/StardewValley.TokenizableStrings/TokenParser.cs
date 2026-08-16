using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.TokenizableStrings;

public class TokenParser
{
	public static class DefaultResolvers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AchievementName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ArticleFor(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CapitalizeFirstLetter(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool EscapedText(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GenderedText(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ItemName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ItemNameWithFlavor(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LocalizedText(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool MonsterName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool MovieName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool NumberWithSeparators(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PositiveAdjective(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SpecialOrderName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SpouseFarmerText(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SpouseGenderedText(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ToolName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DayOfMonth(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Season(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CharacterName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FarmName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FarmerUniqueId(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LocationName(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FarmerStat(string[] query, out string replacement, Random random, Farmer player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private static readonly Dictionary<string, TokenParserDelegate> Parsers;

	private const char EscapedSpace = '\u00a0';

	private const char EscapedEmpty = '\u200b';

	private static readonly string EscapedEmptyStr;

	internal const char StartTokenChar = '[';

	internal const char EndTokenChar = ']';

	internal static readonly char[] HeuristicCharactersForEscapableStrings;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenParser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterParser(string tokenKey, TokenParserDelegate parser)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string EscapeSpaces(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ParseText(string text, Random random = null, TokenParserDelegate customParser = null, Farmer player = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LogTokenError(string[] query, string error, out string replacement)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LogTokenError(string[] query, Exception error, out string replacement)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int ParseTagStartingAt(ref string text, int startIndex, Random random, TokenParserDelegate customParser, Farmer player)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool ParseTag(string tag, out string replacement, Random random, TokenParserDelegate customParser, Farmer player)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string UnescapeText(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TokenParser()
	{
	}
}
