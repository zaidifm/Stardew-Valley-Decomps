using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Pets;

public class PetSummitPerfectionEventData
{
	public Rectangle SourceRect;

	public int AnimationLength;

	[ContentSerializer(Optional = true)]
	public bool Flipped;

	public Vector2 Motion;

	[ContentSerializer(Optional = true)]
	public bool PingPong;
}
