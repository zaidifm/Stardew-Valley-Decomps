using System.Runtime.CompilerServices;

namespace StardewValley.Objects.Trinkets;

public class CompanionTrinketEffect : TrinketEffect
{
	public int Variant;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompanionTrinketEffect(Trinket trinket)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool GenerateRandomStats(Trinket trinket)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
