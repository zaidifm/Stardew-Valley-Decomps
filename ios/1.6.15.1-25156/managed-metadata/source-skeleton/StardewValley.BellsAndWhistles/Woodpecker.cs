using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.TerrainFeatures;

namespace StardewValley.BellsAndWhistles;

public class Woodpecker : Critter
{
	public const int flyingSpeed = 6;

	private bool flyingAway;

	private Tree tree;

	private int peckTimer;

	private int characterCheckTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Woodpecker(Tree tree, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
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
