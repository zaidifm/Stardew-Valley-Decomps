using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.TerrainFeatures;

namespace StardewValley.BellsAndWhistles;

public class Squirrel : Critter
{
	private int nextNibbleTimer;

	private int treeRunTimer;

	private int characterCheckTimer;

	private bool running;

	private Tree climbed;

	private Vector2 treeTile;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Squirrel(Vector2 position, bool flip)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doneNibbling(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
