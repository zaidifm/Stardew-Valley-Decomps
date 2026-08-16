using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class InventoryPage : IClickableMenu
{
	public const int region_inventory = 100;

	public const int region_hat = 101;

	public const int region_ring1 = 102;

	public const int region_ring2 = 103;

	public const int region_boots = 104;

	public const int region_trashCan = 105;

	public const int region_organizeButton = 106;

	public const int region_accessory = 107;

	public const int region_shirt = 108;

	public const int region_pants = 109;

	public const int region_shoes = 110;

	public const int region_trinkets = 120;

	public InventoryMenu inventory;

	private string descriptionText;

	private string hoverText;

	private string descriptionTitle;

	private string hoverTitle;

	private Item heldItem;

	private Item hoveredItem;

	public List<ClickableComponent> equipmentIcons;

	public ClickableComponent portrait;

	public ClickableTextureComponent trashCan;

	public ClickableTextureComponent organizeButton;

	private float trashCanLidRotation;

	public ClickableTextureComponent junimoNoteIcon;

	private int junimoNotePulser;

	private string headerText;

	private int offset;

	private int portraitX;

	private int portraitY;

	private int portraitHeight;

	private int portraitWidth;

	private int equipmentIconSize;

	private int bottomBoxY;

	private int bottomBoxHeight;

	private float widthMod;

	private float heightMod;

	private float scaleFactor;

	private int highlightEquipmentIcon;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InventoryPage(int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setUpForGamePadMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
