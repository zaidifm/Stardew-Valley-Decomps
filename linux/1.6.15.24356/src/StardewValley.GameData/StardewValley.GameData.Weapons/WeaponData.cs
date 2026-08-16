using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Weapons;

public class WeaponData
{
	public string Name;

	public string DisplayName;

	public string Description;

	public int MinDamage;

	public int MaxDamage;

	[ContentSerializer(Optional = true)]
	public float Knockback = 1f;

	[ContentSerializer(Optional = true)]
	public int Speed;

	[ContentSerializer(Optional = true)]
	public int Precision;

	[ContentSerializer(Optional = true)]
	public int Defense;

	public int Type;

	[ContentSerializer(Optional = true)]
	public int MineBaseLevel = -1;

	[ContentSerializer(Optional = true)]
	public int MineMinLevel = -1;

	[ContentSerializer(Optional = true)]
	public int AreaOfEffect;

	[ContentSerializer(Optional = true)]
	public float CritChance = 0.02f;

	[ContentSerializer(Optional = true)]
	public float CritMultiplier = 3f;

	[ContentSerializer(Optional = true)]
	public bool CanBeLostOnDeath = true;

	public string Texture;

	public int SpriteIndex;

	[ContentSerializer(Optional = true)]
	public List<WeaponProjectile> Projectiles;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
