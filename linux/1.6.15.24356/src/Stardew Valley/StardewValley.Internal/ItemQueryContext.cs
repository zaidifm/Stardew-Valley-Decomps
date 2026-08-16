using System;
using System.Collections.Generic;

namespace StardewValley.Internal;

public class ItemQueryContext
{
	public GameLocation Location { get; }

	public Farmer Player { get; }

	public Random Random { get; }

	public string QueryString { get; internal set; }

	public ItemQueryContext ParentContext { get; }

	public string SourcePhrase { get; set; }

	public Dictionary<string, object> CustomFields { get; set; }

	public ItemQueryContext()
		: this(null, null, null, null)
	{
	}

	public ItemQueryContext(ItemQueryContext parentContext, string sourceLabel = null)
		: this(parentContext?.Location, parentContext?.Player, parentContext?.Random, parentContext?.SourcePhrase)
	{
		ParentContext = parentContext;
		if (sourceLabel != null)
		{
			SourcePhrase = ((parentContext != null && parentContext.SourcePhrase != null) ? (parentContext.SourcePhrase + " > " + sourceLabel) : sourceLabel);
		}
	}

	public ItemQueryContext(GameLocation location, Farmer player, Random random, string sourcePhrase)
	{
		Location = location ?? Game1.currentLocation;
		Player = player ?? Game1.player;
		Random = random;
		SourcePhrase = sourcePhrase;
	}
}
