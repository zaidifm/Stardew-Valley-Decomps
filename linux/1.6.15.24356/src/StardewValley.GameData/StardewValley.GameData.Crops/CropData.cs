using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Crops;

public class CropData
{
	public List<Season> Seasons = new List<Season>();

	public List<int> DaysInPhase = new List<int>();

	[ContentSerializer(Optional = true)]
	public int RegrowDays = -1;

	[ContentSerializer(Optional = true)]
	public bool IsRaised;

	[ContentSerializer(Optional = true)]
	public bool IsPaddyCrop;

	[ContentSerializer(Optional = true)]
	public bool NeedsWatering = true;

	[ContentSerializer(Optional = true)]
	public List<PlantableRule> PlantableLocationRules;

	public string HarvestItemId;

	[ContentSerializer(Optional = true)]
	public int HarvestMinStack = 1;

	[ContentSerializer(Optional = true)]
	public int HarvestMaxStack = 1;

	[ContentSerializer(Optional = true)]
	public float HarvestMaxIncreasePerFarmingLevel;

	[ContentSerializer(Optional = true)]
	public double ExtraHarvestChance;

	[ContentSerializer(Optional = true)]
	public HarvestMethod HarvestMethod;

	[ContentSerializer(Optional = true)]
	public int HarvestMinQuality;

	[ContentSerializer(Optional = true)]
	public int? HarvestMaxQuality;

	[ContentSerializer(Optional = true)]
	public List<string> TintColors = new List<string>();

	public string Texture;

	public int SpriteIndex;

	public bool CountForMonoculture;

	public bool CountForPolyculture;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;

	public string GetCustomTextureName(string defaultName)
	{
		if (string.IsNullOrWhiteSpace(Texture) || !(Texture != defaultName))
		{
			return null;
		}
		return Texture;
	}
}
