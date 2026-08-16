using System;
using System.Collections.Generic;

namespace StardewValley.Delegates;

public readonly struct GameStateQueryContext(GameLocation location, Farmer player, Item targetItem, Item inputItem, Random random, HashSet<string> ignoreQueryKeys = null, Dictionary<string, object> customFields = null)
{
	public readonly GameLocation Location = location ?? player?.currentLocation ?? Game1.currentLocation;

	public readonly GameLocation ExplicitTargetLocation = location;

	public readonly Farmer Player = player ?? Game1.player;

	public readonly Item TargetItem = targetItem;

	public readonly Item InputItem = inputItem;

	public readonly Random Random = random ?? Game1.random;

	public readonly HashSet<string> IgnoreQueryKeys = ignoreQueryKeys;

	public readonly Dictionary<string, object> CustomFields = customFields;
}
