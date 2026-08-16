using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.BellsAndWhistles;

public class Seagull : Critter
{
	public const int walkingSpeed = 2;

	public const int flyingSpeed = 4;

	public const int walking = 0;

	public const int flyingAway = 1;

	public const int flyingToLand = 4;

	public const int swimming = 2;

	public const int stopped = 3;

	private int state;

	private int characterCheckTimer;

	private bool moveLeft;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Seagull(Vector2 position, int startingState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void hop(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
