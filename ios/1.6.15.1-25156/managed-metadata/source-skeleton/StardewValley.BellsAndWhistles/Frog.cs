using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class Frog : Critter
{
	private bool waterLeaper;

	private bool leapingIntoWater;

	private bool splash;

	private int characterCheckTimer;

	private int beforeFadeTimer;

	private float alpha;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Frog(Vector2 position, bool waterLeaper = false, bool forceFlip = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startSplash(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveFrontLayer(SpriteBatch b)
	{
	}
}
