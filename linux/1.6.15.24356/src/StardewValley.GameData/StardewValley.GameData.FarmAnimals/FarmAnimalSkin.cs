using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FarmAnimals;

public class FarmAnimalSkin
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public float Weight = 1f;

	[ContentSerializer(Optional = true)]
	public string Texture;

	[ContentSerializer(Optional = true)]
	public string HarvestedTexture;

	[ContentSerializer(Optional = true)]
	public string BabyTexture;
}
