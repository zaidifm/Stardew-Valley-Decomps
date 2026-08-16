using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Objects.Trinkets;

public class MagicQuiverTrinketEffect : TrinketEffect
{
	public static HashSet<string> CachedIgnoreLocations;

	public static HashSet<string> CachedIgnoreMonsters;

	public const int Range = 500;

	public float ProjectileTimer;

	public float ProjectileDelay;

	public int MinDamage;

	public int MaxDamage;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MagicQuiverTrinketEffect(Trinket trinket)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Apply(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool GenerateRandomStats(Trinket trinket)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(Farmer farmer, GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HashSet<string> GetIgnoredLocations()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HashSet<string> GetIgnoredMonsterNames()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
