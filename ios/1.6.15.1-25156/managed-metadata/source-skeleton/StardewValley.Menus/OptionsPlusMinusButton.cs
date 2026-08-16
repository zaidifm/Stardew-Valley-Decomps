using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class OptionsPlusMinusButton : OptionsPlusMinus
{
	protected Rectangle _buttonBounds;

	protected Rectangle _buttonRect;

	protected Texture2D _buttonTexture;

	protected Action<string> _buttonAction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsPlusMinusButton(string label, int whichOptions, List<string> options, List<string> displayOptions, Texture2D buttonTexture, Rectangle buttonRect, Action<string> buttonAction, int x = -1, int y = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, int slotX, int slotY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y)
	{
	}
}
