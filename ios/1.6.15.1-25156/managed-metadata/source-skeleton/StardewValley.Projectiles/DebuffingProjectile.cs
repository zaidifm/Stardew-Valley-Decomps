using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.TerrainFeatures;

namespace StardewValley.Projectiles;

public class DebuffingProjectile : Projectile
{
	public readonly NetString debuff;

	public NetBool wavyMotion;

	public NetInt debuffIntensity;

	private float periodicEffectTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DebuffingProjectile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DebuffingProjectile(string debuff, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition, GameLocation location = null, Character owner = null, bool hitsMonsters = false, bool playDefaultSoundOnFire = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updatePosition(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorOnCollisionWithPlayer(GameLocation location, Farmer player)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorOnCollisionWithTerrainFeature(TerrainFeature t, Vector2 tileLocation, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorOnCollisionWithOther(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void explosionAnimation(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorOnCollisionWithMonster(NPC n, GameLocation location)
	{
	}
}
