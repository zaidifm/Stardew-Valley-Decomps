using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Locations;

public class CreateLocationData
{
	public string MapPath;

	[ContentSerializer(Optional = true)]
	public string Type;

	[ContentSerializer(Optional = true)]
	public bool AlwaysActive;
}
