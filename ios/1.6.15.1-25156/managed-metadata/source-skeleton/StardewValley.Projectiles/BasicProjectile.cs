using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.TerrainFeatures;

namespace StardewValley.Projectiles;

public class BasicProjectile : Projectile
{
	public delegate void onCollisionBehavior(GameLocation location, int xPosition, int yPosition, Character who);

	public readonly NetInt damageToFarmer;

	public readonly NetString collisionSound;

	public readonly NetBool explode;

	public onCollisionBehavior collisionBehavior;

	public NetString debuff;

	public NetString debuffSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BasicProjectile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BasicProjectile(int damageToFarmer, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition, string collisionSound = null, string bounceSound = null, string firingSound = null, bool explode = false, bool damagesMonsters = false, GameLocation location = null, Character firer = null, onCollisionBehavior collisionBehavior = null, string shotItemId = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BasicProjectile(int damageToFarmer, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updatePosition(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitNetFields()
	{
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
	public override void behaviorOnCollisionWithMonster(NPC n, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void explosionAnimation(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void explodeOnImpact(GameLocation location, int x, int y, Character who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Farmer GetPlayerWhoFiredMe(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
