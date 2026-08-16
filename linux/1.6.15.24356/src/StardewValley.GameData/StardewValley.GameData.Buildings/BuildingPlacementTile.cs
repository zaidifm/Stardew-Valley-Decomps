using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class BuildingPlacementTile
{
	public Rectangle TileArea;

	[ContentSerializer(Optional = true)]
	public bool OnlyNeedsToBePassable;
}
