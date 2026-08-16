using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FarmAnimals;

public class FarmAnimalProduce
{
	[ContentSerializer(Optional = true)]
	public string Id { get; set; }

	[ContentSerializer(Optional = true)]
	public string Condition { get; set; }

	[ContentSerializer(Optional = true)]
	public int MinimumFriendship { get; set; }

	public string ItemId { get; set; }
}
