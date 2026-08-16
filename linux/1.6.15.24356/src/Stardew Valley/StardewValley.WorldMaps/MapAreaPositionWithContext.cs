using Microsoft.Xna.Framework;

namespace StardewValley.WorldMaps;

public readonly struct MapAreaPositionWithContext
{
	public MapAreaPosition Data { get; }

	public GameLocation Location { get; }

	public Point Tile { get; }

	public MapAreaPositionWithContext(MapAreaPosition data, GameLocation location, Point tile)
	{
		Data = data;
		Location = location;
		Tile = tile;
	}

	public Vector2 GetMapPixelPosition()
	{
		return Data.GetMapPixelPosition(Location, Tile);
	}

	public Vector2? GetPositionRatioIfValid()
	{
		return Data.GetPositionRatioIfValid(Location, Tile);
	}

	public string GetScrollText()
	{
		return Data.GetScrollText(Tile);
	}
}
