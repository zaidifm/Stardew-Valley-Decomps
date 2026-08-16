using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class IndoorItemMove
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public Point Source;

	[ContentSerializer(Optional = true)]
	public Point Destination;

	[ContentSerializer(Optional = true)]
	public Point Size = new Point(1, 1);

	[ContentSerializer(Optional = true)]
	public string UnlessItemId;
}
