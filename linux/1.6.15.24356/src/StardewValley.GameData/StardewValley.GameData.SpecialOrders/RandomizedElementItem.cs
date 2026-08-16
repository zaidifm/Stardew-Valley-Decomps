using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.SpecialOrders;

public class RandomizedElementItem
{
	[ContentSerializer(Optional = true)]
	public string RequiredTags = "";

	public string Value = "";
}
