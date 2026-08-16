using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class GenericSpawnItemDataWithCondition : GenericSpawnItemData
{
	[ContentSerializer(Optional = true)]
	public string Condition { get; set; }
}
