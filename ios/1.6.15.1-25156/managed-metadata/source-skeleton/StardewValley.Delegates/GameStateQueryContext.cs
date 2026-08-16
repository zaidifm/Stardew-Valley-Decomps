using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Delegates;

public readonly struct GameStateQueryContext
{
	public readonly GameLocation Location;

	public readonly GameLocation ExplicitTargetLocation;

	public readonly Farmer Player;

	public readonly Item TargetItem;

	public readonly Item InputItem;

	public readonly Random Random;

	public readonly HashSet<string> IgnoreQueryKeys;

	public readonly Dictionary<string, object> CustomFields;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameStateQueryContext(GameLocation location, Farmer player, Item targetItem, Item inputItem, Random random, HashSet<string> ignoreQueryKeys = null, Dictionary<string, object> customFields = null)
	{
	}
}
