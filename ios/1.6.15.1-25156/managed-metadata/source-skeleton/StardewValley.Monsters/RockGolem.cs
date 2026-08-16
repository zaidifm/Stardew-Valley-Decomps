using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Locations;

namespace StardewValley.Monsters;

public class RockGolem : Monster
{
	[XmlIgnore]
	public readonly NetBool seenPlayer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RockGolem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RockGolem(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RockGolem(Vector2 position, MineShaft mineArea)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RockGolem(Vector2 position, int difficultyMod)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RockGolem(Vector2 position, bool alreadySpawned)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Item> getExtraDropItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuffForAdditionalDifficulty(int additional_difficulty)
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
	public override void noMovementProgressNearPlayerBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateMonsterSlaveAnimation(GameTime time)
	{
	}
}
