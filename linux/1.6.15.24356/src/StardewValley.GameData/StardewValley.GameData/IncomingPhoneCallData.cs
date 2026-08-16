using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class IncomingPhoneCallData
{
	[ContentSerializer(Optional = true)]
	public string TriggerCondition;

	[ContentSerializer(Optional = true)]
	public string RingCondition;

	[ContentSerializer(Optional = true)]
	public string FromNpc;

	[ContentSerializer(Optional = true)]
	public string FromPortrait;

	[ContentSerializer(Optional = true)]
	public string FromDisplayName;

	public string Dialogue;

	[ContentSerializer(Optional = true)]
	public bool IgnoreBaseChance;

	[ContentSerializer(Optional = true)]
	public string SimpleDialogueSplitBy;

	[ContentSerializer(Optional = true)]
	public int MaxCalls = 1;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
