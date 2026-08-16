using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class TemporaryAnimatedSpriteDefinition
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public string Texture;

	public Rectangle SourceRect;

	[ContentSerializer(Optional = true)]
	public float Interval = 100f;

	[ContentSerializer(Optional = true)]
	public int Frames = 1;

	[ContentSerializer(Optional = true)]
	public int Loops;

	[ContentSerializer(Optional = true)]
	public Vector2 PositionOffset = Vector2.Zero;

	[ContentSerializer(Optional = true)]
	public bool Flicker;

	[ContentSerializer(Optional = true)]
	public bool Flip;

	[ContentSerializer(Optional = true)]
	public float SortOffset;

	[ContentSerializer(Optional = true)]
	public float AlphaFade;

	[ContentSerializer(Optional = true)]
	public float Scale = 1f;

	[ContentSerializer(Optional = true)]
	public float ScaleChange;

	[ContentSerializer(Optional = true)]
	public float Rotation;

	[ContentSerializer(Optional = true)]
	public float RotationChange;

	[ContentSerializer(Optional = true)]
	public string Color;
}
