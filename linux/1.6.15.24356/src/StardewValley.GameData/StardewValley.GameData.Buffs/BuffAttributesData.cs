using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buffs;

public class BuffAttributesData
{
	[ContentSerializer(Optional = true)]
	public float CombatLevel;

	[ContentSerializer(Optional = true)]
	public float FarmingLevel;

	[ContentSerializer(Optional = true)]
	public float FishingLevel;

	[ContentSerializer(Optional = true)]
	public float MiningLevel;

	[ContentSerializer(Optional = true)]
	public float LuckLevel;

	[ContentSerializer(Optional = true)]
	public float ForagingLevel;

	[ContentSerializer(Optional = true)]
	public float MaxStamina;

	[ContentSerializer(Optional = true)]
	public float MagneticRadius;

	[ContentSerializer(Optional = true)]
	public float Speed;

	[ContentSerializer(Optional = true)]
	public float Defense;

	[ContentSerializer(Optional = true)]
	public float Attack;

	[ContentSerializer(Optional = true)]
	public float AttackMultiplier;

	[ContentSerializer(Optional = true)]
	public float Immunity;

	[ContentSerializer(Optional = true)]
	public float KnockbackMultiplier;

	[ContentSerializer(Optional = true)]
	public float WeaponSpeedMultiplier;

	[ContentSerializer(Optional = true)]
	public float CriticalChanceMultiplier;

	[ContentSerializer(Optional = true)]
	public float CriticalPowerMultiplier;

	[ContentSerializer(Optional = true)]
	public float WeaponPrecisionMultiplier;
}
