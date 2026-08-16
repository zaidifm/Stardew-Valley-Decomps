using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Characters;

public class CharacterSpousePatioData
{
	public static readonly Rectangle DefaultMapSourceRect = new Rectangle(0, 0, 4, 4);

	[ContentSerializer(Optional = true)]
	public string MapAsset;

	[ContentSerializer(Optional = true)]
	public Rectangle MapSourceRect = DefaultMapSourceRect;

	[ContentSerializer(Optional = true)]
	public List<int[]> SpriteAnimationFrames;

	[ContentSerializer(Optional = true)]
	public Point SpriteAnimationPixelOffset;
}
