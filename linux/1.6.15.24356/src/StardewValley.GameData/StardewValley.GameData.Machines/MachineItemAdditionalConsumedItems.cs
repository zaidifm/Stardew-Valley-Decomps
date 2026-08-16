using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Machines;

public class MachineItemAdditionalConsumedItems
{
	public string ItemId;

	[ContentSerializer(Optional = true)]
	public int RequiredCount = 1;

	public string InvalidCountMessage;
}
