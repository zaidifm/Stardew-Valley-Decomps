using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Mods;
using StardewValley.Network;
using StardewValley.TerrainFeatures;

namespace StardewValley.Projectiles;

public abstract class Projectile : INetObject<NetFields>, IHaveModData
{
	public const int travelTimeBeforeCollisionPossible = 100;

	public const int goblinsCurseIndex = 0;

	public const int flameBallIndex = 1;

	public const int fearBolt = 2;

	public const int shadowBall = 3;

	public const int bone = 4;

	public const int throwingKnife = 5;

	public const int snowBall = 6;

	public const int shamanBolt = 7;

	public const int frostBall = 8;

	public const int frozenBolt = 9;

	public const int fireball = 10;

	public const int slash = 11;

	public const int arrowBolt = 12;

	public const int launchedSlime = 13;

	public const int magicArrow = 14;

	public const int iceOrb = 15;

	public const string projectileSheetName = "TileSheets\\Projectiles";

	public const int timePerTailUpdate = 50;

	public readonly NetInt boundingBoxWidth;

	public static Texture2D projectileSheet;

	protected float startingAlpha;

	[XmlIgnore]
	public readonly NetInt currentTileSheetIndex;

	[XmlIgnore]
	public readonly NetString itemId;

	[XmlIgnore]
	public readonly NetPosition position;

	[XmlIgnore]
	public readonly NetInt tailLength;

	[XmlIgnore]
	public int tailCounter;

	public readonly NetString bounceSound;

	[XmlIgnore]
	public readonly NetInt bouncesLeft;

	public readonly NetInt piercesLeft;

	public int travelTime;

	protected float? _rotation;

	[XmlIgnore]
	public float hostTimeUntilAttackable;

	public readonly NetFloat startingRotation;

	[XmlIgnore]
	public readonly NetFloat rotationVelocity;

	public readonly NetFloat alpha;

	public readonly NetFloat alphaChange;

	[XmlIgnore]
	public readonly NetFloat xVelocity;

	[XmlIgnore]
	public readonly NetFloat yVelocity;

	public readonly NetVector2 acceleration;

	public readonly NetFloat maxVelocity;

	public readonly NetColor color;

	[XmlIgnore]
	public Queue<Vector2> tail;

	public readonly NetInt maxTravelDistance;

	public float travelDistance;

	public readonly NetInt projectileID;

	public readonly NetInt uniqueID;

	public NetFloat height;

	[XmlIgnore]
	public readonly NetBool damagesMonsters;

	[XmlIgnore]
	public readonly NetCharacterRef theOneWhoFiredMe;

	public readonly NetBool ignoreTravelGracePeriod;

	public readonly NetBool ignoreLocationCollision;

	public readonly NetBool ignoreObjectCollisions;

	public readonly NetBool ignoreMeleeAttacks;

	public readonly NetBool ignoreCharacterCollisions;

	public bool destroyMe;

	public readonly NetFloat startingScale;

	protected float? _localScale;

	public readonly NetFloat scaleGrow;

	public NetBool light;

	public bool hasLit;

	[XmlIgnore]
	public string lightSourceId;

	protected float rotation
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

	public bool IgnoreLocationCollision
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
	public ModDataDictionary modData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlElement("modData")]
	public ModDataDictionary modDataForSerialization
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

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public virtual float localScale
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Projectile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void behaviorOnCollision(GameLocation location, Character target, TerrainFeature terrainFeature)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void behaviorOnCollisionWithPlayer(GameLocation location, Farmer player);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void behaviorOnCollisionWithTerrainFeature(TerrainFeature t, Vector2 tileLocation, GameLocation location);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void behaviorOnCollisionWithOther(GameLocation location);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void behaviorOnCollisionWithMonster(NPC n, GameLocation location);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool update(GameTime time, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool ShouldApplyCollisionLocally(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void updateTail(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isColliding(GameLocation location, out Character target, out TerrainFeature terrainFeature)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void updatePosition(GameTime time);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle getBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Texture2D GetTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle GetSourceRect()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
