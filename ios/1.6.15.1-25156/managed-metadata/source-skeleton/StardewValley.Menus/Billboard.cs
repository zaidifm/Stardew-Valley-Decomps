using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class Billboard : IClickableMenu
{
	[Flags]
	public enum BillboardEventType
	{
		None = 0,
		Birthday = 1,
		Festival = 2,
		FishingDerby = 4,
		PassiveFestival = 8,
		Wedding = 0x10,
		Bookseller = 0x20
	}

	public class BillboardDay
	{
		public BillboardEventType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public BillboardEvent[] Events
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string HoverText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public Texture2D Texture
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public Rectangle TextureSourceRect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BillboardDay(BillboardEvent[] events)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BillboardEvent GetEventOfType(BillboardEventType type)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class BillboardEvent
	{
		public bool locked;

		public BillboardEventType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string[] Arguments
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string DisplayName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public Texture2D Texture
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public Rectangle TextureSourceRect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BillboardEvent(BillboardEventType type, string[] arguments, string displayName, Texture2D texture = null, Rectangle sourceRect = default(Rectangle))
		{
		}
	}

	private Texture2D billboardTexture;

	public const int basewidth = 338;

	public const int baseWidth_calendar = 301;

	public const int baseheight = 198;

	private bool dailyQuestBoard;

	public ClickableComponent acceptQuestButton;

	public List<ClickableTextureComponent> calendarDays;

	private string hoverText;

	private string nightMarketLocalized;

	private string wizardBirthdayLocalized;

	private List<int> booksellerdays;

	protected Dictionary<ClickableTextureComponent, List<string>> _upcomingWeddings;

	public int infoPanelX;

	public int infoPanelY;

	public int infoPanelWidth;

	public int infoPanelHeight;

	private string infoPanelText;

	private int acceptTextWidth;

	private string acceptText;

	public int pixelZoom;

	public SpriteFont billboardFont;

	private ClickableTextureComponent selectedDate;

	public readonly Dictionary<int, BillboardDay> calendarDayData;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Billboard(bool dailyQuest = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDailyQuestButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SelectCalendarDate(ClickableTextureComponent c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Dictionary<int, List<NPC>> GetBirthdays()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<BillboardEvent> GetEventsForDay(int day, Dictionary<int, List<NPC>> birthdays)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
