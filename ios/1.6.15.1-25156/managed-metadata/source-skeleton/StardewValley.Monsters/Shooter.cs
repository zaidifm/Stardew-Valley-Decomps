using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Monsters;

public class Shooter : Monster
{
	public NetBool shooting;

	public int shotsLeft;

	public float nextShot;

	public int projectileSpeed;

	public string projectileDebuff;

	public int numberOfShotsPerFire;

	public float aimTime;

	public float burstTime;

	public float aimEndTime;

	public int firedProjectile;

	public string damageSound;

	public string fireSound;

	public int projectileRange;

	public int desiredDistance;

	public int fireRange;

	[XmlIgnore]
	public NetEvent0 fireEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shooter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetBaseDifficultyLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFire()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShouldActuallyMoveAwayFromPlayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shooter(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shooter(Vector2 position, string monster_name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeVariant()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
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
	public override void updateMovement(GameLocation location, GameTime time)
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
	public override void update(GameTime time, GameLocation location)
	{
	}
}
