using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.GameData.Shops;

namespace StardewValley.Menus;

public class ShopMenu : IClickableMenu
{
	public delegate bool OnPurchaseDelegate(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock);

	public new int width;

	public new int height;

	public int edge;

	public int separator;

	public float widthMod;

	public float heightMod;

	public int invX;

	public int invY;

	public int invHeight;

	public int invWidth;

	public int goldX;

	public int goldY;

	public int notesX;

	public int notesY;

	public int notesWidth;

	public int notesHeight;

	public int portraitX;

	public int portraitY;

	public int portraitWidth;

	public int portraitHeight;

	public int itemsX;

	public int itemsY;

	public int itemsWidth;

	public int itemsHeight;

	public int itemsXoff;

	public int itemsYoff;

	public int priceX;

	public int priceY;

	public int priceWidth;

	public int priceHeight;

	public int scrollbarWidth;

	public int scrollbarHeight;

	public int currentlySelectedItem;

	public int priceItem;

	public int buyX;

	public int buyY;

	public int buyYWithSlider;

	public int buyWidth;

	public int buyHeight;

	public int maxBuyable;

	public int quantityToBuy;

	public int numUsedSlots;

	public int numOfCurrentItem;

	public int sellPanelWidth;

	public int sellPanelHeight;

	public int salePrice;

	public int savedInventoryX;

	public int savedInventoryY;

	public int itemButtonHeight;

	public int quantityToSell;

	public string descItem;

	public string nameItem;

	public ISalable currentItem;

	private Item itemPlayerIsSelling;

	public Vector2 sellPanelPosition;

	public Vector2 sellPanelTextSize;

	public Texture2D portraitTexture;

	public ClickableComponent inventoryButton;

	public ClickableComponent buyButton;

	public ClickableComponent sellButton;

	public int baseItemButtonHeight;

	public bool inventoryButtonisHeld;

	public bool buyButtonisHeld;

	public bool sellButtonisHeld;

	public bool quantitySliderHeld;

	public bool sellQuantitySliderHeld;

	public bool inventoryVisible;

	public bool scrollBarVisible;

	public SliderBar quantitySlider;

	public SliderBar sellQuantitySlider;

	public Rectangle fadeRect;

	private string personName;

	private MobileScrollbox scrollArea;

	private tweeningSprite boughtItemTween;

	private MobileScrollbar newScrollbar;

	private bool clickReceived;

	public const int region_shopButtonModifier = 3546;

	public const int region_upArrow = 97865;

	public const int region_downArrow = 97866;

	public const int region_tabStartIndex = 99999;

	public const int infiniteStock = int.MaxValue;

	public int itemsPerPage;

	public const int numberRequiredForExtraItemTrade = 5;

	public string hoverText;

	public string boldTitleText;

	public string openMenuSound;

	public string purchaseSound;

	public string purchaseRepeatSound;

	public string ShopId;

	public ShopData ShopData;

	public InventoryMenu inventory;

	public ISalable heldItem;

	public ISalable hoveredItem;

	public StackDrawType? DefaultStackDrawType;

	private TemporaryAnimatedSprite poof;

	private Rectangle scrollBarRunner;

	public List<ISalable> forSale;

	public List<ClickableComponent> forSaleButtons;

	public List<int> categoriesToSellHere;

	public List<List<string>> tagsToSellHere;

	public Dictionary<ISalable, ItemStockInformation> itemPriceAndStock;

	private float sellPercentage;

	private TemporaryAnimatedSpriteList animations;

	public int hoverPrice;

	public int currentItemIndex;

	public int currency;

	public ClickableTextureComponent upArrow;

	public ClickableTextureComponent downArrow;

	public ClickableTextureComponent scrollBar;

	public NPC portraitPerson;

	public string potraitPersonDialogue;

	public object source;

	private bool scrolling;

	public OnPurchaseDelegate onPurchase;

	public Func<ISalable, bool> onSell;

	public Func<int, bool> canPurchaseCheck;

	public List<ClickableTextureComponent> tabButtons;

	protected int currentTab;

	protected bool _isStorageShop;

	protected bool _isCatalogue;

	public bool readOnly;

	public HashSet<ISalable> buyBackItems;

	public Dictionary<ISalable, ISalable> buyBackItemsToResellTomorrow;

	public int safetyTimer;

	private bool inventoryWasVisible;

	private float AButtonPolling;

	private float triggerPolling;

	private float triggerPollingAccel;

	private float aButtonPollingAccel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopMenu(string shopId, ShopData shopData, ShopOwnerData ownerData, NPC owner = null, OnPurchaseDelegate onPurchase = null, Func<ISalable, bool> onSell = null, bool playOpenSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopMenu(string shopId, Dictionary<ISalable, ItemStockInformation> itemPriceAndStock, int currency = 0, string who = null, OnPurchaseDelegate on_purchase = null, Func<ISalable, bool> on_sell = null, bool playOpenSound = true, string context = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopMenu(string shopId, List<ISalable> itemsForSale, int currency = 0, string who = null, OnPurchaseDelegate on_purchase = null, Func<ISalable, bool> on_sell = null, string context = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Initialize(int currency, OnPurchaseDelegate onPurchase, Func<ISalable, bool> onSell, bool playOpenSound)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddForSale(ISalable item, ItemStockInformation stock = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpShopOwner(string who, string shopId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUpShopOwner(ShopOwnerData ownerData, NPC owner = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ParseDialogueSubstitution(string[] query, out string replacement, Random random, Farmer player)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Texture2D TryLoadPortrait(ShopOwnerData ownerData, NPC owner)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initialiseMobileLayout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateItemButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkForItemsToSell()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public bool highlightItemToSell(Item i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getPlayerCurrencyAmount(Farmer who, int currencyType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doGamePadButtonInventory(Buttons b)
	{
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
	private void InventoryReceiveLeftClick(int x, int y)
	{
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
	private void OnTapBuy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setScrollBarToCurrentIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
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
	private void setCurrentItem(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkForTutorial()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int updateNumberOfUsedInventorySlots()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getPlayerNumberOfItem(ISalable item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isTrashCan(ISalable item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBuyback()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BuyBuybackItem(ISalable bought_item, int price, int stack)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ISalable AddBuybackItem(ISalable sold_item, int sell_unit_price, int stack)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void emergencyShutDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayOpenSound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOutOfStock()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void chargePlayer(Farmer who, int currencyType, int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HandleSynchedItemPurchase(ISalable item, Farmer who, int number_purchased)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool tryToPurchaseItem(ISalable item, ISalable held_item, int stockToBuy, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasTradeItem(string itemId, int count)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConsumeTradeItem(string itemId, int count)
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
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getHoveredItemExtraItemIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getHoveredItemExtraItemAmount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setItemPriceAndStock(Dictionary<ISalable, ItemStockInformation> new_stock)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawSellPanel(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackDrawType GetStackDrawType(ItemStockInformation stockInfo, ISalable item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawCurrency(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setUpStoreForContext()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void repositionTabs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void cleanupBeforeExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rebuildSaleButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void switchTab(int new_tab)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void applyTab()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetShopContext()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
