using System.Runtime.CompilerServices;
using StardewValley.Monsters;

namespace StardewValley.Enchantments;

public class CrusaderEnchantment : BaseWeaponEnchantment
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCalculateDamage(Monster monster, GameLocation location, Farmer who, bool fromBomb, ref int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrusaderEnchantment()
	{
	}
}
