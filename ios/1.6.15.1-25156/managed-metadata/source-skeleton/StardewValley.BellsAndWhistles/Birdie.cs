using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class Birdie : Critter
{
	public const int brownBird = 25;

	public const int blueBird = 45;

	public const int flyingSpeed = 6;

	public const int walkingSpeed = 1;

	public const int pecking = 0;

	public const int flyingAway = 1;

	public const int sleeping = 2;

	public const int stopped = 3;

	public const int walking = 4;

	private int state;

	private float flightOffset;

	private bool stationary;

	private int characterCheckTimer;

	private int walkTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Birdie(int tileX, int tileY, int startingIndex = 25)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Birdie(Vector2 position, float yOffset, int startingIndex = 25, bool stationary = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void hop(Farmer who)
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
