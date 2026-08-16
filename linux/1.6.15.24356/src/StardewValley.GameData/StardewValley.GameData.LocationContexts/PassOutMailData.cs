using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.LocationContexts;

public class PassOutMailData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public string Mail;

	[ContentSerializer(Optional = true)]
	public int MaxPassOutCost = -1;

	[ContentSerializer(Optional = true)]
	public bool SkipRandomSelection;
}
