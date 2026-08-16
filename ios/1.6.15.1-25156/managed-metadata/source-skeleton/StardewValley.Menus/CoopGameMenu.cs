using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.SDKs;

namespace StardewValley.Menus;

public class CoopGameMenu : LoadGameMenu
{
	protected abstract class CoopGameMenuSlot : MenuSlot
	{
		protected new CoopGameMenu menu;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CoopGameMenuSlot(CoopGameMenu menu)
		{
		}
	}

	protected abstract class LabeledSlot : CoopGameMenuSlot
	{
		private string message;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LabeledSlot(CoopGameMenu menu, string message)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public abstract override void Activate();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Draw(SpriteBatch b, int i)
		{
		}
	}

	protected class LanSlot : LabeledSlot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LanSlot(CoopGameMenu menu)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Activate()
		{
		}
	}

	protected class InviteCodeSlot : LabeledSlot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InviteCodeSlot(CoopGameMenu menu)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Activate()
		{
		}
	}

	protected class HostNewFarmSlot : LabeledSlot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HostNewFarmSlot(CoopGameMenu menu)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Activate()
		{
		}
	}

	protected class HostFileSlot : SaveFileSlot
	{
		protected new CoopGameMenu menu;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HostFileSlot(CoopGameMenu menu, Farmer farmer)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Activate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void drawSlotSaveNumber(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override string slotName()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override string slotSubName()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Vector2 portraitOffset()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected class FriendFarmData
	{
		public object Lobby;

		public string OwnerName;

		public string FarmName;

		public int FarmType;

		public WorldDate Date;

		public bool PreviouslyJoined;

		public string ProtocolVersion;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendFarmData()
		{
		}
	}

	protected class FriendFarmSlot : CoopGameMenuSlot
	{
		public FriendFarmData Farm;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendFarmSlot(CoopGameMenu menu, FriendFarmData farm)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MatchAddress(object Lobby)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(FriendFarmData newData)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Activate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string slotName()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotName(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotDate(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotFarm(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void drawSlotOwnerName(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Draw(SpriteBatch b, int i)
		{
		}
	}

	private class LobbyUpdateCallback : LobbyUpdateListener
	{
		private Action<object> callback;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LobbyUpdateCallback(Action<object> callback)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLobbyUpdate(object lobby)
		{
		}
	}

	public const int region_refresh = 810;

	protected List<MenuSlot> hostSlots;

	public ClickableComponent refreshButton;

	public ClickableComponent joinTab;

	public ClickableComponent hostTab;

	private LobbyUpdateListener lobbyUpdateListener;

	private string Filter;

	private bool isSetUp;

	private int updateCounter;

	private double connectionFinishedTimer;

	public bool isHostMenu;

	private float widthMod;

	private float heightMod;

	private StringBuilder _stringBuilder;

	public override List<MenuSlot> MenuSlots
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
	public CoopGameMenu(bool isHostMenu, string filter = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool hasDeleteButtons()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void startListPopulation(string filter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void connectionFinished()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void saveFileScanComplete()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual FriendFarmData readLobbyFarmData(object lobby)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool checkFriendFarmCompatibility(FriendFarmData farm)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void onLobbyUpdate(object lobby)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void addSaveFiles(List<Farmer> files)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void setMenu(IClickableMenu menu)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void enterIPPressed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void enterInviteCodePressed()
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
	protected override string getStatusText()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void drawBefore(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void drawExtra(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void drawStatusText(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}
}
