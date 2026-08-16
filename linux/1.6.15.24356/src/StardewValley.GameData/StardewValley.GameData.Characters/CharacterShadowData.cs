using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Characters;

public class CharacterShadowData
{
	[ContentSerializer(Optional = true)]
	public bool Visible = true;

	[ContentSerializer(Optional = true)]
	public Point Offset = Point.Zero;

	[ContentSerializer(Optional = true)]
	public float Scale = 1f;
}
