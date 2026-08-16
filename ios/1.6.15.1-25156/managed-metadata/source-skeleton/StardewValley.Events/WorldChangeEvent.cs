using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Events;

public class WorldChangeEvent : BaseFarmEvent
{
	public const int identifier = 942066;

	public const int jojaGreenhouse = 0;

	public const int junimoGreenHouse = 1;

	public const int jojaBoiler = 2;

	public const int junimoBoiler = 3;

	public const int jojaBridge = 4;

	public const int junimoBridge = 5;

	public const int jojaBus = 6;

	public const int junimoBus = 7;

	public const int jojaBoulder = 8;

	public const int junimoBoulder = 9;

	public const int jojaMovieTheater = 10;

	public const int junimoMovieTheater = 11;

	public const int movieTheaterLightning = 12;

	public const int willyBoatRepair = 13;

	public const int treehouseBuild = 14;

	public const int goldenParrots = 15;

	public readonly NetInt whichEvent;

	private int cutsceneLengthTimer;

	private int timerSinceFade;

	private int soundTimer;

	private int soundInterval;

	private GameLocation location;

	private string sound;

	private bool wasRaining;

	public GameLocation preEventLocation;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WorldChangeEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WorldChangeEvent(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void obliterateJojaMartDoor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool setUp()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetForPlayerEntry(Point targetTile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ParrotFlyAway()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ParrotSquawk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ParrotStopSquawk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FinishTreehouse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ParrotBounce(TemporaryAnimatedSprite sprite)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GoldenParrotBounce(TemporaryAnimatedSprite sprite)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void makeChangesToLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void endEvent()
	{
	}
}
