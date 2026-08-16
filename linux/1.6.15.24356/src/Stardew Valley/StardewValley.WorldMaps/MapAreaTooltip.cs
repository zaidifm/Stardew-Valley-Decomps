using Microsoft.Xna.Framework;
using StardewValley.GameData.WorldMaps;

namespace StardewValley.WorldMaps;

public class MapAreaTooltip
{
	protected Rectangle? CachedPixelArea;

	public MapArea Area { get; }

	public WorldMapTooltipData Data { get; }

	public string Text { get; }

	public string NamespacedId { get; }

	public MapAreaTooltip(MapArea mapArea, WorldMapTooltipData data, string text)
	{
		Area = mapArea;
		Data = data;
		Text = text;
		NamespacedId = mapArea.Id + "/" + data.Id;
	}

	public Rectangle GetPixelArea()
	{
		Rectangle? cachedPixelArea = CachedPixelArea;
		if (!cachedPixelArea.HasValue)
		{
			Rectangle pixelArea = Data.PixelArea;
			if (pixelArea.IsEmpty)
			{
				pixelArea = Area.Data.PixelArea;
			}
			CachedPixelArea = new Rectangle(pixelArea.X * 4, pixelArea.Y * 4, pixelArea.Width * 4, pixelArea.Height * 4);
		}
		return CachedPixelArea.Value;
	}
}
