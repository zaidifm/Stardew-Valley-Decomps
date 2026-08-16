using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class CollectionsPage : IClickableMenu
{
	public const int region_sideTabShipped = 7001;

	public const int region_sideTabFish = 7002;

	public const int region_sideTabArtifacts = 7003;

	public const int region_sideTabMinerals = 7004;

	public const int region_sideTabCooking = 7005;

	public const int region_sideTabAchivements = 7006;

	public const int region_sideTabSecretNotes = 7007;

	public const int region_sideTabLetters = 7008;

	public const int region_forwardButton = 707;

	public const int region_backButton = 706;

	public static int widthToMoveActiveTab;

	public const int organicsTab = 0;

	public const int fishTab = 1;

	public const int archaeologyTab = 2;

	public const int mineralsTab = 3;

	public const int cookingTab = 4;

	public const int achievementsTab = 5;

	public const int secretNotesTab = 7;

	public const int lettersTab = 6;

	public const int distanceFromMenuBottomBeforeNewPage = 128;

	public LetterViewerMenu letterviewerSubMenu;

	private string descriptionText;

	private string hoverText;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent forwardButton;

	public Dictionary<int, ClickableTextureComponent> sideTabs;

	public int currentTab;

	public int currentPage;

	public int secretNoteImage;

	public Dictionary<int, List<List<ClickableTextureComponent>>> collections;

	private Dictionary<int, string> secretNotesData;

	private Texture2D secretNoteImageTexture;

	private bool changePanelHeight;

	private float widthMod;

	private float heightMod;

	private Rectangle mainBox;

	private Rectangle infoBox;

	private string headerText;

	private MobileScrollbar newScrollbar;

	private int numTabs;

	private int numInRow;

	private int numRows;

	private Rectangle[] mobSideTabs;

	private int xSpace;

	private int ySpace;

	private int[] col;

	private int[] row;

	private bool[] sliderVisible;

	private bool scrolling;

	private float[] sliderPercent;

	private string infoHeader;

	private ClickableTextureComponent[] currentlySelectedComponent;

	private ClickableTextureComponent highlightTexture;

	private MobileScrollbox scrollArea;

	private MobileScrollbox notesScrollArea;

	private int storedSecretPanelHeight;

	private int sideTabHeight;

	private int sideTabWidth;

	private int headerX;

	private int _selectedItemIndex;

	private int _lineNumber;

	private int value;

	private int selectedItemIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CollectionsPage(int x, int y, int width, int height, float wMod, float hMod, int topTabX)
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
	private bool farmerHasAchievements(string listOfAchievementNumbers)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
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
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string createDescription(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawInfoPanel(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
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
	private void OnChangeCollectionsTab()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowSelectectItemInfo(string dataStr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
	{
	}
}
