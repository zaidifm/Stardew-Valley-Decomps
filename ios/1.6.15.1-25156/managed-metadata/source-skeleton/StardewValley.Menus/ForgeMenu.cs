using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class ForgeMenu : MenuWithInventory
{
	public enum CraftState
	{
		MissingIngredients,
		MissingShards,
		Valid,
		InvalidRecipe
	}

	protected int _timeUntilCraft;

	protected int _clankEffectTimer;

	protected int _sparklingTimer;

	public const int region_leftIngredient = 998;

	public const int region_rightIngredient = 997;

	public const int region_startButton = 996;

	public const int region_resultItem = 995;

	public const int region_unforgeButton = 994;

	public ClickableTextureComponent craftResultDisplay;

	public ClickableTextureComponent leftIngredientSpot;

	public ClickableTextureComponent rightIngredientSpot;

	public ClickableTextureComponent startTailoringButton;

	public ClickableComponent unforgeButton;

	private Rectangle expandedLeftIngredientSpot;

	private Rectangle expandedRightIngredientSpot;

	private Rectangle expandedStartForgingButton;

	public List<ClickableComponent> equipmentIcons;

	public const int region_ring_1 = 110;

	public const int region_ring_2 = 111;

	public const int CRAFT_TIME = 1600;

	public Texture2D forgeTextures;

	protected Dictionary<Item, bool> _highlightDictionary;

	protected TemporaryAnimatedSpriteList tempSprites;

	private bool unforging;

	protected string displayedDescription;

	protected CraftState _craftState;

	public Vector2 questionMarkOffset;

	private Rectangle bottomInv;

	private int forgePosX;

	private int forgePosY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ForgeMenu()
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
	public virtual void GenerateHighlightDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _leftIngredientSpotClicked()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsValidCraftIngredient(Item item)
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
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetForgeCostAtLevel(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetForgeCost(Item left_item, Item right_item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public virtual bool IsValidCraft(Item left_item, Item right_item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Item CraftItem(Item left_item, Item right_item, bool forReal = false)
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
	public virtual bool IsValidUnforge(bool ignore_right_slot_occupancy = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void drawDescriptionArea(SpriteBatch b, int x, int y, int red = -1, int green = -1, int blue = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}
}
