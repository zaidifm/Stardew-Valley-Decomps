using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class TextEntryMenu : IClickableMenu
{
	public const int borderSpace = 4;

	public const int buttonSize = 16;

	public const int windowWidth = 168;

	public const int windowHeight = 88;

	public string[][] letterMaps;

	public List<ClickableTextureComponent> keys;

	public ClickableTextureComponent backspaceButton;

	public ClickableTextureComponent spaceButton;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent upperCaseButton;

	public ClickableTextureComponent symbolsButton;

	protected int _lettersPerRow;

	protected TextBox _target;

	public int _currentKeyboard;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TextEntryMenu(TextBox target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowKeyboard(int index, bool play_sound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RepositionElements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSubmit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSpaceBar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBackSpace()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLetter(string letter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Close()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}
}
