using System;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.BellsAndWhistles;
using StardewValley.Extensions;
using StardewValley.Monsters;
using StardewValley.TerrainFeatures;
using StardewValley.TokenizableStrings;

namespace StardewValley.Projectiles;

public class BasicProjectile : Projectile
{
	public delegate void onCollisionBehavior(GameLocation location, int xPosition, int yPosition, Character who);

	public readonly NetInt damageToFarmer = new NetInt();

	public readonly NetString collisionSound = new NetString();

	public readonly NetBool explode = new NetBool();

	public onCollisionBehavior collisionBehavior;

	public NetString debuff = new NetString(null);

	public NetString debuffSound = new NetString("debuffHit");

	public BasicProjectile()
	{
	}

	public BasicProjectile(int damageToFarmer, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition, string collisionSound = null, string bounceSound = null, string firingSound = null, bool explode = false, bool damagesMonsters = false, GameLocation location = null, Character firer = null, onCollisionBehavior collisionBehavior = null, string shotItemId = null)
		: this()
	{
		this.damageToFarmer.Value = damageToFarmer;
		currentTileSheetIndex.Value = spriteIndex;
		bouncesLeft.Value = bouncesTillDestruct;
		base.tailLength.Value = tailLength;
		base.rotationVelocity.Value = rotationVelocity;
		base.xVelocity.Value = xVelocity;
		base.yVelocity.Value = yVelocity;
		position.Value = startingPosition;
		this.explode.Value = explode;
		this.collisionSound.Value = collisionSound;
		base.bounceSound.Value = bounceSound;
		base.damagesMonsters.Value = damagesMonsters;
		theOneWhoFiredMe.Set(location, firer);
		this.collisionBehavior = collisionBehavior;
		itemId.Value = ItemRegistry.QualifyItemId(shotItemId) ?? shotItemId;
		if (!string.IsNullOrEmpty(firingSound))
		{
			location?.playSound(firingSound);
		}
	}

	public BasicProjectile(int damageToFarmer, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition)
		: this(damageToFarmer, spriteIndex, bouncesTillDestruct, tailLength, rotationVelocity, xVelocity, yVelocity, startingPosition, "flameSpellHit", "flameSpell", null, explode: true)
	{
	}

	public override void updatePosition(GameTime time)
	{
		xVelocity.Value += acceleration.X;
		yVelocity.Value += acceleration.Y;
		if (maxVelocity.Value != -1f && Math.Sqrt(xVelocity.Value * xVelocity.Value + yVelocity.Value * yVelocity.Value) >= (double)maxVelocity.Value)
		{
			xVelocity.Value -= acceleration.X;
			yVelocity.Value -= acceleration.Y;
		}
		position.X += xVelocity.Value;
		position.Y += yVelocity.Value;
	}

	protected override void InitNetFields()
	{
		base.InitNetFields();
		base.NetFields.AddField(damageToFarmer, "damageToFarmer").AddField(collisionSound, "collisionSound").AddField(explode, "explode")
			.AddField(debuff, "debuff")
			.AddField(debuffSound, "debuffSound");
	}

	public override void behaviorOnCollisionWithPlayer(GameLocation location, Farmer player)
	{
		if (damagesMonsters.Value)
		{
			return;
		}
		if (debuff.Value != null && player.CanBeDamaged() && Game1.random.Next(11) >= player.Immunity && !player.hasBuff("28") && !player.hasTrinketWithID("BasiliskPaw"))
		{
			if (Game1.player == player)
			{
				player.applyBuff(debuff.Value);
			}
			location.playSound(debuffSound.Value);
		}
		if (player.CanBeDamaged())
		{
			piercesLeft.Value--;
		}
		player.takeDamage(damageToFarmer.Value, overrideParry: false, null);
		explosionAnimation(location);
	}

	public override void behaviorOnCollisionWithTerrainFeature(TerrainFeature t, Vector2 tileLocation, GameLocation location)
	{
		t.performUseAction(tileLocation);
		explosionAnimation(location);
		piercesLeft.Value--;
	}

	public override void behaviorOnCollisionWithOther(GameLocation location)
	{
		if (!ignoreObjectCollisions.Value)
		{
			explosionAnimation(location);
			piercesLeft.Value--;
		}
	}

