using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class GameMenu : IClickableMenu
{
	public const int inventoryTab = 0;

	public const int skillsTab = 1;

	public const int socialTab = 2;

	public const int mapTab = 4;

	public const int craftingTab = 3;

	public const int animalsTab = 5;

	public const int powersTab = 6;

	public const int collectionsTab = 7;

	public const int optionsTab = 8;

	public const int exitTab = 9;

	public const int region_inventoryTab = 12340;

	public const int region_skillsTab = 12341;

	public const int region_socialTab = 12342;

	public const int region_mapTab = 12343;

	public const int region_craftingTab = 12344;

	public const int region_animalsTab = 12345;

	public const int region_powersTab = 12346;

	public const int region_collectionsTab = 12347;

	public const int region_optionsTab = 12348;

	public const int region_exitTab = 12349;

	public const int numberOfTabs = 9;

	public int currentTab;

	public int lastOpenedNonMapTab;

	public string hoverText;

	public string descriptionText;

	public List<ClickableComponent> tabs;

	public List<IClickableMenu> pages;

	public bool invisible;

	public static bool forcePreventClose;

	public static bool bundleItemHovered;

	private bool _showJunimoMenuNext;

	public ClickableTextureComponent junimoNoteIcon;

	public new int width;

	public new int height;

	public float widthMod;

	public float heightMod;

	public int tabWidth;

	public static int tabHeight;

	public int tabCollisionHeight;

	public int tabY;

	public int edgeX;

	public int edgeY;

	public RasterizerState _rasterizerState;

	private int oldxEdge;

	public static bool drawEdgeRect;

	public static bool drawToolbarRect;

	public static bool drawInvisibleButtonBox;

	private int junimoNotePulser;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameMenu(bool standardTabs = true, bool optionsOnly = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameMenu(int startingTab, int extra = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void automaticSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setUpForGamePadMode()
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
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getLabelOfTabFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTabNumberFromName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void changeTab(int whichTab, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTabNeighborsForCurrentPage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool overrideSnappyMenuCursorMovementBan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool areGamePadControlsImplemented()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void emergencyShutDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setupMenus(bool standardTabs = true, bool optionsOnly = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTabsToClickableComponents(IClickableMenu menu)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Type getMenuType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawTab(SpriteBatch b, int x, int y, int width, int height, bool isSelected = false, bool leftSmooth = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IClickableMenu GetCurrentPage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
