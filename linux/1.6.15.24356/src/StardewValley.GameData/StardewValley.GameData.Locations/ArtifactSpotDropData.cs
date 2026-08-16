using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Locations;

public class ArtifactSpotDropData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public double Chance { get; set; } = 1.0;

	[ContentSerializer(Optional = true)]
	public bool ApplyGenerousEnchantment { get; set; } = true;

	[ContentSerializer(Optional = true)]
	public bool OneDebrisPerDrop { get; set; } = true;

	[ContentSerializer(Optional = true)]
	public int Precedence { get; set; }

	[ContentSerializer(Optional = true)]
	public bool ContinueOnDrop { get; set; }
}
