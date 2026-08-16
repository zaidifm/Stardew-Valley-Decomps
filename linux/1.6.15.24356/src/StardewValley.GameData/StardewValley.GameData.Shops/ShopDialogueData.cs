using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Shops;

public class ShopDialogueData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public string Dialogue;

	[ContentSerializer(Optional = true)]
	public List<string> RandomDialogue;
}
