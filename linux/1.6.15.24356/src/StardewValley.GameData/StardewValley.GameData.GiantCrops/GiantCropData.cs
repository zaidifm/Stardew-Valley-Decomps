using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.GiantCrops;

public class GiantCropData
{
	public string FromItemId;

	public List<GiantCropHarvestItemData> HarvestItems;

	public string Texture;

	[ContentSerializer(Optional = true)]
	public Point TexturePosition;

	[ContentSerializer(Optional = true)]
	public Point TileSize = new Point(3, 3);

	[ContentSerializer(Optional = true)]
	public int Health = 3;

	[ContentSerializer(Optional = true)]
	public float Chance = 0.01f;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
