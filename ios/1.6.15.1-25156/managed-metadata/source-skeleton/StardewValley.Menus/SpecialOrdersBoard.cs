using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.SpecialOrders;

namespace StardewValley.Menus;

public class SpecialOrdersBoard : IClickableMenu
{
	private Texture2D billboardTexture;

	public const int basewidth = 338;

	public const int baseheight = 198;

	public ClickableComponent acceptLeftQuestButton;

	public ClickableComponent acceptRightQuestButton;

	public string boardType;

	public SpecialOrder leftOrder;

	public SpecialOrder rightOrder;

	public string[] emojiIndices;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpecialOrdersBoard(string board_type = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateButtons()
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
	public string GetOrderType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public KeyValuePair<Texture2D, Rectangle>? GetPortraitForRequester(string requester_name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawQuestDetails(SpriteBatch b, SpecialOrder order, int x)
	{
	}
}
