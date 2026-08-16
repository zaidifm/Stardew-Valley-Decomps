using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Objects.Trinkets;

public class IceOrbTrinketEffect : TrinketEffect
{
	public const int Range = 600;

	public float ProjectileTimer;

	public float ProjectileDelay;

	public int FreezeTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceOrbTrinketEffect(Trinket trinket)
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
}
