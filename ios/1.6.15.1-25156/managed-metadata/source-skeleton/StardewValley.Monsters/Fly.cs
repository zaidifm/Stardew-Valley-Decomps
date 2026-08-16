using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Monsters;

public class Fly : Monster
{
	public const float rotationIncrement = (float)Math.PI / 64f;

	public const int volumeTileRange = 16;

	public const int spawnTime = 1000;

	[XmlIgnore]
	public int spawningCounter;

	[XmlIgnore]
	public int wasHitCounter;

	[XmlIgnore]
	public float targetRotation;

	public static ICue buzz;

	[XmlIgnore]
	public bool turningRight;

	public bool hard;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fly()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fly(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fly(Vector2 position, bool hard)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setHard()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAllLayers(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Removed()
	{
	}
}
