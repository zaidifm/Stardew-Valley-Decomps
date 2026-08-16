using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.GiantCrops;

public class GiantCropHarvestItemData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public float Chance { get; set; } = 1f;

	[ContentSerializer(Optional = true)]
	public bool? ForShavingEnchantment { get; set; }

	[ContentSerializer(Optional = true)]
	public int? ScaledMinStackWhenShaving { get; set; } = 2;

	[ContentSerializer(Optional = true)]
	public int? ScaledMaxStackWhenShaving { get; set; } = 2;
}
