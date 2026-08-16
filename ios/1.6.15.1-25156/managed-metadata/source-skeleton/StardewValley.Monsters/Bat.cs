using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Monsters;

public class Bat : Monster
{
	public const float rotationIncrement = (float)Math.PI / 64f;

	[XmlIgnore]
	public readonly NetInt wasHitCounter;

	[XmlIgnore]
	public float targetRotation;

	[XmlIgnore]
	public readonly NetBool turningRight;

	[XmlIgnore]
	public readonly NetBool seenPlayer;

	public readonly NetBool cursedDoll;

	public readonly NetBool hauntedSkull;

	public readonly NetBool magmaSprite;

	public readonly NetBool canLunge;

	private ICue batFlap;

	private float extraVelocity;

	private float maxSpeed;

	public int lungeFrequency;

	public int lungeChargeTime;

	public int lungeSpeed;

	public int lungeDecelerationTicks;

	public int nextLunge;

	public int lungeTimer;

	public Vector2 lungeVelocity;

	private List<Vector2> previousPositions;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat(Vector2 position, int mineLevel)
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
	public override Debris ModifyMonsterLoot(Debris debris)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Item> getExtraDropItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void shedChunks(int number, float scale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onDealContactDamage(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAllLayers(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateAnimation(GameTime time)
	{
	}
}
