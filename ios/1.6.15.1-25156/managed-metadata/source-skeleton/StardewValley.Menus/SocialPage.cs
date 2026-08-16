using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.GameData.Characters;

namespace StardewValley.Menus;

public class SocialPage : IClickableMenu
{
	public class SocialEntry
	{
		private bool? CachedIsMarriedToAnyone;

		public Character Character;

		public readonly string InternalName;

		public readonly string DisplayName;

		public readonly bool IsMet;

		public readonly bool IsDatable;

		public readonly SocialTabBehavior SocialTabBehavior;

		public readonly bool IsChild;

		public readonly bool IsPlayer;

		public readonly Gender Gender;

		public readonly int HeartLevel;

		public readonly Friendship Friendship;

		public readonly CharacterData Data;

		public int? OrderMet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialEntry(Farmer player, Friendship friendship)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialEntry(NPC npc, Friendship friendship, CharacterData data, string overrideDisplayName = null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsDatingCurrentPlayer()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsMarriedToCurrentPlayer()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsRoommateForCurrentPlayer()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsDivorcedFromCurrentPlayer()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsMarriedToAnyone()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static int slotsOnPage;

	private string descriptionText;

	private string hoverText;

	public ClickableTextureComponent upButton;

	public ClickableTextureComponent downButton;

	public ClickableTextureComponent scrollBar;

	public Rectangle scrollBarRunner;

	public readonly List<SocialEntry> SocialEntries;

	public readonly List<ClickableTextureComponent> sprites;

	public int slotPosition;

	public int numFarmers;

	public readonly List<ClickableTextureComponent> characterSlots;

	public bool scrolling;

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
	public SocialPage(int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<SocialEntry> FindSocialCharacters()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<NPC> GetAllNpcs()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateComponents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableTextureComponent CreateSpriteComponent(SocialEntry entry, int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SocialEntry GetSocialEntry(int index)
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
	public void drawFarmerSlot(SpriteBatch b, int i)
	{
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
