using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Monsters;

public class SquidKid : Monster
{
	[XmlIgnore]
	public float lastFireball;

	[XmlIgnore]
	public new int yOffset;

	private readonly NetEvent0 fireballEvent;

	private readonly NetEvent0 hurtAnimationEvent;

	private int numFireballsLeft;

	private float firingTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SquidKid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SquidKid(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
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
	protected override void sharedDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void localDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAllLayers(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateMonsterSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 fireballFired()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}
}
