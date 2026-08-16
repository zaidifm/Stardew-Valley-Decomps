using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class ItemGrabMenu : MenuWithInventory
{
	public delegate bool behaviorOnMobileItemChange(Item i, int position, Item old, ItemGrabMenu container, bool onRemoval = false);

	public delegate void behaviorOnItemSelect(Item item, Farmer who);

	public delegate void behaviorOnItemAddtoItemsToGrab(Item item, Farmer who);

	public delegate void behaviorOnTapClose(Item item, Farmer who);

	public const int region_organizationButtons = 15923;

	public const int region_itemsToGrabMenuModifier = 53910;

	public const int region_fillStacksButton = 12952;

	public const int region_organizeButton = 106;

	public const int region_colorPickToggle = 27346;

	public const int region_specialButton = 12485;

	public const int region_lastShippedHolder = 12598;

	public const int source_none = 0;

	public const int source_chest = 1;

	public const int source_gift = 2;

	public const int source_fishingChest = 3;

	public const int source_overflow = 4;

	public const int specialButton_junimotoggle = 1;

	public InventoryMenu ItemsToGrabMenu;

	private TemporaryAnimatedSprite poof;

	public bool reverseGrab;

	public bool showReceivingMenu;

	public bool drawBG;

	public bool destroyItemOnClick;

	public bool canExitOnKey;

	public bool playRightClickSound;

	public bool allowRightClick;

	public bool shippingBin;

	private string message;

	private behaviorOnItemSelect behaviorFunction;

	public behaviorOnItemSelect behaviorOnItemGrab;

	public behaviorOnItemAddtoItemsToGrab behaviorOnAddtoItemsToGrab;

	public behaviorOnTapClose behaviorOnClose;

	private bool rearrangeGrangeOnExit;

	private InventoryMenu.highlightThisItem highlightFunction;

	protected List<TransferredItemSprite> _transferredItemSprites;

	private Item hoverItem;

	private Item sourceItem;

	public ClickableTextureComponent fillStacksButton;

	public ClickableTextureComponent organizeButton;

	public ClickableTextureComponent colorPickerToggleButton;

	public ClickableTextureComponent specialButton;

	public ClickableTextureComponent lastShippedHolder;

	public List<ClickableComponent> discreteColorPickerCC;

	public int source;

	public int whichSpecialButton;

	public object context;

	private bool snappedtoBottom;

	public DiscreteColorPicker chestColorPicker;

	private bool essential;

	public bool superEssential;

	private bool holdingFillStacksButton;

	private Rectangle topInv;

	private Rectangle bottomInv;

	private float widthMod;

	private float heightMod;

	private new int width;

	private new int height;

	private int lastShippedTextWidth;

	private Rectangle crateBounds;

	private Vector2 lastShippedTextPos;

	private string lastShippedText;

	private ClickableTextureComponent clickableShippingCrate;

	private ClickableTextureComponent clickableCrateLid;

	private bool lastControlWasWithJoystick;

	private string shippingInstructionText;

	private behaviorOnMobileItemChange itemChangeBehavior;

	public bool allowStack;

	private bool hoverOverShippingBin;

	public bool justGrabbing;

	protected bool _sourceItemInCurrentLocation;

	public ClickableTextureComponent junimoNoteIcon;

	private int junimoNotePulser;

	private int _selectedItemIndex;

	private bool _movingItem;

	private bool _showTooltip;

	public bool enableGamePadControls;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemGrabMenu(IList<Item> inventory, object context = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DropRemainingItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemGrabMenu(IList<Item> inventory, bool reverseGrab, bool showReceivingMenu, InventoryMenu.highlightThisItem highlightFunction, behaviorOnItemSelect behaviorOnItemSelectFunction, string message, behaviorOnItemSelect behaviorOnItemGrab = null, bool snapToBottom = false, bool canBeExitedWithKey = false, bool playRightClickSound = true, bool allowRightClick = true, bool showOrganizeButton = false, int source = 0, Item sourceItem = null, int whichSpecialButton = -1, object specialObject = null, int storageCapacity = -1, int numRows = 3, behaviorOnMobileItemChange itemChangeBehavior = null, bool allowStack = true, behaviorOnItemAddtoItemsToGrab behaviorOnAddtoTop = null, bool rearrangeGrangeOnExit = false, behaviorOnTapClose behaviorOnTapClose = null, object context = null, bool allowExitWithHeldItem = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ItemGrabMenu CreateOverflowMenu(IList<Item> items, behaviorOnItemSelect onCollectItem = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetColumnCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemGrabMenu setEssential(bool essential, bool superEssential = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initializeShippingBin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setSourceItem(Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setBackgroundTransparency(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setDestroyItemOnClick(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Item GetItemAt(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetItemAt(int index, Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveGamePadButtonGrabbingItems(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveGamePadButtonShippingBin(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBehavior(Item movingItem, Item swapItem, int newMovingItemIndex, int newSwapItemIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HighlightSelectedItemInChest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapUpperRightCloseButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UndoLastShippedItem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FillOutStacks()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void organizeItemsInList(IList<Item> items)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool areAllItemsTaken()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	private bool performSpecialContextChecks(Item item, int tap_x, int tap_y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void cleanupBeforeExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void emergencyShutDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rearrangeGrange()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rearrange(int rows, int columns)
	{
	}
}
