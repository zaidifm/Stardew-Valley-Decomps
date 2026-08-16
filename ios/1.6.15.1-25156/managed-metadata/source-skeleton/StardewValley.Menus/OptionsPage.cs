using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class OptionsPage : IClickableMenu
{
	public const int itemsPerPage = 7;

	public const int indexOfGraphicsPage = 6;

	private string descriptionText;

	private string hoverText;

	public int currentItemIndex;

	private ClickableTextureComponent upArrow;

	private ClickableTextureComponent downArrow;

	private ClickableTextureComponent scrollBar;

	private List<OptionsElement> options;

	private bool scrolling;

	public static int currentScrollY;

	private const int X_PADDING = 40;

	private const int Y_SPACING = 20;

	private int oldxEdge;

	private MobileScrollbar newScrollbar;

	private MobileScrollbox scrollArea;

	public static bool drawScrollBar;

	private OptionsDropDown _selectedDropdown;

	private OptionsElement _optionsSliderMenuMargin;

	private OptionsElement _optionsSliderToolbarPadding;

	private OptionsElement _optionsSliderToolbarSlotSize;

	private OptionsElement _optionsSliderDateTimeScale;

	private OptionsElement _optionsSliderInvisibleButtonWidth;

	private OptionsElement _optionElementClickedOn;

	public OptionsButton optionsButtonAdjustControls;

	private int ContentHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsPage(int x, int y, int width, int height, float widthMod = 1f, float heightMod = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool overrideSnappyMenuCursorMovementBan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void waitForServerConnection(Action onConnection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void offerInvite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void showInviteCode()
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
	private void setScrollBarToCurrentIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapCursorToCurrentSnappedComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ClickableComponent getCurrentlySnappedComponent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setCurrentlySnappedComponentTo(int id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void downArrowPressed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void upArrowPressed()
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
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveStartupPreferences()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickExitToTitle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickEmergencyBackupLoad()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickEmergencyBackupSave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickSwapSave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickCrash()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickSaveBackup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickAdjustJoypadControls()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateContentPositions()
	{
	}
}
