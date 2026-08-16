using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Characters;

public class CharacterHomeData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public string Location;

	public Point Tile = Point.Zero;

	[ContentSerializer(Optional = true)]
	public string Direction = "up";
}
