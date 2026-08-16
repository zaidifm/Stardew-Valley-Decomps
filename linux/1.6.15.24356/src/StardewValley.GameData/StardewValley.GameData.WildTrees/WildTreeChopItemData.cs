using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WildTrees;

public class WildTreeChopItemData : WildTreeItemData
{
	[ContentSerializer(Optional = true)]
	public WildTreeGrowthStage? MinSize { get; set; }

	[ContentSerializer(Optional = true)]
	public WildTreeGrowthStage? MaxSize { get; set; }

	[ContentSerializer(Optional = true)]
	public bool? ForStump { get; set; } = false;

	public bool IsValidForGrowthStage(int size, bool isStump)
	{
		if (size == 4)
		{
			size = 3;
		}
		if ((int?)size < (int?)MinSize)
		{
			return false;
		}
		if ((int?)size > (int?)MaxSize)
		{
			return false;
		}
		if (ForStump.HasValue && ForStump != isStump)
		{
			return false;
		}
		return true;
	}
}
