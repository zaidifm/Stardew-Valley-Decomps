using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.GameData.Objects;
using xTile.Dimensions;

namespace StardewValley.Menus;

[InstanceStatics]
public abstract class IClickableMenu
{
	public delegate void onExit();

	protected IClickableMenu _childMenu;

	protected IClickableMenu _parentMenu;

	public const int upperRightCloseButton_ID = 9175502;

	public const int currency_g = 0;

	public const int currency_starTokens = 1;

	public const int currency_qiCoins = 2;

	public const int currency_qiGems = 4;

	public const int greyedOutSpotIndex = 57;

	public const int presentIconIndex = 58;

	public const int itemSpotIndex = 10;

	protected string closeSound;

	public static int borderWidth;

	public static int tabYPositionRelativeToMenuY;

	public static int spaceToClearTopBorder;

	public static int spaceToClearSideBorder;

	public const int spaceBetweenTabs = 4;

	public int xPositionOnScreen;

	public int yPositionOnScreen;

	public int width;

	public int height;

	public Action<IClickableMenu> behaviorBeforeCleanup;

	public onExit exitFunction;

	public ClickableTextureComponent upperRightCloseButton;

	public bool destroy;

	protected int _dependencies;

	public List<ClickableComponent> allClickableComponents;

	public ClickableComponent currentlySnappedComponent;

	[NonInstancedStatic]
	public static Microsoft.Xna.Framework.Rectangle lastTextureBoxRect;

	public static StringBuilder HoverTextStringBuilder;

