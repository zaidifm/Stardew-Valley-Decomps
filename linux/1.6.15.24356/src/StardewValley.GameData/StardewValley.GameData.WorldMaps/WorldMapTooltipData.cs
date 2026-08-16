using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WorldMaps;

public class WorldMapTooltipData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public string KnownCondition;

	[ContentSerializer(Optional = true)]
	public Rectangle PixelArea;

	public string Text;

	public string LeftNeighbor;

	public string RightNeighbor;

	public string UpNeighbor;

	public string DownNeighbor;
}
