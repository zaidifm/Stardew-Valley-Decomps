using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public class RainDrop
{
	public int frame;

	public int accumulator;

	public Vector2 position;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RainDrop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RainDrop(int x, int y, int frame, int accumulator)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int x, int y, int frame, int accumulator)
	{
	}
}
