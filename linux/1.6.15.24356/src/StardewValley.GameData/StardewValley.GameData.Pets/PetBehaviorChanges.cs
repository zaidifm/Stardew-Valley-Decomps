using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Pets;

public class PetBehaviorChanges
{
	[ContentSerializer(Optional = true)]
	public float Weight = 1f;

	[ContentSerializer(Optional = true)]
	public bool OutsideOnly;

	[ContentSerializer(Optional = true)]
	public string UpBehavior;

	[ContentSerializer(Optional = true)]
	public string DownBehavior;

	[ContentSerializer(Optional = true)]
	public string LeftBehavior;

	[ContentSerializer(Optional = true)]
	public string RightBehavior;

	[ContentSerializer(Optional = true)]
	public string Behavior;
}
