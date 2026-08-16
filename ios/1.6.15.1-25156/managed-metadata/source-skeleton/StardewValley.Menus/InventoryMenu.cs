using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class InventoryMenu : IClickableMenu
{
	public delegate bool highlightThisItem(Item i);

	public enum BorderSide
	{
		Top,
		Left,
		Right,
		Bottom
	}

	public const int region_inventorySlot0 = 0;

	public const int region_inventorySlot1 = 1;

	public const int region_inventorySlot2 = 2;

	public const int region_inventorySlot3 = 3;

	public const int region_inventorySlot4 = 4;

	public const int region_inventorySlot5 = 5;

	public const int region_inventorySlot6 = 6;

	public const int region_inventorySlot7 = 7;

	public const int region_inventorySlot8 = 8;

	public const int region_inventorySlot9 = 9;

	public const int region_inventorySlot10 = 10;

	public const int region_inventorySlot11 = 11;

	public const int region_inventorySlot12 = 12;

	public const int region_inventorySlot13 = 13;

	public const int region_inventorySlot14 = 14;

	public const int region_inventorySlot15 = 15;

	public const int region_inventorySlot16 = 16;

	public const int region_inventorySlot17 = 17;

	public const int region_inventorySlot18 = 18;

	public const int region_inventorySlot19 = 19;

	public const int region_inventorySlot20 = 20;

	public const int region_inventorySlot21 = 21;

	public const int region_inventorySlot22 = 22;

	public const int region_inventorySlot23 = 23;

	public const int region_inventorySlot24 = 24;

	public const int region_inventorySlot25 = 25;

	public const int region_inventorySlot26 = 26;

	public const int region_inventorySlot27 = 27;

	public const int region_inventorySlot28 = 28;

	public const int region_inventorySlot29 = 29;

	public const int region_inventorySlot30 = 30;

	public const int region_inventorySlot31 = 31;

	public const int region_inventorySlot32 = 32;

	public const int region_inventorySlot33 = 33;

	public const int region_inventorySlot34 = 34;

	public const int region_inventorySlot35 = 35;

	public const int region_dropButton = 107;

	public const int region_inventoryArea = 9000;

	public string hoverText;

	public string hoverTitle;

	public string descriptionTitle;

	public string descriptionText;

	public List<ClickableComponent> inventory;

	protected Dictionary<int, double> _iconShakeTimer;

	public IList<Item> actualInventory;

	public highlightThisItem highlightMethod;

	public ItemGrabMenu.behaviorOnItemSelect onAddItem;

	public bool playerInventory;

	public bool drawSlots;

	public bool showGrayedOutSlots;

	public int capacity;

	public int rows;

	public int horizontalGap;

	public int verticalGap;

	public ClickableComponent dropItemInvisibleButton;

	public string moveItemSound;

	private int hoverAmount;

	public bool canMoveItems;

	public IList<Item> otherInventoryForTrash;

	public int otherInventoryTrashItemIndex;

	public int otherInventoryTrashItemStack;

	public int xOffset;

	public int yOffset;

	public int squareSide;

	private int infoWidth;

	public int invOffset;

	public int hGap;

	public int additionalYOffset;

	private Rectangle fadeRect;

	public float scaleFactor;

	private float widthMod;

	private float heightMod;

	private float iconGapMultiplier;

	private float heldTimer;

	private float stackTimer;

	private float tapHoldTime;

	private float startStackTime;

	private bool showTrash;

	private bool holdingOrganizeButton;

	private bool holdingTrashCan;

	private bool externalHoldingTrashCan;

	public bool showItemInfo;

	public bool showOrganizeButton;

	public bool drawHeldItem;

	public ClickableTextureComponent trashCan;

	public ClickableTextureComponent organizeButton;

	public int currentlySelectedItem;

	public int currentlyStackingItem;

	public int inventoryItemHeld;

	private int infoPanelTextSize;

	private int infoPanelWidth;

	private int infoPanelHeight;

	private Vector2 infoPanelPosition;

	private Item actualItemSelected;

	private int itemsXoff;

	private int itemsYoff;

	public int furthestX;

	public int furthestY;

	private float trashCanLidRotation;

	private float dragScale;

	public int trashX;

	public int trashY;

	public int orgX;

	public int orgY;

	public int dragX;

	public int dragY;

	public int startDragX;

	public int startDragY;

	public int dragItem;

	public int currentlyHighlightedEmptySlot;

	public int deltaForDrag;

	public bool isOnMultiInventoryPage;

	public int currentlyHeldStack;

	public bool allowDragging;

	private int _lineNumber;

	private float stackIncrementTime;

	private float oldStackTimer;

	private bool _showTooltip;

	private bool _movingItem;

	private Rectangle _infoPanelRect;

	public Item selectedItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int totalItemSlots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InventoryMenu(int xPosition, int yPosition, bool playerInventory, IList<Item> actualInventory = null, highlightThisItem highlightMethod = null, int capacity = -1, int rows = 3, int horizontalGap = 0, int verticalGap = 0, bool drawSlots = true, int width = 0, int height = 0, bool showTrash = true, bool showOrganizeButton = true, int addYOffset = 0, bool drawHeldItem = false, int xOff = -1, int yOff = -1, int forceSquareSide = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ClickableComponent> GetBorder(BorderSide side)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool highlightAllItems(Item i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool highlightNoItems(Item i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void movePosition(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShakeItem(Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShakeItem(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item tryToAddItem(Item toPlace, string sound = "coin", bool allowStack = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getInventoryPositionOfClick(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item leftClick(int x, int y, Item toPlace, bool playSound = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 snapToClickableComponent(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item getItemAt(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item getItemFromClickableComponent(ClickableComponent c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item rightClick(int x, int y, Item toAddTo, bool playSound = true, bool onlyCheckToolAttachments = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item hover(int x, int y, Item heldItem)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setUpForGamePadMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, int red = -1, int green = -1, int blue = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Vector2> GetSlotDrawPositions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getInvWidth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getInvX()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getInvHeight()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getInvY()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawInfoPanel(SpriteBatch b, bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawDragItem(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item addItemTo(int existingItemSlotNumber, Item itemToAdd)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool addItemAt(Item item, int x, int y, bool allowStack = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item tryToAddItemAt(Item item, int x, int y, bool allowStack = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item tryToAddItemToSlotNumber(Item item, int slotNumber, bool allowStack = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doOpenTrashCan(IList<Item> inventoryItemIsFrom, int itemIndex, int theStack = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getPositionOfSellPanel(int x, int y, int width = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle getIconBoundsAt(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void intializeDragItem(int dragItem, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool inventoryContainsPoint(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void highlightIfHoverOverSlot(int x, int y, bool itemFromOtherInventory = false, Item itemBeingDragged = null, bool autoStack = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item selectItemAt(int x, int y, Item oldItem = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetItemAt(int i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItemAt(int i, Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GamePadShowInfoPanel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GamePadHideInfoPanel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAccurateInfoPanelPosition(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getColorPositionOfItem(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSelection()
	{
	}
}
