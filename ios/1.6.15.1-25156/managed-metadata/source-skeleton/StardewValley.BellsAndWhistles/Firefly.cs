using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class Firefly : Critter
{
	private bool glowing;

	private int id;

	private Vector2 motion;

	private LightSource light;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Firefly()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Firefly(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveFrontLayer(SpriteBatch b)
	{
	}
}
