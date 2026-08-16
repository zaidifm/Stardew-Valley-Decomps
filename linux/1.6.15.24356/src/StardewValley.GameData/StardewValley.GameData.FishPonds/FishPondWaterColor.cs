using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FishPonds;

public class FishPondWaterColor
{
	public string Id;

	public string Color;

	[ContentSerializer(Optional = true)]
	public int MinPopulation = 1;

	[ContentSerializer(Optional = true)]
	public int MinUnlockedPopulationGate;

	[ContentSerializer(Optional = true)]
	public string Condition;
}