	public override void behaviorOnCollisionWithMonster(NPC n, GameLocation location)
	{
		if (!damagesMonsters.Value)
		{
			return;
		}
		Farmer playerWhoFiredMe = GetPlayerWhoFiredMe(location);
		explosionAnimation(location);
		if (n is Monster)
		{
			location.damageMonster(n.GetBoundingBox(), damageToFarmer.Value, damageToFarmer.Value + 1, isBomb: false, playerWhoFiredMe, isProjectile: true);
			if (currentTileSheetIndex.Value == 15)
			{
				Utility.addRainbowStarExplosion(location, position.Value, 11);
			}
			if (!(n as Monster).IsInvisible)
			{
				piercesLeft.Value--;
			}
		}
		else if (itemId.Value != null)
		{
			n.getHitByPlayer(playerWhoFiredMe, location);
			string word = TokenStringBuilder.ItemName(itemId.Value);
			Game1.multiplayer.globalChatInfoMessage("Slingshot_Hit", playerWhoFiredMe.Name, n.GetTokenizedDisplayName(), Lexicon.prependTokenizedArticle(word));
			piercesLeft.Value--;
		}
	}

	protected virtual void explosionAnimation(GameLocation location)
	{
		if (projectileID.Value == 14)
		{
			for (int i = 0; i < 12; i++)
			{
				Vector2 vector = new Vector2(0f, -1.5f + (float)Game1.random.Next(-10, 11) / 12f);
				vector = Vector2.Transform(vector, Matrix.CreateRotationZ((float)(Math.PI / 6.0 + (double)((float)Game1.random.Next(-10, 11) / 50f)) * (float)i));
				location.temporarySprites.Add(new TemporaryAnimatedSprite("LooseSprites\\Cursors_1_6", new Rectangle(144, 249, 7, 7), 80f, 6, 1, position.Value + new Vector2(8f, 8f) * 4f, flicker: false, flipped: false, 1f, 0f, Utility.Get2PhaseColor(Color.White, Color.Cyan, 0, 1f, Game1.random.Next(1000)), 4f, 0f, 0f, 0f)
				{
					drawAboveAlwaysFront = true,
					motion = vector
				});
			}
		}
		else
		{
			Rectangle sourceRect = GetSourceRect();
			sourceRect.X += 4;
			sourceRect.Y += 4;
			sourceRect.Width = 8;
			sourceRect.Height = 8;
			if (itemId.Value != null)
			{
				int debrisType = 12;
				switch (itemId.Value)
				{
				case "(O)390":
					debrisType = 14;
					break;
				case "(O)378":
					debrisType = 0;
					break;
				case "(O)380":
					debrisType = 2;
					break;
				case "(O)384":
					debrisType = 6;
					break;
				case "(O)386":
					debrisType = 10;
					break;
				case "(O)382":
					debrisType = 4;
					break;
				}
				Game1.createRadialDebris(location, debrisType, (int)(position.X + 32f) / 64, (int)(position.Y + 32f) / 64, 6, resource: false);
			}
			else
			{
				Game1.createRadialDebris_MoreNatural(location, "TileSheets\\Projectiles", sourceRect, 1, (int)position.X + 32, (int)position.Y + 32, 6, (int)(position.Y / 64f) + 1);
			}
		}
		if (!string.IsNullOrEmpty(collisionSound.Value))
		{
			location.playSound(collisionSound.Value);
		}
		if (explode.Value)
		{
			Game1.multiplayer.broadcastSprites(location, new TemporaryAnimatedSprite(362, Game1.random.Next(30, 90), 6, 1, position.Value, flicker: false, Game1.random.NextBool()));
		}
		collisionBehavior?.Invoke(location, getBoundingBox().Center.X, getBoundingBox().Center.Y, GetPlayerWhoFiredMe(location));
		destroyMe = true;
	}

	public static void explodeOnImpact(GameLocation location, int x, int y, Character who)
	{
		location.explode(new Vector2(x / 64, y / 64), 2, who as Farmer);
	}

	public virtual Farmer GetPlayerWhoFiredMe(GameLocation location)
	{
		return (theOneWhoFiredMe.Get(location) as Farmer) ?? Game1.player;
	}
}
