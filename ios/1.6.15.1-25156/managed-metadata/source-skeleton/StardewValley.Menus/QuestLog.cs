using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Quests;

namespace StardewValley.Menus;

public class QuestLog : IClickableMenu
{
	public int questsPerPage;

	public const int region_forwardButton = 101;

	public const int region_backButton = 102;

	public const int region_rewardBox = 103;

	public const int region_cancelQuestButton = 104;

	private List<List<IQuest>> pages;

	public List<ClickableComponent> questLogButtons;

	private int currentPage;

	private int questPage;

	public ClickableTextureComponent forwardButton;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent rewardBox;

	public ClickableTextureComponent cancelQuestButton;

	private float widthMod;

	private float heightMod;

	private Rectangle clipBox;

	private int boxHeight;

	private int boxWidth;

	private int entryHeight;

	private int entryX;

	private int entryWidth;

	private int expandedEntryYAddon;

	private int extraY;

	private int currentEntry;

	public MobileScrollbar newScrollbar;

	public MobileScrollbox scrollArea;

	private List<IQuest> quests;

	private bool scrollbarVisible;

	private bool ignoreClickRelease;

	private bool cancelButtonHeld;

	private bool scrollBarClicked;

	private string cancelQuestText;

	private int cancelQuestLength;

	private int _currentSelectedQuestIndex;

	private bool showingChallenge;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestLog(int showQuestIndex = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
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
	public override void leftClickHeld(int x, int y)
	{
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
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void makeDetailForEntry(int entry)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetScrollAreaPosition(int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void initializeBounds(int showQuestIndex = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpQuests(int showQuestIndex = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void recalculateButtonPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToggleShowQuest(int i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}
}
