using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WorldMaps;

public class WorldMapTextureData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public string Texture;

	[ContentSerializer(Optional = true)]
	public Rectangle SourceRect;

	[ContentSerializer(Optional = true)]
	public Rectangle MapPixelArea;
}
