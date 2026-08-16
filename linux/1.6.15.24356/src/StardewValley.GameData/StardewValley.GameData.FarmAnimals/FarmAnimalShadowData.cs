using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FarmAnimals;

public class FarmAnimalShadowData
{
	[ContentSerializer(Optional = true)]
	public bool Visible = true;

	[ContentSerializer(Optional = true)]
	public Point? Offset;

	[ContentSerializer(Optional = true)]
	public float? Scale;
}
