using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using xTile.Dimensions;

namespace StardewValley.Monsters;

[XmlInclude(typeof(Leaper))]
[XmlInclude(typeof(MetalHead))]
[XmlInclude(typeof(Mummy))]
[XmlInclude(typeof(RockCrab))]
[XmlInclude(typeof(RockGolem))]
[XmlInclude(typeof(Serpent))]
[XmlInclude(typeof(SquidKid))]
[XmlInclude(typeof(ShadowGirl))]
[XmlInclude(typeof(ShadowGuy))]
[XmlInclude(typeof(ShadowShaman))]
[XmlInclude(typeof(Skeleton))]
[XmlInclude(typeof(Spiker))]
[XmlInclude(typeof(LavaLurk))]
[XmlInclude(typeof(ShadowBrute))]
[XmlInclude(typeof(HotHead))]
[XmlInclude(typeof(Shooter))]
[XmlInclude(typeof(GreenSlime))]
[XmlInclude(typeof(Grub))]
[XmlInclude(typeof(Bat))]
[XmlInclude(typeof(BigSlime))]
[XmlInclude(typeof(BlueSquid))]
[XmlInclude(typeof(AngryRoger))]
[XmlInclude(typeof(DinoMonster))]
[XmlInclude(typeof(Duggy))]
[XmlInclude(typeof(DustSpirit))]
[XmlInclude(typeof(DwarvishSentry))]
[XmlInclude(typeof(Bug))]
[XmlInclude(typeof(Fly))]
[XmlInclude(typeof(Ghost))]
public class Monster : NPC
{
	public delegate void collisionBehavior(GameLocation location);

	public const int index_health = 0;

	public const int index_damageToFarmer = 1;

	public const int index_isGlider = 4;

	public const int index_drops = 6;

	public const int index_resilience = 7;

	public const int index_jitteriness = 8;

	public const int index_distanceThresholdToMoveTowardsPlayer = 9;

	public const int index_speed = 10;

	public const int index_missChance = 11;

	public const int index_isMineMonster = 12;

	public const int index_experiencePoints = 13;

	public const int index_displayName = 14;

	public const int defaultInvincibleCountdown = 450;

	public float timeBeforeAIMovementAgain;

	[XmlElement("damageToFarmer")]
	public readonly NetInt damageToFarmer;

	[XmlElement("health")]
	public readonly NetIntDelta health;

	[XmlElement("maxHealth")]
	public readonly NetInt maxHealth;

	[XmlElement("resilience")]
	public readonly NetInt resilience;

	[XmlElement("slipperiness")]
	public readonly NetInt slipperiness;

	[XmlElement("experienceGained")]
	public readonly NetInt experienceGained;

	[XmlElement("jitteriness")]
	public readonly NetDouble jitteriness;

	[XmlElement("missChance")]
	public readonly NetDouble missChance;

	[XmlElement("isGlider")]
	public readonly NetBool isGlider;

	[XmlElement("mineMonster")]
	public readonly NetBool mineMonster;

	[XmlElement("hasSpecialItem")]
	public readonly NetBool hasSpecialItem;

	[XmlIgnore]
	public readonly NetFloat synchedRotation;

	[XmlArrayItem("int")]
	public readonly NetStringList objectsToDrop;

	[XmlIgnore]
	public int skipHorizontal;

	[XmlIgnore]
	public int invincibleCountdown;

	[XmlIgnore]
	public readonly NetInt defaultAnimationInterval;

	public readonly NetInt stunTime;

	[XmlElement("initializedForLocation")]
	public bool initializedForLocation;

	[XmlIgnore]
	public readonly NetBool netFocusedOnFarmers;

	[XmlIgnore]
	public readonly NetBool netWildernessFarmMonster;

	private readonly NetEvent1<ParryEventArgs> parryEvent;

	private readonly NetEvent1Field<Vector2, NetVector2> trajectoryEvent;

	[XmlIgnore]
	private readonly NetEvent0 deathAnimEvent;

	[XmlElement("ignoreDamageLOS")]
	public readonly NetBool ignoreDamageLOS;

	[XmlIgnore]
	public collisionBehavior onCollision;

	[XmlElement("isHardModeMonster")]
	public NetBool isHardModeMonster;

	private int slideAnimationTimer;

	[XmlIgnore]
	public Farmer Player
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int DamageToFarmer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlIgnore]
	public int Health
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlIgnore]
	public int MaxHealth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlIgnore]
	public int ExperienceGained
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlIgnore]
	public int Slipperiness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlIgnore]
	public bool focusedOnFarmers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlIgnore]
	public bool wildernessFarmMonster
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public override bool IsMonster
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public override bool IsVillager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monster()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monster(string name, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Farmer findPlayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual double findPlayerPriority(Farmer f)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDealContactDamage(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<Item> getExtraDropItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool withinPlayerThreshold()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monster(string name, Vector2 position, int facingDir)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldMonsterBeRemoved()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawAboveAllLayers(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isInvincible()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setInvincibleCountdown(int time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected int maxTimesReachedMineBottom()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Debris ModifyMonsterLoot(Debris debris)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetBaseDifficultyLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BuffForAdditionalDifficulty(int additional_difficulty)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void parseMonsterInfo(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new static string GetDisplayName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeForLocation(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChooseAppearance(LocalizedContentManager content = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void shedChunks(int number)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void shedChunks(int number, float scale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void deathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void sharedDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void localDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void parried(int damage, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void handleParried(ParryEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, string hitSound)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setTrajectory(Vector2 trajectory)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doSetTrajectory(Vector2 trajectory)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void behaviorAtGameTick(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldCollideWithBuildingLayer(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void resetAnimationSpeed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void updateAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void updateMonsterSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldActuallyMoveAwayFromPlayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkHorizontalMovement(ref bool success, ref bool setMoving, ref bool scootSuccess, Farmer who, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkVerticalMovement(ref bool success, ref bool setMoving, ref bool scootSuccess, Farmer who, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateMovement(GameLocation location, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void noMovementProgressNearPlayerBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void defaultMovementBehavior(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TakesDamageFromHitbox(Microsoft.Xna.Framework.Rectangle area_of_effect)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OverlapsFarmerForDamage(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Halt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MovePosition(GameTime time, xTile.Dimensions.Rectangle viewport, GameLocation currentLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string GenerateLightSourceId(int identifier)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
