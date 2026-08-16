using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class LoadGameMenu : IClickableMenu, IDisposable
{
	public abstract class MenuSlot : IDisposable
	{
		public int ActivateDelay;

		protected LoadGameMenu menu;

		public SpriteFont mainSlotFont;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MenuSlot(LoadGameMenu menu)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void setFont(SpriteFont font)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool isLabelledSlot()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public abstract void Activate();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public abstract void Draw(SpriteBatch b, int i);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
		}
	}

	public class SaveFileSlot : MenuSlot
	{
		public Farmer Farmer;

		public int? SlotNumber;

		public double redTimer;

		public int versionComparison;

		private int xBinOffset;

		private Vector2 _position;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveFileSlot(LoadGameMenu menu, Farmer farmer, int? slotNumber)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Activate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotSaveNumber(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string slotName()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual float getSlotAlpha()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotName(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotShadow(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Vector2 portraitOffset()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotFarmer(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotDate(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string slotSubName()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotSubName(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotMoney(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotTimer(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void drawVersionMismatchSlot(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Draw(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void Dispose()
		{
		}
	}

	protected const int CenterOffset = 0;

	public MobileScrollbox scrollArea;

	public MobileScrollbar newScrollbar;

	private Rectangle mainBox;

	private Rectangle clipBox;

	private Rectangle outerBox;

	private new int width;

	private new int height;

	private int windowInset;

	private float widthMod;

	private float heightMod;

	private bool sliderVisible;

	private bool _okSelected;

	private bool _cancelSelected;

	public int itemsPerPage;

	private int storedSaves;

	private int itemHeight;

	private SpriteFont mainFont;

	private ConfirmationDialog confirmBox;

	private ConfirmationDialog backupBox;

	private int _joypadSelectedItemIndex;

	public const int region_upArrow = 800;

	public const int region_downArrow = 801;

	public const int region_okDelete = 802;

	public const int region_cancelDelete = 803;

	public const int region_slots = 900;

	public const int region_deleteButtons = 901;

	public const int region_navigationButtons = 902;

	public const int region_deleteConfirmations = 903;

	public List<ClickableComponent> slotButtons;

	public List<ClickableTextureComponent> deleteButtons;

	protected int currentItemIndex;

	protected int timerToLoad;

	protected int selected;

	protected int selectedForDelete;

	public ClickableTextureComponent upArrow;

	public ClickableTextureComponent downArrow;

	public ClickableTextureComponent scrollBar;

	public ClickableTextureComponent okDeleteButton;

	public ClickableTextureComponent cancelDeleteButton;

	public ClickableComponent backButton;

	public bool scrolling;

	public bool deleteConfirmationScreen;

	protected List<MenuSlot> menuSlots;

	private Rectangle scrollBarRunner;

	protected string hoverText;

	protected bool loading;

	protected bool drawn;

	private bool deleting;

	private int _updatesSinceLastDeleteConfirmScreen;

	private Task<List<Farmer>> _initTask;

	private Task _deleteTask;

	private bool disposedValue;

	public virtual List<MenuSlot> MenuSlots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDoingTask()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoadGameMenu(string filter = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool hasDeleteButtons()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void startListPopulation(string filter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void addSaveFiles(List<Farmer> files)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<Farmer> FindSaveGames(string filter)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
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
	protected void setScrollBarToCurrentIndex()
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
	private void deleteFile(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void saveFileScanComplete()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool checkListPopulation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getStatusText()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void drawExtra(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void drawSlotBackground(SpriteBatch b, int i, MenuSlot slot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void drawBefore(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void drawStatusText(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void recalculateSlots()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void positionChildren()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void backupSelected(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void mainSelected(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void okSelected(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void cancelSelected(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetButtonStatus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~LoadGameMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("LOG_FS_IO")]
	private static void LogFsio(string format, params object[] args)
	{
	}
}
