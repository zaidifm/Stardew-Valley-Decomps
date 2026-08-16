using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Monsters;

public class Serpent : Monster
{
	public const float rotationIncrement = (float)Math.PI / 64f;

	[XmlIgnore]
	public int wasHitCounter;

	[XmlIgnore]
	public float targetRotation;

	[XmlIgnore]
	public bool turningRight;

	[XmlIgnore]
	public readonly NetFarmerRef killer;

	public List<Vector3> segments;

	public NetInt segmentCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Serpent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Serpent(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Serpent(Vector2 position, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeAttributes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRoyalSerpent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool TakesDamageFromHitbox(Rectangle area_of_effect)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OverlapsFarmerForDamage(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public override List<Item> getExtraDropItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAllLayers(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle GetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
