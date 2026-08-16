using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Monsters;

namespace StardewValley.Objects.Trinkets;

public class FairyBoxTrinketEffect : TrinketEffect
{
	public float HealTimer;

	public float HealDelay;

	public float Power;

	public int DamageSinceLastHeal;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FairyBoxTrinketEffect(Trinket trinket)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool GenerateRandomStats(Trinket trinket)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDamageMonster(Farmer farmer, Monster monster, int damageAmount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnReceiveDamage(Farmer farmer, int damageAmount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(Farmer farmer, GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Apply(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Unapply(Farmer farmer)
	{
	}
}
