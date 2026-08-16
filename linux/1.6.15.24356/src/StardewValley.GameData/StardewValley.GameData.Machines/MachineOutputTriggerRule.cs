using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Machines;

public class MachineOutputTriggerRule
{
	private string IdImpl;

	[ContentSerializer(Optional = true)]
	public string Id
	{
		get
		{
			return IdImpl ?? Trigger.ToString();
		}
		set
		{
			IdImpl = value;
		}
	}

	[ContentSerializer(Optional = true)]
	public MachineOutputTrigger Trigger { get; set; } = MachineOutputTrigger.ItemPlacedInMachine;

	[ContentSerializer(Optional = true)]
	public string RequiredItemId { get; set; }

	[ContentSerializer(Optional = true)]
	public List<string> RequiredTags { get; set; }

	[ContentSerializer(Optional = true)]
	public int RequiredCount { get; set; } = 1;

	[ContentSerializer(Optional = true)]
	public string Condition { get; set; }
}
