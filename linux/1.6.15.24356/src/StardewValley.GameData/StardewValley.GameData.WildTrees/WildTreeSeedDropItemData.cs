using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WildTrees;

public class WildTreeSeedDropItemData : WildTreeItemData
{
	[ContentSerializer(Optional = true)]
	public bool ContinueOnDrop { get; set; }
}
