using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class StorageContainer : MenuWithInventory
{
	public delegate bool behaviorOnItemChange(Item i, int position, Item old, StorageContainer container, bool onRemoval = false);

	public InventoryMenu ItemsToGrabMenu;

	private TemporaryAnimatedSprite poof;

	private behaviorOnItemChange itemChangeBehavior;

	private Rectangle topInv;

	private Rectangle bottomInv;

	private float widthMod;

	private float heightMod;

	private new int width;

	private new int height;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StorageContainer(IList<Item> inventory, int capacity, int rows = 3, behaviorOnItemChange itemChangeBehavior = null, InventoryMenu.highlightThisItem highlightMethod = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
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
	public override void draw(SpriteBatch b)
	{
	}
}
