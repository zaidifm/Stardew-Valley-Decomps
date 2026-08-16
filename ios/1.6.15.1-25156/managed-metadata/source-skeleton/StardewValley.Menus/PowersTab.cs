using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class PowersTab : IClickableMenu
{
	public const int region_forwardButton = 707;

	public const int region_backButton = 706;

	public const int distanceFromMenuBottomBeforeNewPage = 128;

	public int currentPage;

	public string descriptionText;

	public string hoverText;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent forwardButton;

	public List<List<ClickableTextureComponent>> powers;

	private float widthMod;

	private float heightMod;

	private int selectedIndex;

	private ClickableTextureComponent highlightTexture;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PowersTab(int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void populateClickableComponentList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doSelect(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawInfoPanel(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
