using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class OptionsDropDown : OptionsElement
{
	public static Rectangle dropDownBGSource;

	public static Rectangle dropDownButtonSource;

	public static OptionsDropDown selected;

	public ClickableTextureComponent buttonHelp;

	public string url;

	private bool _buttonHelpClicked;

	public List<string> dropDownOptions;

	public List<string> dropDownDisplayOptions;

	public int selectedOption;

	public int recentSlotY;

	public int startingSelected;

	public bool dropDownOpen;

	private Rectangle dropDownBounds;

	public override int ItemHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsDropDown(string label, int whichOption, int x = -1, int y = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddHelpButton(string url)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RecalculateBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickReleased(int x, int y)
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
