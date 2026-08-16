using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Weapons;

public class WeaponProjectile
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public int Damage = 10;

	[ContentSerializer(Optional = true)]
	public bool Explodes;

	[ContentSerializer(Optional = true)]
	public int Bounces;

	[ContentSerializer(Optional = true)]
	public int MaxDistance = 4;

	[ContentSerializer(Optional = true)]
	public int Velocity = 10;

	[ContentSerializer(Optional = true)]
	public int RotationVelocity = 32;

	[ContentSerializer(Optional = true)]
	public int TailLength = 1;

	[ContentSerializer(Optional = true)]
	public string FireSound = "";

	[ContentSerializer(Optional = true)]
	public string BounceSound = "";

	[ContentSerializer(Optional = true)]
	public string CollisionSound = "";

	[ContentSerializer(Optional = true)]
	public float MinAngleOffset;

	[ContentSerializer(Optional = true)]
	public float MaxAngleOffset;

	[ContentSerializer(Optional = true)]
	public int SpriteIndex = 11;

	[ContentSerializer(Optional = true)]
	public GenericSpawnItemData Item;
}
