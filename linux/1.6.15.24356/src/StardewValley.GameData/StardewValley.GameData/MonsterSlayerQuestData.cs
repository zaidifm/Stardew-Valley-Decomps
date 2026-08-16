using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class MonsterSlayerQuestData
{
	public string DisplayName;

	public List<string> Targets;

	public int Count;

	[ContentSerializer(Optional = true)]
	public string RewardItemId;

	[ContentSerializer(Optional = true)]
	public int RewardItemPrice = -1;

	[ContentSerializer(Optional = true)]
	public string RewardDialogue;

	[ContentSerializer(Optional = true)]
	public string RewardDialogueFlag;

	[ContentSerializer(Optional = true)]
	public string RewardFlag;

	[ContentSerializer(Optional = true)]
	public string RewardFlagAll;

	[ContentSerializer(Optional = true)]
	public string RewardMail;

	[ContentSerializer(Optional = true)]
	public string RewardMailAll;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
