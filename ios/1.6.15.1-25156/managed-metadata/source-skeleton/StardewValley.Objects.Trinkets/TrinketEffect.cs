using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Companions;
using StardewValley.Monsters;

namespace StardewValley.Objects.Trinkets;

public class TrinketEffect
{
	public Trinket Trinket;

	public int GeneralStat;

	public Companion Companion;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrinketEffect(Trinket trinket)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUse(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Apply(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Unapply(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFootstep(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnReceiveDamage(Farmer farmer, int damageAmount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDamageMonster(Farmer farmer, Monster monster, int damageAmount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool GenerateRandomStats(Trinket trinket)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(Farmer farmer, GameTime time, GameLocation location)
	{
	}
}
