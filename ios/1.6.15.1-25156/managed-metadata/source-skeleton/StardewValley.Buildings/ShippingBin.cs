using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Buildings;

public class ShippingBin : Building
{
	private TemporaryAnimatedSprite shippingBinLid;

	private Farm farm;

	private Rectangle shippingBinLidOpenArea;

	protected Vector2 _lidGenerationPosition;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShippingBin(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShippingBin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initLid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle? getSourceRectForMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performActionOnBuildingPlacement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void openShippingBinLid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closeShippingBinLid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateShippingBinLid(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isShippingBinLidOpen(bool requiredToBeFullyOpen = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void shipItem(Item i, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item getLastItemShipped()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setLastItemShipped(Item i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanLeftClick(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool leftClicked()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showShipment(Item item, bool playThrowSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool doAction(Vector2 tileLocation, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
