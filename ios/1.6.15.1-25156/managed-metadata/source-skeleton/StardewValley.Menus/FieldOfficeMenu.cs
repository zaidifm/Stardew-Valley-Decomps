using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Locations;

namespace StardewValley.Menus;

public class FieldOfficeMenu : MenuWithInventory
{
	private Texture2D fieldOfficeMenuTexture;

	private IslandFieldOffice office;

	private bool madeADonation;

	private bool gotReward;

	public List<ClickableComponent> pieceHolders;

	private new int width;

	private new int height;

	private Rectangle donationRec;

	private float panelWidthRatio;

	private float panelHightRatio;

	private float bearTimer;

	private float snakeTimer;

	private float batTimer;

	private float frogTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FieldOfficeMenu(IslandFieldOffice office)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool highlightBones(Item i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getPieceIndexForDonationItem(string qualifiedItemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getDonationPieceIndexNeededForSpot(int donationSpotIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void cleanupBeforeExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool donate(int index, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForSetFinish()
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
	private void drawHighlightedSquare(int index, SpriteBatch b)
	{
	}
}
