using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WorldMaps;

public class WorldMapRegionData
{
	public List<WorldMapTextureData> BaseTexture = new List<WorldMapTextureData>();

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> MapNeighborIdAliases = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	public List<WorldMapAreaData> MapAreas = new List<WorldMapAreaData>();
}
