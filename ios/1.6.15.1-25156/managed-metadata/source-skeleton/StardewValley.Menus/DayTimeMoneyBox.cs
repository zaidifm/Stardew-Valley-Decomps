using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.BellsAndWhistles;
using StardewValley.Quests;

namespace StardewValley.Menus;

public class DayTimeMoneyBox : IClickableMenu
{
	public const int HIT_AREA_WIDTH = 80;

	public const int HIT_AREA_HEIGHT = 280;

	public ClickableTextureComponent buttonGameMenu;

	public ClickableTextureComponent buttonF8;

	public Game1 game1;

	private int paddingX;

	private int paddingY;

	private int spacing;

	private bool drawingJustTheMenuButton;

	private bool _buttonGameMenuDown;

	private bool _buttonJournalDown;

	private static int _width;

	public Vector2 position;

	private Rectangle sourceRect;

	public MoneyDial moneyDial;

	public int timeShakeTimer;

	public int moneyShakeTimer;

	public int questPulseTimer;

	public int whenToPulseTimer;

	public ClickableTextureComponent questButton;

	public ClickableTextureComponent zoomOutButton;

	public ClickableTextureComponent zoomInButton;

	private StringBuilder _hoverText;

	private StringBuilder _timeText;

	private StringBuilder _dateText;

	private StringBuilder _hours;

	private StringBuilder _padZeros;

	private StringBuilder _temp;

	private int _lastDayOfMonth;

	private string _lastDayOfMonthString;

	private string _amString;

	private string _pmString;

	private LocalizedContentManager.LanguageCode _languageCode;

	public bool questsDirty;

	public int questPingTimer;

	private Vector2 _datePosition;

	private Vector2 _timePosition;

	public static int Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private int scaledViewportWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private bool ShowingTutorial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool buttonGameMenuVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DayTimeMoneyBox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isWithinBounds(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void gotGoldCoin(int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void pingQuest(Quest quest)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void questIconPulse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawJustTheGameMenuButton(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawMoneyBox(SpriteBatch b, int overrideX = -1, int overrideY = -1, bool oldGFX = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PingQuestLog()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DismissQuestPing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updatePosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPositionTopRight()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool testToOpenDebugConsole(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	private void OnTapGameMenuButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapJournalButton()
	{
	}
}
