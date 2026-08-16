using System.Runtime.CompilerServices;

namespace StardewValley;

public class WaterTiles
{
	public struct WaterTileData
	{
		public bool isWater;

		public bool isVisible;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WaterTileData(bool is_water, bool is_visible)
		{
		}
	}

	public WaterTileData[,] waterTiles;

	public bool this[int x, int y]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterTiles(bool[,] source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterTiles(int width, int height)
	{
	}
}
