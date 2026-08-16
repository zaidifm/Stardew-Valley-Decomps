using System;
using System.Collections.Generic;
using StardewValley.Internal;

namespace StardewValley.Delegates;

public delegate IEnumerable<ItemQueryResult> ResolveItemQueryDelegate(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError);
