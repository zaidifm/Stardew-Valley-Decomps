using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class MobileColorPicker : IClickableMenu
{
	public const int sliderChunks = 24;

	private int colorIndexSelection;

	private Rectangle bounds;

	private Rectangle expandedBounds;

	public SliderBar hueBar;

	public SliderBar valueBar;

	public SliderBar saturationBar;

	public SliderBar recentSliderBar;

	public string Name;

	public Color LastColor;

	public bool Dirty;

	public int barWidth;

	private int barHeight;

	private int barY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileColorPicker(string name, Rectangle bounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileColorPicker(string name, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color getSelectedColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color click(int x, int y, bool ignoreBounds = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeHue(int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeSaturation(int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeValue(int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color clickHeld(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void releaseClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool containsPoint(int x, int y, bool useExpandedBounds = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setColor(Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RGBtoHSV(float r, float g, float b, out float h, out float s, out float v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color HsvToRgb(double h, double S, double V)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int Clamp(int i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
