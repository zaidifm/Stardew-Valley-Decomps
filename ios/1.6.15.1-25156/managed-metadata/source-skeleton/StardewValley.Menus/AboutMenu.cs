using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class AboutMenu : IClickableMenu
{
	public const int region_upArrow = 94444;

	public const int region_downArrow = 95555;

	public new const int height = 800;

	public ClickableComponent backButton;

	public ClickableTextureComponent upButton;

	public ClickableTextureComponent downButton;

	public List<ICreditsBlock> credits;

	private int currentCreditsIndex;

	private float mobile_yScrollMomentum;

	private float mobile_scrollAccumulator;

	private float mobile_previousYTapPosition;

	private bool tapHeld;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AboutMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUpCredits()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}
}
