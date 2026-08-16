using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class SliderBar
{
	public static int defaultWidth;

	public const int defaultHeight = 20;

	public const int fullHeight = 80;

	public int value;

	public int expansion_x;

	public int expansion_y;

	public Rectangle bounds;

	public Rectangle expandedBounds;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SliderBar(int x, int y, int initialValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateExpandedBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int click(int x, int y, bool wasAlreadyHeld = false, bool ignoreBounds = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeValueBy(int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void release(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}
}
