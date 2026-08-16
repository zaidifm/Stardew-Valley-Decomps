using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.WorldMaps;

public class MapAreaTexture
{
	public Texture2D Texture { get; }

	public Rectangle SourceRect { get; }

	public Rectangle MapPixelArea { get; }

	public MapAreaTexture(Texture2D texture, Rectangle sourceRect, Rectangle mapPixelArea)
	{
		Texture = texture;
		SourceRect = sourceRect;
		MapPixelArea = mapPixelArea;
	}

	public Rectangle GetOffsetMapPixelArea(int x, int y)
	{
		return new Rectangle(MapPixelArea.X + x, MapPixelArea.Y + y, MapPixelArea.Width, MapPixelArea.Height);
	}
}
