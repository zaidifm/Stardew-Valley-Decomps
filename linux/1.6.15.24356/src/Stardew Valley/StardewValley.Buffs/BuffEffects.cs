using Netcode;
using StardewValley.GameData.Buffs;

namespace StardewValley.Buffs;

public class BuffEffects : INetObject<NetFields>
{
	private readonly NetFloat[] AdditiveFields;

	private readonly NetFloat[] MultiplicativeFields;

	public readonly NetFloat CombatLevel = new NetFloat(0f);

	public readonly NetFloat FarmingLevel = new NetFloat(0f);

	public readonly NetFloat FishingLevel = new NetFloat(0f);

	public readonly NetFloat MiningLevel = new NetFloat(0f);

	public readonly NetFloat LuckLevel = new NetFloat(0f);

	public readonly NetFloat ForagingLevel = new NetFloat(0f);

	public readonly NetFloat MaxStamina = new NetFloat(0f);

	public readonly NetFloat MagneticRadius = new NetFloat(0f);

	public readonly NetFloat Speed = new NetFloat(0f);

	public readonly NetFloat Defense = new NetFloat(0f);

	public readonly NetFloat Attack = new NetFloat(0f);

	public readonly NetFloat AttackMultiplier = new NetFloat(0f);

	public readonly NetFloat Immunity = new NetFloat(0f);

	public readonly NetFloat KnockbackMultiplier = new NetFloat(0f);

	public readonly NetFloat WeaponSpeedMultiplier = new NetFloat(0f);

	public readonly NetFloat CriticalChanceMultiplier = new NetFloat(0f);

	public readonly NetFloat CriticalPowerMultiplier = new NetFloat(0f);

	public readonly NetFloat WeaponPrecisionMultiplier = new NetFloat(0f);

	public NetFields NetFields { get; } = new NetFields("BuffEffects");

	public BuffEffects()
	{
		AdditiveFields = new NetFloat[12]
		{
			CombatLevel, FarmingLevel, FishingLevel, MiningLevel, LuckLevel, ForagingLevel, MaxStamina, MagneticRadius, Speed, Defense,
			Attack, Immunity
		};
		MultiplicativeFields = new NetFloat[6] { AttackMultiplier, KnockbackMultiplier, WeaponSpeedMultiplier, CriticalChanceMultiplier, CriticalPowerMultiplier, WeaponPrecisionMultiplier };
		NetFields.SetOwner(this).AddField(CombatLevel, "CombatLevel").AddField(FarmingLevel, "FarmingLevel")
			.AddField(FishingLevel, "FishingLevel")
			.AddField(MiningLevel, "MiningLevel")
			.AddField(LuckLevel, "LuckLevel")
			.AddField(ForagingLevel, "ForagingLevel")
			.AddField(MaxStamina, "MaxStamina")
			.AddField(MagneticRadius, "MagneticRadius")
			.AddField(Speed, "Speed")
			.AddField(Defense, "Defense")
			.AddField(Attack, "Attack")
			.AddField(AttackMultiplier, "AttackMultiplier")
			.AddField(Immunity, "Immunity")
			.AddField(KnockbackMultiplier, "KnockbackMultiplier")
			.AddField(WeaponSpeedMultiplier, "WeaponSpeedMultiplier")
			.AddField(CriticalChanceMultiplier, "CriticalChanceMultiplier")
			.AddField(CriticalPowerMultiplier, "CriticalPowerMultiplier")
			.AddField(WeaponPrecisionMultiplier, "WeaponPrecisionMultiplier");
	}

	public BuffEffects(BuffAttributesData data)
		: this()
	{
		Add(data);
	}

	public void Add(BuffEffects other)
	{
		if (other != null)
		{
			for (int i = 0; i < AdditiveFields.Length; i++)
			{
				AdditiveFields[i].Value += other.AdditiveFields[i].Value;
			}
			for (int j = 0; j < MultiplicativeFields.Length; j++)
			{
				MultiplicativeFields[j].Value += other.MultiplicativeFields[j].Value;
			}
		}
	}

	public void Add(BuffAttributesData data)
	{
		if (data != null)
		{
			CombatLevel.Value = data.CombatLevel;
			FarmingLevel.Value = data.FarmingLevel;
			FishingLevel.Value = data.FishingLevel;
			MiningLevel.Value = data.MiningLevel;
			LuckLevel.Value = data.LuckLevel;
			ForagingLevel.Value = data.ForagingLevel;
			MaxStamina.Value = data.MaxStamina;
			MagneticRadius.Value = data.MagneticRadius;
			Speed.Value = data.Speed;
			Defense.Value = data.Defense;
			Attack.Value = data.Attack;
			AttackMultiplier.Value = data.AttackMultiplier;
			Immunity.Value = data.Immunity;
			KnockbackMultiplier.Value = data.KnockbackMultiplier;
			WeaponSpeedMultiplier.Value = data.WeaponSpeedMultiplier;
			CriticalChanceMultiplier.Value = data.CriticalChanceMultiplier;
			CriticalPowerMultiplier.Value = data.CriticalPowerMultiplier;
			WeaponPrecisionMultiplier.Value = data.WeaponPrecisionMultiplier;
		}
	}

	public bool HasAnyValue()
	{
		NetFloat[] additiveFields = AdditiveFields;
		for (int i = 0; i < additiveFields.Length; i++)
		{
			if (additiveFields[i].Value != 0f)
			{
				return true;
			}
		}
		additiveFields = MultiplicativeFields;
		for (int i = 0; i < additiveFields.Length; i++)
		{
			if (additiveFields[i].Value != 0f)
			{
				return true;
			}
		}
		return false;
	}

	public void Clear()
	{
		NetFloat[] additiveFields = AdditiveFields;
		for (int i = 0; i < additiveFields.Length; i++)
		{
			additiveFields[i].Value = 0f;
		}
		additiveFields = MultiplicativeFields;
		for (int i = 0; i < additiveFields.Length; i++)
		{
			additiveFields[i].Value = 0f;
		}
	}

	public string[] ToLegacyAttributeFormat()
	{
		return new string[13]
		{
			((int)FarmingLevel.Value).ToString(),
			((int)FishingLevel.Value).ToString(),
			((int)MiningLevel.Value).ToString(),
			"0",
			((int)LuckLevel.Value).ToString(),
			((int)ForagingLevel.Value).ToString(),
			"0",
			((int)MaxStamina.Value).ToString(),
			((int)MagneticRadius.Value).ToString(),
			Speed.Value.ToString(),
			((int)Defense.Value).ToString(),
			((int)Attack.Value).ToString(),
			""
		};
	}
}
