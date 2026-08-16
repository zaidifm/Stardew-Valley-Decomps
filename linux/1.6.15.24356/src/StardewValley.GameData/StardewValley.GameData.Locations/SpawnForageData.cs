using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Locations;

public class SpawnForageData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public double Chance { get; set; } = 1.0;

	[ContentSerializer(Optional = true)]
	public Season? Season { get; set; }
}
