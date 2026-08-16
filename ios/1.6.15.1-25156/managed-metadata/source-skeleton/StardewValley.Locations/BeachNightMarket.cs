using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class BeachNightMarket : GameLocation
{
	private Texture2D shopClosedTexture;

	private float smokeTimer;

	private string paintingMailKey;

	private bool hasReceivedFreeGift;

	private bool hasShownCCUpgrade;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BeachNightMarket()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BeachNightMarket(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getDayOfNightMarket()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void getFreeGiftPartOne(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void getFreeGift(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}
}
