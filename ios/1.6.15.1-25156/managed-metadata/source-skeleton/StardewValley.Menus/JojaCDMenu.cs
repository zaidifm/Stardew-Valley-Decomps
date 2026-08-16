using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class JojaCDMenu : IClickableMenu
{
	public new const int width = 1280;

	public new const int height = 576;

	public const int buttonWidth = 147;

	public const int buttonHeight = 30;

	private Texture2D noteTexture;

	public List<ClickableComponent> checkboxes;

	private string hoverText;

	private bool boughtSomething;

	private Rectangle bottomBox;

	private Rectangle topBox;

	private float widthMod;

	private float heightMod;

	private int drawScale;

	private ClickableComponent buyButton;

	private Rectangle buyButtonBounds;

	private bool buyButtonIsHeld;

	private bool buyButtonShown;

	private int currentlySelectedBox;

	private string buyText;

	private int exitTimer;

	private int _selectedItemIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JojaCDMenu(Texture2D noteTexture)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void onExitFunction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getPriceFromButtonNumber(int buttonNumber)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getDescriptionFromButtonNumber(int buttonNumber)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpMobileMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickBuyButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}
}
