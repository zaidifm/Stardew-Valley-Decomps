using System.Runtime.CompilerServices;
using StardewValley.Tools;

namespace StardewValley.Enchantments;

public class BaseWeaponEnchantment : BaseEnchantment
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanApplyTo(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSwing(MeleeWeapon weapon, Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _OnSwing(MeleeWeapon weapon, Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BaseWeaponEnchantment()
	{
	}
}
