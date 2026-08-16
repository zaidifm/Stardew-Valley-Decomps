using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class OptionsPlusMinus : OptionsElement
{
	public const int pixelsWide = 7;

	public List<string> options;

	public List<string> displayOptions;

	public int selected;

	public bool isChecked;

	public static bool snapZoomPlus;

	public static bool snapZoomMinus;

	private Rectangle minusButton;

	private Rectangle plusButton;

	public static Rectangle minusButtonSource;

	public static Rectangle plusButtonSource;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsPlusMinus(string label, int whichOption, List<string> options, List<string> displayOptions, int x = -1, int y = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, int slotX, int slotY)
	{
	}
}
