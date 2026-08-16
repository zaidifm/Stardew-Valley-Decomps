using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Monsters;

public class Mummy : Monster
{
	public NetInt reviveTimer;

	public const int revivalTime = 10000;

	protected int _damageToFarmer;

	private readonly NetEvent1Field<bool, NetBool> crumbleEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mummy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mummy(Vector2 position)
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
	public override void defaultMovementBehavior(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Item> getExtraDropItems()
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
	private void crumble(bool reverse = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performCrumble(bool reverse)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<FarmerSprite.AnimationFrame> getCrumbleAnimation(bool reverse = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	private void behaviorAfterCrumble(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void behaviorAfterRevival(Farmer who)
	{
	}
}
