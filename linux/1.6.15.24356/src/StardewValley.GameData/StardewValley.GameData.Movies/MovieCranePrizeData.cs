using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Movies;

public class MovieCranePrizeData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public int Rarity { get; set; } = 1;
}
