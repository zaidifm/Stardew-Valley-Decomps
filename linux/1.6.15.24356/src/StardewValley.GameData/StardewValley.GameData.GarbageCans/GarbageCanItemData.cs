using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.GarbageCans;

public class GarbageCanItemData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public bool IgnoreBaseChance { get; set; }

	[ContentSerializer(Optional = true)]
	public bool IsMegaSuccess { get; set; }

	[ContentSerializer(Optional = true)]
	public bool IsDoubleMegaSuccess { get; set; }

	[ContentSerializer(Optional = true)]
	public bool AddToInventoryDirectly { get; set; }

	[ContentSerializer(Optional = true)]
	public bool CreateMultipleDebris { get; set; }
}
