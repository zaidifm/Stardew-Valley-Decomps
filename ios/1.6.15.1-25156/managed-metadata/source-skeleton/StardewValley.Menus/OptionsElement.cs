using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class OptionsElement : IClickableMenu
{
	public enum Style
	{
		Default,
		OptionLabel
	}

	public const int defaultX = 8;

	public const int defaultY = 4;

	public const int defaultPixelWidth = 9;

	public Rectangle bounds;

	public string label;

	public int whichOption;

	public bool greyedOut;

	public static int optionsItemHeight;

	public Style style;

	public virtual int ItemHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsElement(string label)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsElement(string label, int x, int y, int width, int height, int whichOption = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsElement(string label, Rectangle bounds, int whichOption)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new virtual void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void leftClickReleased(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new virtual void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, int slotX, int slotY)
	{
	}
}
