using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.GameData.Crafting;
using StardewValley.Objects;

namespace StardewValley.Menus;

public class TailoringMenu : MenuWithInventory
{
	public enum CraftState
	{
		MissingIngredients,
		Valid,
		InvalidRecipe,
		NotDyeable
	}

	public class TailorHighlight
	{
		public readonly bool LeftSlot;

		public readonly bool RightSlot;

		public readonly bool EquipmentSlot;

		public readonly bool AnySlot;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TailorHighlight()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TailorHighlight(bool leftSlot, bool rightSlot, bool equipmentSlot)
		{
		}
	}

	protected int _timeUntilCraft;

	public const int region_leftIngredient = 998;

	public const int region_rightIngredient = 997;

	public const int region_startButton = 996;

	public const int region_resultItem = 995;

	public ClickableTextureComponent needleSprite;

	public ClickableTextureComponent presserSprite;

	public ClickableTextureComponent craftResultDisplay;

	public Vector2 needlePosition;

	public Vector2 presserPosition;

	public Vector2 leftIngredientStartSpot;

	public Vector2 leftIngredientEndSpot;

	protected float _rightItemOffset;

	public ClickableTextureComponent leftIngredientSpot;

	public ClickableTextureComponent rightIngredientSpot;

	public ClickableTextureComponent blankLeftIngredientSpot;

	public ClickableTextureComponent blankRightIngredientSpot;

	public ClickableTextureComponent startTailoringButton;

	public const int region_shirt = 108;

	public const int region_pants = 109;

	public const int region_hat = 101;

	public List<ClickableComponent> equipmentIcons;

	public const int CRAFT_TIME = 1500;

	public Texture2D tailoringTextures;

	public List<TailorItemRecipe> _tailoringRecipes;

	private ICue _sewingSound;

	private readonly Dictionary<Item, TailorHighlight> ItemHighlightCache;

	protected bool _shouldPrismaticDye;

	protected bool _heldItemIsEquipped;

	protected bool _isDyeCraft;

	protected bool _isMultipleResultCraft;

	protected string displayedDescription;

	protected CraftState _craftState;

	public Vector2 questionMarkOffset;

	private const int item_hat = 0;

	private const int item_shirt = 1;

	private const int item_pants = 2;

	private int dragEquippedItem;

	private int selectedEquppedItem;

	private Rectangle infoBox;

	private Rectangle bottomInv;

	private Rectangle dyePanelRect;

	private float widthMod;

	private float heightMod;

	private new int width;

	private new int height;

	private int dyePanelX;

	private int dyePanelY;

	private int dyePanelHeight;

	private int dyePanelWidth;

	private int dyePanelCrop;

	private int red;

	private int green;

	private int blue;

	private float dyePanelRatioWH;

	private float dyePanelWidthRatio;

	private float dyePanelHeightRatio;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TailoringMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _CreateButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBusy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HighlightItems(Item i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuildHighlightCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _leftIngredientSpotClicked()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidCraftIngredient(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _rightIngredientSpotClicked()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHoldingEquippedItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ValidateCraft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _UpdateDescriptionText()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color? GetDyeColor(Item dye_object)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DyeItems(Clothing clothing, Item dye_object, float dye_strength_override = -1f)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TailorItemRecipe GetRecipeForItems(Item leftItem, Item rightItem)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool HasRequiredTags(Item item, List<string> requiredTags)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidCraft(Item left_item, Item right_item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMultipleResultCraft(Item left_item, Item right_item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item CraftItem(Item left_item, Item right_item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ConvertLegacyItemId(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpendRightItem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpendLeftItem()
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
	public bool CanFitCraftedItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void emergencyShutDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
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
	protected void _OnCloseMenu()
	{
	}
}
