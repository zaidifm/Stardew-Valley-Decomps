using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.BellsAndWhistles;

public class Crow : Critter
{
	public const int flyingSpeed = 6;

	public const int pecking = 0;

	public const int flyingAway = 1;

	public const int sleeping = 2;

	public const int stopped = 3;

	private int state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crow(int tileX, int tileY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void hop(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void donePecking(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playFlap(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playPeck(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
