using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.BellsAndWhistles;

namespace StardewValley.Menus;

public class ShippingMenu : IClickableMenu
{
	public const int region_okbutton = 101;

	public const int region_forwardButton = 102;

	public const int region_backButton = 103;

	public const int farming_category = 0;

	public const int foraging_category = 1;

	public const int fishing_category = 2;

	public const int mining_category = 3;

	public const int other_category = 4;

	public const int total_category = 5;

	public const int timePerIntroCategory = 500;

	public const int outroFadeTime = 800;

	public const int smokeRate = 100;

	public int categorylabelHeight;

	public int itemsPerCategoryPage;

	public int currentPage;

	public int currentTab;

	public List<ClickableTextureComponent> categories;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent forwardButton;

	public ClickableTextureComponent backButton;

	private List<int> categoryTotals;

	private List<MoneyDial> categoryDials;

	private List<List<Item>> categoryItems;

	private int categoryLabelsWidth;

	private int plusButtonWidth;

	private int itemSlotWidth;

	private int itemAndPlusButtonWidth;

	private int totalWidth;

	private int centerX;

	private int centerY;

	private int introTimer;

	private int outroFadeTimer;

	private int outroPauseBeforeDateChange;

	private int finalOutroTimer;

	private int smokeTimer;

	private int dayPlaqueY;

	private float weatherX;

	private bool outro;

	private bool newDayPlaque;

	private bool savedYet;

	public List<TemporaryAnimatedSprite> animations;

	private float heightMod;

	private SaveGameMenu saveGameMenu;

	protected bool _hasFinished;

	public bool _activated;

	public int viewportWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int viewportHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShippingMenu(IList<Item> items)
	{
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
	public void parseItems(IList<Item> items)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getCategoryIndexForObject(Object o)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getCategoryName(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getCategorySound(int which)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void okClicked()
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
	public bool showForwardButton()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
