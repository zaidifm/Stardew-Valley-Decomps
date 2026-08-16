using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class BuildingTileProperty
{
	public string Id;

	public string Name;

	[ContentSerializer(Optional = true)]
	public string Value;

	public string Layer;

	public Rectangle TileArea;
}
