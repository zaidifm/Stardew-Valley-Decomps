using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Pets;

public class PetBreed
{
	public string Id;

	public string Texture;

	public string IconTexture;

	public Rectangle IconSourceRect = Rectangle.Empty;

	[ContentSerializer(Optional = true)]
	public bool CanBeChosenAtStart = true;

	[ContentSerializer(Optional = true)]
	public bool CanBeAdoptedFromMarnie = true;

	[ContentSerializer(Optional = true)]
	public int AdoptionPrice = 40000;

	[ContentSerializer(Optional = true)]
	public string BarkOverride;

	[ContentSerializer(Optional = true)]
	public float VoicePitch = 1f;
}
