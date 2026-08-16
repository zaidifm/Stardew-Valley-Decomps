using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Network;

namespace StardewValley.Menus;

public class FarmhandMenu : LoadGameMenu
{
	public class FarmhandSlot : SaveFileSlot
	{
		protected new FarmhandMenu menu;

		protected bool _belongsToAnotherPlayer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool BelongsToAnotherPlayer()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FarmhandSlot(FarmhandMenu menu, Farmer farmer)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Activate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override float getSlotAlpha()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void drawSlotName(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void drawSlotShadow(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void drawSlotFarmer(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void drawSlotTimer(SpriteBatch b, int i)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void drawSlotMoney(SpriteBatch b, int i)
		{
		}
	}

	public bool gettingFarmhands;

	public bool approvingFarmhand;

	public Client client;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmhandMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmhandMenu(Client client)
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
	public override void UpdateButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool checkListPopulation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
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
	public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadClientOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string getStatusText()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}
}
