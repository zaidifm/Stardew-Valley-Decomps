using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.GameData.Buffs;

namespace StardewValley.Buffs;

public class BuffEffects : INetObject<NetFields>
{
	private readonly NetFloat[] AdditiveFields;

	private readonly NetFloat[] MultiplicativeFields;

	public readonly NetFloat CombatLevel;

	public readonly NetFloat FarmingLevel;

	public readonly NetFloat FishingLevel;

	public readonly NetFloat MiningLevel;

	public readonly NetFloat LuckLevel;

	public readonly NetFloat ForagingLevel;

	public readonly NetFloat MaxStamina;

	public readonly NetFloat MagneticRadius;

	public readonly NetFloat Speed;

	public readonly NetFloat Defense;

	public readonly NetFloat Attack;

	public readonly NetFloat AttackMultiplier;

	public readonly NetFloat Immunity;

	public readonly NetFloat KnockbackMultiplier;

	public readonly NetFloat WeaponSpeedMultiplier;

	public readonly NetFloat CriticalChanceMultiplier;

	public readonly NetFloat CriticalPowerMultiplier;

	public readonly NetFloat WeaponPrecisionMultiplier;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuffEffects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuffEffects(BuffAttributesData data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(BuffEffects other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(BuffAttributesData data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasAnyValue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] ToLegacyAttributeFormat()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
