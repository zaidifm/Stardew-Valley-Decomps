using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WildTrees;

public class WildTreeData
{
	public List<WildTreeTextureData> Textures;

	public string SeedItemId;

	[ContentSerializer(Optional = true)]
	public bool SeedPlantable = true;

	[ContentSerializer(Optional = true)]
	public float GrowthChance = 0.2f;

	[ContentSerializer(Optional = true)]
	public float FertilizedGrowthChance = 1f;

	[ContentSerializer(Optional = true)]
	public float SeedSpreadChance = 0.15f;

	[ContentSerializer(Optional = true)]
	public float SeedOnShakeChance = 0.05f;

	[ContentSerializer(Optional = true)]
	public float SeedOnChopChance = 0.75f;

	[ContentSerializer(Optional = true)]
	public bool DropWoodOnChop = true;

	[ContentSerializer(Optional = true)]
	public bool DropHardwoodOnLumberChop = true;

	[ContentSerializer(Optional = true)]
	public bool IsLeafy = true;

	[ContentSerializer(Optional = true)]
	public bool IsLeafyInWinter;

	[ContentSerializer(Optional = true)]
	public bool IsLeafyInFall = true;

	[ContentSerializer(Optional = true)]
	public List<PlantableRule> PlantableLocationRules;

	[ContentSerializer(Optional = true)]
	public bool GrowsInWinter;

	[ContentSerializer(Optional = true)]
	public bool IsStumpDuringWinter;

	[ContentSerializer(Optional = true)]
	public bool AllowWoodpeckers = true;

	[ContentSerializer(Optional = true)]
	public bool UseAlternateSpriteWhenNotShaken;

	[ContentSerializer(Optional = true)]
	public bool UseAlternateSpriteWhenSeedReady;

	[ContentSerializer(Optional = true)]
	public string DebrisColor;

	[ContentSerializer(Optional = true)]
	public List<WildTreeSeedDropItemData> SeedDropItems;

	[ContentSerializer(Optional = true)]
	public List<WildTreeChopItemData> ChopItems;

	[ContentSerializer(Optional = true)]
	public List<WildTreeTapItemData> TapItems;

	[ContentSerializer(Optional = true)]
	public List<WildTreeItemData> ShakeItems;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;

	[ContentSerializer(Optional = true)]
	public bool GrowsMoss;

	public bool CanBeTapped()
	{
		List<WildTreeTapItemData> tapItems = TapItems;
		if (tapItems == null)
		{
			return false;
		}
		return tapItems.Count > 0;
	}
}
