using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FishPonds;

public class FishPondData
{
	public string Id;

	public List<string> RequiredTags;

	[ContentSerializer(Optional = true)]
	public int Precedence;

	[ContentSerializer(Optional = true)]
	public int MaxPopulation = -1;

	[ContentSerializer(Optional = true)]
	public int SpawnTime = -1;

	[ContentSerializer(Optional = true)]
	public float BaseMinProduceChance = 0.15f;

	[ContentSerializer(Optional = true)]
	public float BaseMaxProduceChance = 0.95f;

	[ContentSerializer(Optional = true)]
	public List<FishPondWaterColor> WaterColor;

	public List<FishPondReward> ProducedItems;

	[ContentSerializer(Optional = true)]
	public Dictionary<int, List<string>> PopulationGates;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
