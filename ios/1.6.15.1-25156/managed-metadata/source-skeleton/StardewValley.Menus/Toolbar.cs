using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using xTile.Dimensions;

namespace StardewValley.Menus;

public class Toolbar : IClickableMenu
{
	private const int TICKS_BEFORE_TAP_HOLD_KICKS_IN = 4000000;

	private long hoverTicksAtStart;

	private int xOffset;

	private int yOffset;

	private Vector2 _tooltipPosition;

	private bool vertical;

	public static int toolbarWidth;

	private int toolbarHeight;

	private int _itemSlotSize;

	public static int toolBarItemWidth;

	public static bool toolbarPressed;

	private int _nextToolIndex;

	private int _toolbarPaddingX;

	private int _startTapPositionX;

	private int _startTapPositionY;

	private int _startIndex;

	private int _drawStartIndex;

	private bool _showTooltip;

	public bool alignTop;

	public Microsoft.Xna.Framework.Rectangle toolbarTextSource;

	private List<ClickableComponent> buttons;

	private string hoverTitle;

	private Item hoverItem;

	private Item lastHoverItem;

	private float transparency;

	private static Toolbar _instance;

	private bool _ignoreRelease;

	private int _shoulderButtonDownCount;

	private const int UPDATES_TO_SHOW_TOOLTIP = 20;

	public int itemSlotSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public static bool visible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Toolbar Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private new xTile.Dimensions.Rectangle viewport
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int screenWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int screenHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private int maxScrollIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private int HorizontalBottomStartY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int startIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public int maxVisibleItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Toolbar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void testToAddMoreItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddItems(int totalItems)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getIconPosition(string itemName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getIconPosition(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Toolbar GetToolbar()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool scrollToItem(string qualifiedItemID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void testToScrollToolbar(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateDrawStartIndex(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateScrollIndex(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
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
	public void shifted(bool right)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScrollToolbarOne(bool forward)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Microsoft.Xna.Framework.Rectangle oldBounds, Microsoft.Xna.Framework.Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isWithinBounds(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetToolbar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateButtonBounds()
	{
	}
}
