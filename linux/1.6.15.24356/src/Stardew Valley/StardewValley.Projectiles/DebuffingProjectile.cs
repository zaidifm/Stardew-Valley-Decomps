using System;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Monsters;
using StardewValley.TerrainFeatures;

namespace StardewValley.Projectiles;

public class DebuffingProjectile : Projectile
{
	public readonly NetString debuff = new NetString();

	public NetBool wavyMotion = new NetBool(value: true);

	public NetInt debuffIntensity = new NetInt(-1);

	private float periodicEffectTimer;

	public DebuffingProjectile()
	{
	}

	public DebuffingProjectile(string debuff, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition, GameLocation location = null, Character owner = null, bool hitsMonsters = false, bool playDefaultSoundOnFire = true)
		: this()
	{
		theOneWhoFiredMe.Set(location, owner);
		this.debuff.Value = debuff;
		currentTileSheetIndex.Value = spriteIndex;
		bouncesLeft.Value = bouncesTillDestruct;
		base.tailLength.Value = tailLength;
		base.rotationVelocity.Value = rotationVelocity;
		base.xVelocity.Value = xVelocity;
		base.yVelocity.Value = yVelocity;
		position.Value = startingPosition;
		damagesMonsters.Value = hitsMonsters;
		if (playDefaultSoundOnFire)
		{
			if (location == null)
			{
				Game1.playSound("debuffSpell");
			}
			else
			{
				location.playSound("debuffSpell");
			}
		}
	}

	protected override void InitNetFields()
	{
		base.InitNetFields();
		base.NetFields.AddField(debuff, "debuff").AddField(wavyMotion, "wavyMotion").AddField(debuffIntensity, "debuffIntensity");
	}

	public override void updatePosition(GameTime time)
	{
		xVelocity.Value += acceleration.X;
		yVelocity.Value += acceleration.Y;
		position.X += xVelocity.Value;
		position.Y += yVelocity.Value;
		if (wavyMotion.Value)
		{
			position.X += (float)Math.Sin((double)time.TotalGameTime.Milliseconds * Math.PI / 128.0) * 8f;
			position.Y += (float)Math.Cos((double)time.TotalGameTime.Milliseconds * Math.PI / 128.0) * 8f;
		}
	}

	public override bool update(GameTime time, GameLocation location)
	{
		if (debuff.Value == "frozen")
		{
			periodicEffectTimer += (float)time.ElapsedGameTime.TotalMilliseconds;
			if (periodicEffectTimer > 50f)
			{
				periodicEffectTimer = 0f;
				location.temporarySprites.Add(new TemporaryAnimatedSprite("TileSheets\\Projectiles", new Rectangle(32, 32, 16, 16), 9999f, 1, 1, position.Value, flicker: false, flipped: false, 1f, 0.01f, Color.White, 4f, 0f, 0f, 0f)
				{
					motion = Utility.getRandom360degreeVector(1f) + new Vector2(xVelocity.Value, yVelocity.Value),
					drawAboveAlwaysFront = true
				});
			}
		}
		return base.update(time, location);
	}

	public override void behaviorOnCollisionWithPlayer(GameLocation location, Farmer player)
	{
		if (!damagesMonsters.Value && Game1.random.Next(11) >= player.Immunity && !player.hasBuff("28") && !player.hasTrinketWithID("BasiliskPaw"))
		{
			piercesLeft.Value--;
			if (Game1.player == player)
			{
				player.applyBuff(debuff.Value);
			}
			explosionAnimation(location);
			if (debuff.Value == "19")
			{
				location.playSound("frozen");
			}
			else
			{
				location.playSound("debuffHit");
			}
		}
	}

	public override void behaviorOnCollisionWithTerrainFeature(TerrainFeature t, Vector2 tileLocation, GameLocation location)
	{
		explosionAnimation(location);
		piercesLeft.Value--;
	}

	public override void behaviorOnCollisionWithOther(GameLocation location)
	{
		explosionAnimation(location);
		piercesLeft.Value--;
	}

	protected virtual void explosionAnimation(GameLocation location)
	{
		if (!(debuff.Value == "frozen"))
		{
			Game1.multiplayer.broadcastSprites(location, new TemporaryAnimatedSprite(352, Game1.random.Next(100, 150), 2, 1, position.Value, flicker: false, flipped: false));
		}
	}

	public override void behaviorOnCollisionWithMonster(NPC n, GameLocation location)
	{
		if (damagesMonsters.Value && n is Monster && debuff.Value == "frozen" && (!(n is Leaper leaper) || !leaper.leaping.Value))
		{
			if ((n as Monster).stunTime.Value < 51)
			{
				piercesLeft.Value--;
			}
			if ((n as Monster).stunTime.Value < debuffIntensity.Value - 1000)
			{
				location.playSound("frozen");
				Game1.multiplayer.broadcastSprites(location, new TemporaryAnimatedSprite("LooseSprites\\Cursors2", new Rectangle(118, 227, 16, 13), new Vector2(0f, 0f), flipped: false, 0f, Color.White)
				{
					layerDepth = (float)(n.StandingPixel.Y + 2) / 10000f,
					animationLength = 1,
					interval = debuffIntensity.Value,
					scale = 4f,
					id = (int)(n.position.X * 777f + n.position.Y * 77777f),
					positionFollowsAttachedCharacter = true,
					attachedCharacter = n
				});
			}
			(n as Monster).stunTime.Value = debuffIntensity.Value;
		}
	}
}
