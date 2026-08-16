using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FruitTrees;

public class FruitTreeData
{
	[ContentSerializer(Optional = true)]
	public List<PlantableRule> PlantableLocationRules;

	public string DisplayName { get; set; }

	public List<Season> Seasons { get; set; }

	public List<FruitTreeFruitData> Fruit { get; set; }

	public string Texture { get; set; }

	public int TextureSpriteRow { get; set; }

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields { get; set; }
}
