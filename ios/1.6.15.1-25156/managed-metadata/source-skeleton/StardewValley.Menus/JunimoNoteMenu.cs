using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.BellsAndWhistles;

namespace StardewValley.Menus;

public class JunimoNoteMenu : IClickableMenu
{
	public const int region_ingredientSlotModifier = 250;

	public const int region_ingredientListModifier = 1000;

	public const int region_bundleModifier = 5000;

	public const int region_areaNextButton = 101;

	public const int region_areaBackButton = 102;

	public const int region_backButton = 103;

	public const int region_purchaseButton = 104;

	public const int region_presentButton = 105;

	public const string noteTextureName = "LooseSprites\\JunimoNote";

	public Texture2D noteTexture;

	private bool specificBundlePage;

	private bool singleBundleMenu;

	public const int baseWidth = 320;

	public const int baseHeight = 180;

	public InventoryMenu inventory;

	public Item partialDonationItem;

	public List<Item> partialDonationComponents;

	public BundleIngredientDescription? currentPartialIngredientDescription;

	public int currentPartialIngredientDescriptionIndex;

	private Item heldItem;

	private Item hoveredItem;

	public static bool canClick;

	private int whichArea;

	public bool bundlesChanged;

	public static ScreenSwipe screenSwipe;

	public static string hoverText;

	public List<Bundle> bundles;

	public static TemporaryAnimatedSpriteList tempSprites;

	public List<ClickableTextureComponent> ingredientSlots;

	public List<ClickableTextureComponent> ingredientList;

	public List<ClickableTextureComponent> otherClickableComponents;

	public bool fromGameMenu;

	public bool fromThisMenu;

	public bool scrambledText;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent purchaseButton;

	public ClickableTextureComponent areaNextButton;

	public ClickableTextureComponent areaBackButton;

	public ClickableAnimatedComponent presentButton;

	public Action<int> onIngredientDeposit;

	public Action<JunimoNoteMenu> onBundleComplete;

	public Action<JunimoNoteMenu> onScreenSwipeFinished;

	private Bundle currentPageBundle;

	private Texture2D mobileBackground;

	private int areaBackX;

	private int areaBackY;

	private int forwardX;

	private int forwardY;

	private int startX;

	private int backX;

	private int backY;

	private int leftX;

	private int rightX;

	private int centX;

	private int textY;

	private float widthMod;

	private float heightMod;

	private Rectangle inventoryRect;

	private int goldX;

	private int goldY;

	private int highlightedBundle;

	private int _selectedItemIndex;

	private bool highlightPurchaseButton;

	private bool pressedOnBundleSpecificPage;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JunimoNoteMenu(bool fromGameMenu, int area = 1, bool fromThisMenu = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JunimoNoteMenu(int whichArea, Dictionary<int, bool[]> bundlesComplete)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JunimoNoteMenu(Bundle b, string noteTexturePath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool _ShouldAutoSnapPrioritizeAlignedElements()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpMenu(int whichArea, Dictionary<int, bool[]> bundlesComplete)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HighlightObjects(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReturnPartialDonation(Item item, bool play_sound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReturnPartialDonations(bool to_hand = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetPartialDonation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBePartiallyOrFullyDonated(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HandlePartialDonation(Item item, ClickableTextureComponent slot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isReadyToCloseMenuOrBundle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SwapPage(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closeBundlePage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void reOpenThisMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateIngredientSlots()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetRepresentativeItemId(BundleIngredientDescription ingredient)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetBundleRewards(int area, List<Item> rewards)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void openRewardsMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rewardGrabbed(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkIfBundleIsComplete()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void restoreaAreaOnExit_AbandonedJojaMart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void restoreAreaOnExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForRewards()
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getRewardNameForArea(int whichArea)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpBundleSpecificPage(Bundle b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addRectangleRowsToList(List<Rectangle> toAddTo, int numberOfItems, int centerX, int centerY, bool canShrink = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Rectangle> createRowOfBoxesCenteredAt(int xStart, int yStart, int numBoxes, int boxWidth, int boxHeight, int horizontalGap, bool canShrink = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void takeDownBundleSpecificPage(Bundle b = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Point getBundleLocationFromNumber(int whichBundle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void resetButtons()
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
	public void showTestBanner()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tryDepositItem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doNonSpecificBundlePageJoystick(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool doFromGameMenuJoystick(Buttons b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doSpecificBundlePageJoystick(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unsetRewardGrabbed(Item item, Farmer who)
	{
	}
}
