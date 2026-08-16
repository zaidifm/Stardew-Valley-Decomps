using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class ItemListMenu : IClickableMenu
{
	public const int region_okbutton = 101;

	public const int region_forwardButton = 102;

	public const int region_backButton = 103;

	public int itemsPerCategoryPage;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent forwardButton;

	public ClickableTextureComponent backButton;

	private List<Item> itemsToList;

	private string title;

	private int currentTab;

	private int totalValueOfItems;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemListMenu(string menuTitle, List<Item> itemList)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
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
	protected override void cleanupBeforeExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool showBackButton()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool showForwardButton()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
