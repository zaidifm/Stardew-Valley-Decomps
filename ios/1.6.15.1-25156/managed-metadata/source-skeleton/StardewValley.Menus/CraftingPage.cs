using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Inventories;

namespace StardewValley.Menus;

public class CraftingPage : IClickableMenu
{
	public const int smallScreenY = 600;

	public int numInRow;

	public int numInCol;

	public const int region_upArrow = 88;

	public const int region_downArrow = 89;

	public const int region_craftingSelectionArea = 8000;

	public const int region_craftingModifier = 200;

	private string descriptionText;

	private string hoverText;

	private Item hoverItem;

	private Item lastCookingHover;

	public List<Dictionary<ClickableTextureComponent, CraftingRecipe>> pagesOfCraftingRecipes;

	private int currentCraftingPage;

	private CraftingRecipe hoverRecipe;

	public ClickableTextureComponent upButton;

	public ClickableTextureComponent downButton;

	public ClickableTextureComponent selectedCraftingItem;

	public ClickableTextureComponent scrollBar;

	private bool cooking;

	private Rectangle scrollBarRunner;

	private float widthMod;

	private float heightMod;

	private Rectangle mainBox;

	private Rectangle sliderRunner;

	private Rectangle slider;

	private string headerText;

	private int upX;

	private int upY;

	private int downY;

	private Rectangle infoPanel;

	private Rectangle craftButton;

	private bool showCraftButton;

	private bool craftButtonHeld;

	private bool sliderVisible;

	private bool scrolling;

	private bool upButtonHeld;

	private bool downButtonHeld;

	private bool showQuantitySlider;

	private bool quantitySliderHeld;

	private ClickableTextureComponent[,] recipeImage;

	private ClickableComponent[,] recipeSquare;

	private CraftingRecipe[,] recipeActual;

	private int xSpace;

	private int ySpace;

	private int rows;

	private int firstRowShown;

	private int craftYWithSlider;

	private int craftYWithoutSlider;

	private int quantityWeCanMake;

	private int quantityToCraft;

	private MobileScrollbar newScrollbar;

	private MobileScrollbox scrollArea;

	private SliderBar quantitySlider;

	private TemporaryAnimatedSprite poof;

	private string inventoryFullText;

	private Vector2 inventoryFullTextSize;

	private string hoverTitle;

	public tweeningSprite craftedItemTween;

	protected List<IInventory> _materialContainers;

	private int _selectedItemIndex;

	private float triggerPolling;

	private float triggerPollingAccel;

	private int selectedItemIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CraftingPage(int x, int y, int width, int height, bool cooking = false, bool standalone_menu = false, List<IInventory> material_containers = null, int tabX = 300)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual IList<Item> getContainerContents()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int craftingPageY()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setupRecipes(List<string> playerRecipes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void drawRecipes(SpriteBatch b)
	{
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
	public override void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CraftSelectedRecipe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SelectRecipe(int col, int row)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void clickCraftingRecipe(ClickableTextureComponent itemToTween, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
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
