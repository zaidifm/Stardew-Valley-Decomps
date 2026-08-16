using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Monsters;

[XmlInclude(typeof(BreathProjectile))]
public class DinoMonster : Monster
{
	public enum AttackState
	{
		None,
		Fireball,
		Charge
	}

	public class BreathProjectile : INetObject<NetFields>
	{
		public readonly NetBool active;

		public readonly NetVector2 position;

		public readonly NetVector2 startPosition;

		public readonly NetVector2 velocity;

		public float rotation;

		public float alpha;

		public NetFields NetFields
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreathProjectile()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Rectangle GetBoundingBox()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Rectangle GetSourceRect()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExplosionAnimation(GameLocation location)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(GameTime time, GameLocation location, DinoMonster parent)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw(SpriteBatch b)
		{
		}
	}

	public int timeUntilNextAttack;

	public readonly NetBool firing;

	public NetInt attackState;

	public int nextFireTime;

	public int totalFireTime;

	public int nextChangeDirectionTime;

	public int nextWanderTime;

	public bool wanderState;

	public readonly NetObjectArray<BreathProjectile> projectiles;

	public int lastProjectileSlot;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DinoMonster()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DinoMonster(Vector2 position)
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
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle GetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Item> getExtraDropItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShouldMonsterBeRemoved()
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
	public override void update(GameTime time, GameLocation location)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateMonsterSlaveAnimation(GameTime time)
	{
	}
}
