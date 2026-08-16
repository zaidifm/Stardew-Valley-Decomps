using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Monsters;

public class AngryRoger : Monster
{
	public const float rotationIncrement = (float)Math.PI / 64f;

	[XmlIgnore]
	public int wasHitCounter;

	[XmlIgnore]
	public float targetRotation;

	[XmlIgnore]
	public bool turningRight;

	[XmlIgnore]
	public int identifier;

	[XmlIgnore]
	public new int yOffset;

	[XmlIgnore]
	public int yOffsetExtra;

	public string lightSourceId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AngryRoger()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AngryRoger(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AngryRoger(Vector2 position, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAllLayers(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void localDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void sharedDeathAnimation()
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
}
