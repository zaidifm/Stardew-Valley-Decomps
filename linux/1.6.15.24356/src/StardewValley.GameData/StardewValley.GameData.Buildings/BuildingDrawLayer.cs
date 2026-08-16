using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class BuildingDrawLayer
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Texture;

	public Rectangle SourceRect = Rectangle.Empty;

	public Vector2 DrawPosition;

	[ContentSerializer(Optional = true)]
	public bool DrawInBackground;

	[ContentSerializer(Optional = true)]
	public float SortTileOffset;

	[ContentSerializer(Optional = true)]
	public string OnlyDrawIfChestHasContents;

	[ContentSerializer(Optional = true)]
	public int FrameDuration = 90;

	[ContentSerializer(Optional = true)]
	public int FrameCount = 1;

	[ContentSerializer(Optional = true)]
	public int FramesPerRow = -1;

	[ContentSerializer(Optional = true)]
	public Point AnimalDoorOffset = Point.Zero;

	public Rectangle GetSourceRect(int time)
	{
		Rectangle sourceRect = SourceRect;
		time /= FrameDuration;
		time %= FrameCount;
		if (FramesPerRow < 0)
		{
			sourceRect.X += sourceRect.Width * time;
		}
		else
		{
			sourceRect.X += sourceRect.Width * (time % FramesPerRow);
			sourceRect.Y += sourceRect.Height * (time / FramesPerRow);
		}
		return sourceRect;
	}
}
