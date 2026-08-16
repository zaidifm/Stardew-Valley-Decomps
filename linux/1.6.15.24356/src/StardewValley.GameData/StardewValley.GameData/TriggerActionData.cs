using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class TriggerActionData
{
	public string Id;

	public string Trigger;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public string SkipPermanentlyCondition;

	[ContentSerializer(Optional = true)]
	public bool HostOnly;

	[ContentSerializer(Optional = true)]
	public string Action;

	[ContentSerializer(Optional = true)]
	public List<string> Actions;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;

	[ContentSerializer(Optional = true)]
	public bool MarkActionApplied = true;
}
