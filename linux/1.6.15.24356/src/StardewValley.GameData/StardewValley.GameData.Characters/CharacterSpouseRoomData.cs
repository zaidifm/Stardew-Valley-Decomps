using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Characters;

public class CharacterSpouseRoomData
{
	public static readonly Rectangle DefaultMapSourceRect = new Rectangle(0, 0, 6, 9);

	[ContentSerializer(Optional = true)]
	public string MapAsset;

	[ContentSerializer(Optional = true)]
	public Rectangle MapSourceRect = DefaultMapSourceRect;
}
