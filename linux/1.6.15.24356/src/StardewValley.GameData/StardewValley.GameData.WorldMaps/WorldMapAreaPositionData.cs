using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WorldMaps;

public class WorldMapAreaPositionData
{
	private string IdImpl;

	[ContentSerializer(Optional = true)]
	public List<WorldMapAreaPositionScrollTextZoneData> ScrollTextZones = new List<WorldMapAreaPositionScrollTextZoneData>();

	[ContentSerializer(Optional = true)]
	public string Id
	{
		get
		{
			return IdImpl ?? LocationName ?? LocationNames?.FirstOrDefault() ?? LocationContext;
		}
		set
		{
			IdImpl = value;
		}
	}

	[ContentSerializer(Optional = true)]
	public string Condition { get; set; }

	[ContentSerializer(Optional = true)]
	public string LocationContext { get; set; }

	[ContentSerializer(Optional = true)]
	public string LocationName { get; set; }

	[ContentSerializer(Optional = true)]
	public List<string> LocationNames { get; set; } = new List<string>();

	[ContentSerializer(Optional = true)]
	public Rectangle TileArea { get; set; }

	[ContentSerializer(Optional = true)]
	public Rectangle? ExtendedTileArea { get; set; }

	[ContentSerializer(Optional = true)]
	public Rectangle MapPixelArea { get; set; }

	[ContentSerializer(Optional = true)]
	public string ScrollText { get; set; }
}
