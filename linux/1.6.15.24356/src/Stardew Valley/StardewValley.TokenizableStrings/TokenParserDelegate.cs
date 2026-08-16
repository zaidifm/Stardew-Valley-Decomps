using System;

namespace StardewValley.TokenizableStrings;

public delegate bool TokenParserDelegate(string[] query, out string replacement, Random random, Farmer player);
