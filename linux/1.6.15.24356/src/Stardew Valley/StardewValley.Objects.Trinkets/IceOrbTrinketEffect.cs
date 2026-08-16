using System;
using System.Globalization;
using Microsoft.Xna.Framework;
using StardewValley.Monsters;
using StardewValley.Projectiles;
using StardewValley.TokenizableStrings;

namespace StardewValley.Objects.Trinkets;

public class IceOrbTrinketEffect(Trinket trinket) : TrinketEffect(trinket)
{
	public const int Range = 600;

	public float ProjectileTimer;

	public float ProjectileDelay = 4000f;

	public int FreezeTime = 4000;

	public override void Apply(Farmer farmer)
	{
		ProjectileTimer = 0f;
		base.Apply(farmer);
	}

	public override bool GenerateRandomStats(Trinket trinket)
	{
		Random random = Utility.CreateRandom(trinket.generationSeed.Value);
		ProjectileDelay = random.Next(3000, 5001);
		FreezeTime = random.Next(2000, 4001);
		if (random.NextDouble() < 0.05)
		{
			trinket.displayNameOverrideTemplate.Value = TokenStringBuilder.LocalizedText("Strings\\1_6_Strings:PerfectIceRod");
			ProjectileDelay = 3000f;
			FreezeTime = 4000;
		}
		trinket.descriptionSubstitutionTemplates.Clear();
		trinket.descriptionSubstitutionTemplates.Add(Math.Round(ProjectileDelay / 1000f, 1).ToString(CultureInfo.InvariantCulture));
		trinket.descriptionSubstitutionTemplates.Add(Math.Round((float)FreezeTime / 1000f, 1).ToString(CultureInfo.InvariantCulture));
		return true;
	}

	public override void Update(Farmer farmer, GameTime time, GameLocation location)
	{
		if (!Game1.shouldTimePass())
		{
			return;
		}
		ProjectileTimer += (float)time.ElapsedGameTime.TotalMilliseconds;
		if (ProjectileTimer >= ProjectileDelay)
		{
			Monster monster = Utility.findClosestMonsterWithinRange(location, farmer.getStandingPosition(), 600);
			if (monster != null)
			{
				Vector2 velocityTowardPoint = Utility.getVelocityTowardPoint(farmer.getStandingPosition(), monster.getStandingPosition(), 5f);
				DebuffingProjectile debuffingProjectile = new DebuffingProjectile("frozen", 17, 0, 0, 0f, velocityTowardPoint.X, velocityTowardPoint.Y, farmer.getStandingPosition() - new Vector2(32f, 48f), location, farmer, hitsMonsters: true, playDefaultSoundOnFire: false);
				debuffingProjectile.wavyMotion.Value = false;
				debuffingProjectile.piercesLeft.Value = 99999;
				debuffingProjectile.maxTravelDistance.Value = 3000;
				debuffingProjectile.IgnoreLocationCollision = true;
				debuffingProjectile.ignoreObjectCollisions.Value = true;
				debuffingProjectile.maxVelocity.Value = 12f;
				debuffingProjectile.projectileID.Value = 15;
				debuffingProjectile.alpha.Value = 0.001f;
				debuffingProjectile.alphaChange.Value = 0.05f;
				debuffingProjectile.light.Value = true;
				debuffingProjectile.debuffIntensity.Value = FreezeTime;
				debuffingProjectile.boundingBoxWidth.Value = 32;
				location.projectiles.Add(debuffingProjectile);
				location.playSound("fireball");
			}
			ProjectileTimer = 0f;
		}
		base.Update(farmer, time, location);
	}
}
