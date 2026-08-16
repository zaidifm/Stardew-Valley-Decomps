namespace StardewValley;

public class WaterTiles
{
	public struct WaterTileData(bool is_water, bool is_visible)
	{
		public bool isWater = is_water;

		public bool isVisible = is_visible;
	}

	public WaterTileData[,] waterTiles;

	public bool this[int x, int y]
	{
		get
		{
			return waterTiles[x, y].isWater;
		}
		set
		{
			waterTiles[x, y] = new WaterTileData(value, is_visible: true);
		}
	}

	public WaterTiles(bool[,] source)
	{
		int length = source.GetLength(0);
		int length2 = source.GetLength(1);
		waterTiles = new WaterTileData[length, length2];
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length2; j++)
			{
				waterTiles[i, j] = new WaterTileData(source[i, j], is_visible: true);
			}
		}
	}

	public WaterTiles(int width, int height)
	{
		waterTiles = new WaterTileData[width, height];
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				waterTiles[i, j] = new WaterTileData(is_water: false, is_visible: true);
			}
		}
	}
}
