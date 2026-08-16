using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.BellsAndWhistles;

namespace StardewValley.Menus;

public class MuseumMenu : MenuWithInventory
{
	public const int startingState = 0;

	public const int placingInMuseumState = 1;

	public const int exitingState = 2;

	public int fadeTimer;

	public int state;

	public int menuPositionOffset;

	public bool fadeIntoBlack;

	public bool menuMovingDown;

	public float blackFadeAlpha;

	public SparklingText sparkleText;

	public Vector2 globalLocationOfSparklingArtifact;

	private static InventoryMenu.highlightThisItem RearrangeMethod;

	private Rectangle _inventoryRect;

	private int _drawAtX;

	private int _drawAtY;

	private int _lastTapX;

	private int _lastTapY;

	private const int DRAG_THRESHOLD = 5;

	private bool _dragging;

	private bool previouslyPlaced;

	private bool movingExistingPiece;

	public bool rearrangeMode;

	private Vector2 _startTileLocation;

	private float _lastZoom;

	private bool holdingMuseumPiece;

	public bool reOrganizing;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MuseumMenu(InventoryMenu.highlightThisItem highlighterMethod)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldClampGamePadCursor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool overrideSnappyMenuCursorMovementBan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
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
	public virtual void ReturnToDonatableItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool SwapItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void cleanupBeforeExit()
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
	private void snapCursorToCurrentMuseumSpot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestToPan(int x, int y, ButtonState leftButton)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawPlacementGrid(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool placeItem(int x, int y, Item oldItem)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
