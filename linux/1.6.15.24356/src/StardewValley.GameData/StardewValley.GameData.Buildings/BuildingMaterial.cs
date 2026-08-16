using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class BuildingMaterial
{
	[ContentSerializerIgnore]
	public string Id => ItemId;

	public string ItemId { get; set; }

	public int Amount { get; set; }
}
