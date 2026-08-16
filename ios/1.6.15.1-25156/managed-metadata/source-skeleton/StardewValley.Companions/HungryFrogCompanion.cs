using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Monsters;
using StardewValley.Network;

namespace StardewValley.Companions;

public class HungryFrogCompanion : HoppingCompanion
{
	private const int RANGE = 300;

	private const int FULLNESS_TIME = 12000;

	public float fullnessTime;

	private float monsterEatCheckTimer;

	private float tongueOutTimer;

	private readonly NetBool tongueOut;

	private readonly NetBool tongueReturn;

	private readonly NetPosition tonguePosition;

	private readonly NetVector2 tongueVelocity;

	private readonly NetNPCRef attachedMonsterField;

	private readonly NetEvent0 fullnessTrigger;

	private float initialEquipDelay;

	private float lastHopTimer;

	private Monster attachedMonster
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HungryFrogCompanion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HungryFrogCompanion(int variant)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnOwnerWarp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Hop(float amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void triggerFullnessTimer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tongueReachedMonster(Monster m)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Draw(SpriteBatch b)
	{
	}
}
