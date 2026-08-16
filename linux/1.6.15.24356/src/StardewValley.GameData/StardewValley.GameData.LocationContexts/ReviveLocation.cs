using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.LocationContexts;

public class ReviveLocation
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public string Location;

	public Point Position;
}
