using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.BellsAndWhistles;

public class Opossum : Critter
{
	private int characterCheckTimer;

	private bool running;

	private int jumpTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Opossum(GameLocation location, Vector2 position, bool flip)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
