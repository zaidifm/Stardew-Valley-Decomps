using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class LostItem
{
	public string Id;

	public string ItemId;

	[ContentSerializer(Optional = true)]
	public string RequireMailReceived;

	[ContentSerializer(Optional = true)]
	public string RequireEventSeen;
}
