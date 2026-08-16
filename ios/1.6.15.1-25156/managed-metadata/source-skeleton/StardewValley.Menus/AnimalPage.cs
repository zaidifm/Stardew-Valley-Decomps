using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class AnimalPage : IClickableMenu
{
	public class AnimalEntry
	{
		public Character Animal;

		public readonly string InternalName;

		public readonly string DisplayName;

		public readonly string AnimalType;

		public readonly string AnimalBaseType;

		public readonly int FriendshipLevel;

		public readonly bool ReceivedAnimalCracker;

		public readonly int WasPetYet;

		public readonly int special;

		public Texture2D Texture;

		public Rectangle TextureSourceRect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimalEntry(Character animal)
		{
		}
	}

	public static int slotsOnPage;

	private string descriptionText;

	private string hoverText;

	private ClickableTextureComponent upButton;

	private ClickableTextureComponent downButton;

	private ClickableTextureComponent scrollBar;

	private Rectangle scrollBarRunner;

	public List<AnimalEntry> AnimalEntries;

	private readonly List<ClickableTextureComponent> sprites;

	private int slotPosition;

	public readonly List<ClickableTextureComponent> characterSlots;

	private bool scrolling;

	private int clickedEntry;

	private bool wholePanelScrolling;

	private float widthMod;

	private float heightMod;

	private float scrollSpeed;

	private Rectangle mainBox;

	private string headerText;

	private const int offset = 16;

	private int slotHeight;

	private int portraitX;

	private int nameX;

	private int divider1X;

	private int heartsX;

	private int divider2X;

	private int giftsX;

	private int talkX;

	private int divider0X;

	private int divider3X;

	private int divider4X;

	private int slotsYStart;

	private MobileScrollbar newScrollbar;

	private MobileScrollbox scrollArea;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimalPage(int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void init()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void populateClickableComponentList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<AnimalEntry> FindAnimals()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<Character> GetAllAnimals()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateComponents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableTextureComponent CreateSpriteComponent(AnimalEntry entry, int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimalEntry GetAnimalEntry(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateSlots()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addTabsToClickableComponents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _SelectSlot(ClickableComponent slot_component)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConstrainSelectionToVisibleSlots()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapCursorToCurrentSnappedComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void applyMovementKey(int direction)
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
	private void setScrollBarToCurrentIndex()
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
	public void upArrowPressed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void downArrowPressed()
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
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void drawNPCSlot(SpriteBatch b, int i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int rowPosition(int i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}
}
