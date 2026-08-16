using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Buildings;
using xTile.Dimensions;

namespace StardewValley.Menus;

public class PurchaseAnimalsMenu : IClickableMenu
{
	public const int region_okButton = 101;

	public const int region_doneNamingButton = 102;

	public const int region_randomButton = 103;

	public const int region_namingBox = 104;

	public static int menuHeight;

	public static int menuWidth;

	public List<ClickableTextureComponent> animalsToPurchase;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent doneNamingButton;

	public ClickableTextureComponent randomButton;

	public ClickableTextureComponent hovered;

	public ClickableComponent textBoxCC;

	private bool onFarm;

	private bool namingAnimal;

	private bool freeze;

	private FarmAnimal animalBeingPurchased;

	private TextBox textBox;

	private TextBoxEvent e;

	private Building newAnimalHome;

	private int priceOfAnimal;

	public bool readOnly;

	public GameLocation TargetLocation;

	public ClickableTextureComponent tickButton;

	public ClickableTextureComponent cancelButton;

	private Building _selectedBuilding;

	private int headerX;

	private int headerY;

	private int headerWidth;

	private int goldX;

	private int goldY;

	private int scrollerX;

	private int scrollerY;

	private int scrollerWidth;

	private int scrollerHeight;

	private int descX;

	private int descY;

	private int descWidth;

	private int descHeight;

	private int buyX;

	private int buyY;

	private int buyWidth;

	private int buyHeight;

	private int itemHeight;

	private int itemWidth;

	private int scrollbarWidth;

	private int itemsPerPage;

	private int currentlySelectedItem;

	private bool buyButtonisHeld;

	private bool buyButtonVisible;

	private bool scrollbarVisible;

	private bool scrolling;

	private bool tickButtonHeld;

	private bool cancelButtonHeld;

	private bool doneNamingButtonHeld;

	private bool randomButtonHeld;

	private int currency;

	private ClickableComponent buyButton;

	private string headerString;

	private string nameString;

	private string descString;

	private MobileScrollbar newScrollbar;

	private MobileScrollbox scrollArea;

	private List<ClickableComponent> itemBox;

	private Microsoft.Xna.Framework.Rectangle clip;

	private int _drawAtX;

	private int _drawAtY;

	private int _lastTapX;

	private int _lastTapY;

	private int _selectedItemIndex;

	private ClickableTextureComponent _selectedButton;

	private int selectedBuildingIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PurchaseAnimalsMenu(List<Object> stock, GameLocation targetLocation = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldClampGamePadCursor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void textBoxEnter(TextBox sender)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpForReturnAfterPurchasingAnimal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void marnieAnimalPurchaseMessage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpForAnimalPlacement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpForReturnToShopMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
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
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
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
	public static string getAnimalTitle(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getAnimalDescription(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SelectBuilding(Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTickButtonBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCancelButtonBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void selectItem(int i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickBuyAnimal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Location GetTopLeftPixelToCenterBuilding(Building building)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Building GetSuggestedBuilding(FarmAnimal animal)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlaceAnimalInSelectedBuilding()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void resetButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateItemButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestToPan(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCurrentViewportTargetToCenterOnBuilding(Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnhighlightBuildings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HighlightSelectedBuilding()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickRandomNameButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickDoneNaming()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickCancelButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}
}
