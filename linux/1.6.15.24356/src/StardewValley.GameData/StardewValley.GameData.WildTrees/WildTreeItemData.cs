using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WildTrees;

public class WildTreeItemData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public Season? Season { get; set; }

	[ContentSerializer(Optional = true)]
	public float Chance { get; set; } = 1f;
}
