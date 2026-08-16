using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class BuildingChest
{
	public string Id;

	public BuildingChestType Type;

	[ContentSerializer(Optional = true)]
	public string Sound;

	[ContentSerializer(Optional = true)]
	public string InvalidItemMessage;

	[ContentSerializer(Optional = true)]
	public string InvalidItemMessageCondition;

	[ContentSerializer(Optional = true)]
	public string InvalidCountMessage;

	[ContentSerializer(Optional = true)]
	public string ChestFullMessage;

	[ContentSerializer(Optional = true)]
	public Vector2 DisplayTile = new Vector2(-1f, -1f);

	[ContentSerializer(Optional = true)]
	public float DisplayHeight;
}
