using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ColorPicker
{
	public const int sliderChunks = 24;

	private Rectangle bounds;

	public SliderBar hueBar;

	public SliderBar valueBar;

	public SliderBar saturationBar;

	public SliderBar recentSliderBar;

	public string Name;

	public Color LastColor;

	public bool Dirty;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ColorPicker(string name, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color getSelectedColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color click(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool containsPoint(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setColor(Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setHsvColor(float hue, float sat, float value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RGBtoHSV(float r, float g, float b, out float h, out float s, out float v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color HsvToRgb(double hue, double saturation, double value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Clamp(int value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
