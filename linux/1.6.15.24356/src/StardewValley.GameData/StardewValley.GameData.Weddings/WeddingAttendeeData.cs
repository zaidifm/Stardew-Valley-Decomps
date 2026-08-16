using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Weddings;

public class WeddingAttendeeData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public string Setup;

	[ContentSerializer(Optional = true)]
	public string Celebration;

	[ContentSerializer(Optional = true)]
	public bool IgnoreUnlockConditions;
}
