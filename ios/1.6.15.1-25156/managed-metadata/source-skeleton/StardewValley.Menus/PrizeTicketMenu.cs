using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class PrizeTicketMenu : IClickableMenu
{
	public const int WIDTH = 116;

	public const int HEIGHT = 94;

	public Texture2D texture;

	public ClickableTextureComponent mainButton;

	public float pressedButtonTimer;

	public List<Item> currentPrizeTrack;

	public float getRewardTimer;

	public float moveRewardTrackTimer;

	public float moveRewardTrackPreTimer;

	public bool gettingReward;

	public bool movingRewardTrack;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PrizeTicketMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item getPrizeItem(int prizeLevel)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
}
