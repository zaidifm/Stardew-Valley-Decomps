using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Machines;

public class MachineOutputRule
{
	public string Id;

	public List<MachineOutputTriggerRule> Triggers;

	[ContentSerializer(Optional = true)]
	public bool UseFirstValidOutput;

	[ContentSerializer(Optional = true)]
	public List<MachineItemOutput> OutputItem;

	[ContentSerializer(Optional = true)]
	public int MinutesUntilReady = -1;

	[ContentSerializer(Optional = true)]
	public int DaysUntilReady = -1;

	[ContentSerializer(Optional = true)]
	public string InvalidCountMessage;

	[ContentSerializer(Optional = true)]
	public bool RecalculateOnCollect;
}
