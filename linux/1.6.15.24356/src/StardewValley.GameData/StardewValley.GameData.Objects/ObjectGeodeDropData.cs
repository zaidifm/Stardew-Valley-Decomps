using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Objects;

public class ObjectGeodeDropData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public double Chance { get; set; } = 1.0;

	[ContentSerializer(Optional = true)]
	public string SetFlagOnPickup { get; set; }

	[ContentSerializer(Optional = true)]
	public int Precedence { get; set; }
}
