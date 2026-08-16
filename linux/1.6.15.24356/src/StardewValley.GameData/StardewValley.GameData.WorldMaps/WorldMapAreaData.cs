using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WorldMaps;

public class WorldMapAreaData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public Rectangle PixelArea;

	[ContentSerializer(Optional = true)]
	public string ScrollText;

	[ContentSerializer(Optional = true)]
	public List<WorldMapTextureData> Textures = new List<WorldMapTextureData>();

	[ContentSerializer(Optional = true)]
	public List<WorldMapTooltipData> Tooltips = new List<WorldMapTooltipData>();

	[ContentSerializer(Optional = true)]
	public List<WorldMapAreaPositionData> WorldPositions = new List<WorldMapAreaPositionData>();

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
