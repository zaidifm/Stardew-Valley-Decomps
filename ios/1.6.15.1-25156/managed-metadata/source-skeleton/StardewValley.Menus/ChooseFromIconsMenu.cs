using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ChooseFromIconsMenu : IClickableMenu
{
	private Rectangle iconBackRectangle;

	private Texture2D texture;

	private Point iconBackHighlightPosition;

	private Point iconFrontHighlightPositionOffset;

	private string which;

	public List<ClickableTextureComponent> icons;

	public List<ClickableTextureComponent> iconFronts;

	private int iconXOffset;

	private int maxTooltipHeight;

	private int maxTooltipWidth;

	private float destroyTimer;

	private List<TemporaryAnimatedSprite> temporarySprites;

	public Object sourceObject;

	private bool hasTooltips;

	private string title;

	private string hoverSound;

	private int titleStyle;

	private int selected;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChooseFromIconsMenu(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpIcons(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
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
	private void doIconAction(string iconName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void flairOnDestroy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
