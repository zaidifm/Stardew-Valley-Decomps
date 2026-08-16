using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WorldMaps;

public class WorldMapAreaPositionScrollTextZoneData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public Rectangle TileArea;

	[ContentSerializer(Optional = true)]
	public string ScrollText;
}