	public Vector2 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static xTile.Dimensions.Rectangle viewport
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IClickableMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IClickableMenu(int x, int y, int width, int height, bool showUpperRightCloseButton = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Type getMenuType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initialize(int x, int y, int width, int height, bool showUpperRightCloseButton = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IClickableMenu GetChildMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IClickableMenu GetParentMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChildMenu(IClickableMenu menu)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDependency()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveDependency()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasDependencies()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool areGamePadControlsImplemented()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableComponent getLastClickableComponentInThisListThatContainsThisXCoord(List<ClickableComponent> ccList, int xCoord)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableComponent getFirstClickableComponentInThisListThatContainsThisXCoord(List<ClickableComponent> ccList, int xCoord)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableComponent getLastClickableComponentInThisListThatContainsThisYCoord(List<ClickableComponent> ccList, int yCoord)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableComponent getFirstClickableComponentInThisListThatContainsThisYCoord(List<ClickableComponent> ccList, int yCoord)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawMouse(SpriteBatch b, bool ignore_transparency = false, int cursor = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void populateClickableComponentList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void applyMovementKey(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void applyMovementKey(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setCurrentlySnappedComponentTo(int id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void moveCursorInDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void snapCursorToCurrentSnappedComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void noSnappedComponentFound(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void customSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsActive()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void automaticSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool _ShouldAutoSnapPrioritizeAlignedElements()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void actionOnRegionChange(int oldRegion, int newRegion)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableComponent getComponentWithID(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initializeUpperRightCloseButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawBackground(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool showWithoutTransparencyIfOptionIsSet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void clickAway()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void gameWindowSizeChanged(Microsoft.Xna.Framework.Rectangle oldBounds, Microsoft.Xna.Framework.Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setUpForGamePadMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool shouldClampGamePadCursor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnTapCloseButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool overrideSnappyMenuCursorMovementBan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void gamePadButtonHeld(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ClickableComponent getCurrentlySnappedComponent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, int red, int green, int blue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isWithinBounds(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void cleanupBeforeExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool shouldDrawCloseButton()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void exitThisMenuNoSound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void exitThisMenu(bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void emergencyShutDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawMobileHorizontalPartition(SpriteBatch b, int xPosition, int yPosition, int partitionWidth, bool small = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawMobileVerticalPartition(SpriteBatch b, int xPosition, int yPosition, int partitionHeight, bool small = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawMobileVerticalIntersectingPartition(SpriteBatch b, int xPosition, int yPosition, int yOffset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawHorizontalPartition(SpriteBatch b, int yPosition, bool small = false, int red = -1, int green = -1, int blue = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawVerticalPartition(SpriteBatch b, int xPosition, bool small = false, int red = -1, int green = -1, int blue = -1, int heightOverride = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawVerticalIntersectingPartition(SpriteBatch b, int xPosition, int yPosition, int red = -1, int green = -1, int blue = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawVerticalUpperIntersectingPartition(SpriteBatch b, int xPosition, int partitionHeight, int red = -1, int green = -1, int blue = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawTextureBox(SpriteBatch b, int x, int y, int width, int height, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawTextureBoxWithIcon(SpriteBatch b, Texture2D texture, Microsoft.Xna.Framework.Rectangle sourceRect, Texture2D iconTexture, Microsoft.Xna.Framework.Rectangle iconSourceRect, int x, int y, int width, int height, Color color, float scale = 1f, bool drawShadow = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawButtonWithText(SpriteBatch b, SpriteFont font, string text, int x, int y, int width, int height, Color color, bool isClickable = true, bool heldDown = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawTextureBox(SpriteBatch b, Texture2D texture, Microsoft.Xna.Framework.Rectangle sourceRect, int x, int y, int width, int height, Color color, float scale = 1f, bool drawShadow = true, float draw_layer = -1f, bool ignoreBorder = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawTextureBoxWithIconAndText(SpriteBatch b, SpriteFont font, Texture2D texture, Microsoft.Xna.Framework.Rectangle sourceRect, Texture2D iconTexture, Microsoft.Xna.Framework.Rectangle iconSourceRect, string text, int x, int y, int width, int height, Color color, float scale = 1f, bool drawShadow = true, bool iconLeft = true, bool isClickable = true, bool heldDown = false, bool drawIcon = true, bool reverseColors = false, bool bold = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawRedBox(SpriteBatch b, int x, int y, int width, int height, int thickness = 4, float layerDepth = 0.08f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawBorderLabel(SpriteBatch b, string text, SpriteFont font, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawToolTipOverridePosition(SpriteBatch b, string hoverText, string hoverTitle, Item hoveredItem, int overrideX = -1, int overrideY = -1, int forcedYOffset = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] GetBuffIcons(Item hoveredItem, ObjectData rawData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawToolTip(SpriteBatch b, string hoverText, string hoverTitle, Item hoveredItem, bool heldItem = false, int healAmountToDisplay = -1, int currencySymbol = 0, string extraItemToShowIndex = null, int extraItemToShowAmount = -1, CraftingRecipe craftingIngredients = null, int moneyAmountToShowAtBottom = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawHoverText(SpriteBatch b, string text, SpriteFont font, int xOffset = 0, int yOffset = 0, int moneyAmountToDisplayAtBottom = -1, string boldTitleText = null, int healAmountToDisplay = -1, string[] buffIconsToDisplay = null, Item hoveredItem = null, int currencySymbol = 0, string extraItemToShowIndex = null, int extraItemToShowAmount = -1, int overrideX = -1, int overrideY = -1, float alpha = 1f, CraftingRecipe craftingIngredients = null, IList<Item> additional_craft_materials = null, Texture2D boxTexture = null, Microsoft.Xna.Framework.Rectangle? boxSourceRect = null, Color? textColor = null, Color? textShadowColor = null, float boxScale = 1f, int boxWidthOverride = -1, int boxHeightOverride = -1, int stackNumber = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawHoverText(SpriteBatch b, StringBuilder text, SpriteFont font, int xOffset = 0, int yOffset = 0, int moneyAmountToDisplayAtBottom = -1, string boldTitleText = null, int healAmountToDisplay = -1, string[] buffIconsToDisplay = null, Item hoveredItem = null, int currencySymbol = 0, string extraItemToShowIndex = null, int extraItemToShowAmount = -1, int overrideX = -1, int overrideY = -1, float alpha = 1f, CraftingRecipe craftingIngredients = null, IList<Item> additional_craft_materials = null, Texture2D boxTexture = null, Microsoft.Xna.Framework.Rectangle? boxSourceRect = null, Color? textColor = null, Color? textShadowColor = null, float boxScale = 1f, int boxWidthOverride = -1, int boxHeightOverride = -1, int stackNumber = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawMobileFloatingToolTip(SpriteBatch b, int x, int y, int inventoryPosition, int squareSide, string hoverText, string hoverTitle, Item hoveredItem, bool heldItem = false, int healAmountToDisplay = -1, int currencySymbol = 0, int extraItemToShowIndex = -1, int extraItemToShowAmount = -1, CraftingRecipe craftingIngredients = null, int moneyAmountToShowAtBottom = -1, int stackNumber = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawMobileToolTip(SpriteBatch b, int x, int y, int width, int height, int paragraphGap, string hoverText, string hoverTitle, Item hoveredItem, bool heldItem = false, int healAmountToDisplay = -1, int currencySymbol = 0, string extraItemToShowIndexStr = null, int extraItemToShowAmount = -1, CraftingRecipe craftingIngredients = null, int moneyAmountToShowAtBottom = -1, int currency = 0, bool inStockAndBuyable = true, bool drawSmall = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int drawMobileTextPanel(SpriteBatch b, string text, SpriteFont font, int x, int y, int width, int height, int paragraphGap = 34, int moneyAmountToDisplayAtBottom = -1, string boldTitleText = null, int healAmountToDisplay = -1, string[] buffIconsToDisplay = null, Item hoveredItem = null, int currencySymbol = 0, string extraItemToShow = null, int extraItemToShowAmount = -1, int overrideX = -1, int overrideY = -1, float alpha = 1f, CraftingRecipe craftingIngredients = null, int currency = 0, bool inStockAndBuyable = true, bool drawBackgroundBox = false, bool avoidOffscreenCull = false, bool drawSmall = false, IList<Item> additional_craft_materials = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
