using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class Railroad : GameLocation
{
	private const double TrainChance = 0.09;

	public const int trainSoundDelay = 15000;

	[XmlIgnore]
	public readonly NetRef<Train> train;

	[XmlElement("hasTrainPassed")]
	private readonly NetBool hasTrainPassed;

	private int trainTime;

	[XmlIgnore]
	public readonly NetInt trainTimer;

	public static ICue trainLoop;

	[XmlElement("witchStatueGone")]
	public readonly NetBool witchStatueGone;

	internal static double DailyTrainChance;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Railroad()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Railroad()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Railroad(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ResetForEvent(Event ev)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
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
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ResetTrainForNewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTrainComing(int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayTrainApproach()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string locationName = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isTileFishable(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartTrainLoopIfNeeded()
	{
	}
}
