using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class IndoorItemAdd
{
	public string Id;

	public string ItemId;

	public Point Tile;

	[ContentSerializer(Optional = true)]
	public bool Indestructible;

	[ContentSerializer(Optional = true)]
	public bool ClearTile = true;
}
