using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;
using StardewValley.Audio;
using StardewValley.Mods;
using StardewValley.Network;
using StardewValley.Pathfinding;
using xTile.Dimensions;

namespace StardewValley;

[NotImplicitNetField]
[XmlInclude(typeof(NPC))]
[XmlInclude(typeof(Farmer))]
[InstanceStatics]
[XmlInclude(typeof(FarmAnimal))]
public class Character : INetObject<NetFields>, IHaveModData
{
	public const float emoteBeginInterval = 20f;

	public const float emoteNormalInterval = 250f;

	public const int emptyCanEmote = 4;

	public const int questionMarkEmote = 8;

	public const int angryEmote = 12;

	public const int exclamationEmote = 16;

	public const int heartEmote = 20;

	public const int sleepEmote = 24;

	public const int sadEmote = 28;

	public const int happyEmote = 32;

	public const int xEmote = 36;

	public const int pauseEmote = 40;

	public const int videoGameEmote = 52;

	public const int musicNoteEmote = 56;

	public const int blushEmote = 60;

	public const int blockedIntervalBeforeEmote = 3000;

	public const int blockedIntervalBeforeSprint = 5000;

	public const double chanceForSound = 0.001;

	private static readonly Vector2 ClearPositionValue;

	private Point cachedStandingPixel;

	private Vector2 cachedTile;

	private Point cachedTilePoint;

	private Vector2 pixelPositionForCachedStandingPixel;

	private Vector2 pixelPositionForCachedTile;

	private Vector2 pixelPositionForCachedTilePoint;

	[XmlIgnore]
	public readonly NetBool hideFromAnimalSocialMenu;

	[XmlIgnore]
	public readonly NetRef<AnimatedSprite> sprite;

	[XmlIgnore]
	public readonly NetPosition position;

	[XmlIgnore]
	private readonly NetInt netSpeed;

	[XmlIgnore]
	private readonly NetFloat netAddedSpeed;

	[XmlIgnore]
	public readonly NetDirection facingDirection;

	[XmlIgnore]
	public int blockedInterval;

	[XmlIgnore]
	public int faceTowardFarmerTimer;

	[XmlIgnore]
	public int forceUpdateTimer;

	[XmlIgnore]
	public int movementPause;

	[XmlIgnore]
	public NetEvent1Field<int, NetInt> faceTowardFarmerEvent;

	[XmlIgnore]
	public readonly NetInt faceTowardFarmerRadius;

	[XmlIgnore]
	public readonly NetBool simpleNonVillagerNPC;

	[XmlIgnore]
	public int nonVillagerNPCTimesTalked;

	[XmlElement("name")]
	public readonly NetString name;

	[XmlElement("forceOneTileWide")]
	public readonly NetBool forceOneTileWide;

	protected bool moveUp;

	protected bool moveRight;

	protected bool moveDown;

	protected bool moveLeft;

	protected bool freezeMotion;

	[XmlIgnore]
	private string _displayName;

	public bool isEmoting;

	public bool isCharging;

	public bool isGlowing;

	public bool coloredBorder;

	public bool flip;

	public bool drawOnTop;

	public bool faceTowardFarmer;

	public bool ignoreMovementAnimation;

	[XmlIgnore]
	public bool hasJustStartedFacingPlayer;

	[XmlElement("faceAwayFromFarmer")]
	public readonly NetBool faceAwayFromFarmer;

	protected int currentEmote;

	protected int currentEmoteFrame;

	protected readonly NetInt facingDirectionBeforeSpeakingToPlayer;

	[XmlIgnore]
	public float emoteInterval;

	[XmlIgnore]
	public float xVelocity;

	[XmlIgnore]
	public float yVelocity;

	[XmlIgnore]
	public Vector2 lastClick;

	public readonly NetFloat scale;

	public float glowingTransparency;

	public float glowRate;

	private bool glowUp;

	[XmlIgnore]
	public readonly NetBool swimming;

	[XmlIgnore]
	public bool nextEventcommandAfterEmote;

	[XmlIgnore]
	public bool farmerPassesThrough;

	[XmlIgnore]
	public NetBool netEventActor;

	[XmlIgnore]
	public readonly NetBool collidesWithOtherCharacters;

	protected bool ignoreMovementAnimations;

	[XmlIgnore]
	public int yJumpOffset;

	[XmlIgnore]
	public int ySourceRectOffset;

	[XmlIgnore]
	public float yJumpVelocity;

	[XmlIgnore]
	public float yJumpGravity;

	[XmlIgnore]
	public bool wasJumpWithSound;

	[XmlIgnore]
	private readonly NetFarmerRef whoToFace;

	[XmlIgnore]
	public Color glowingColor;

	[XmlIgnore]
	public PathFindController controller;

	private bool emoteFading;

	[XmlIgnore]
	private readonly NetBool _willDestroyObjectsUnderfoot;

	[XmlIgnore]
	protected readonly NetLocationRef currentLocationRef;

	private Microsoft.Xna.Framework.Rectangle originalSourceRect;

	protected int emoteYOffset;

	public static readonly Vector2[] AdjacentTilesOffsets;

	[XmlIgnore]
	public Vector2 drawOffset;

	[XmlIgnore]
	public bool shouldShadowBeOffset;

	public virtual Gender Gender
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	public int speed
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
	public virtual float addedSpeed
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
	public virtual string displayName
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
	public virtual bool EventActor
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

	public bool willDestroyObjectsUnderfoot
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

	public Vector2 Position
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

	public Point StandingPixel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector2 Tile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Point TilePoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int Speed
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

	public virtual int FacingDirection
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
	public string Name
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
	public bool SimpleNonVillagerNPC
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
	public virtual AnimatedSprite Sprite
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

	public bool IsEmoting
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

	public int CurrentEmote
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

	public int CurrentEmoteIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual bool IsMonster
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public virtual bool IsVillager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float Scale
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
	public GameLocation currentLocation
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Character()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Character(AnimatedSprite sprite, Vector2 position, int speed, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string translateName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ClearCachedPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void resetCachedDisplayName()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetMovingUp(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetMovingRight(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetMovingDown(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetMovingLeft(bool b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setMovingInFacingDirection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getFacingDirection()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTrajectory(int xVelocity, int yVelocity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setTrajectory(Vector2 trajectory)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Halt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void extendSourceRect(int horizontal, int vertical, bool ignoreSourceRectUpdates = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool collideWith(Object o)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void faceDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getDirection()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRemoteMoving()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tryToMoveInDirection(int direction, bool isFarmer, int damagesFarmer, bool glider)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetShadowOffset()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool shouldCollideWithBuildingLayer(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void applyVelocity(GameLocation currentLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MovePosition(GameTime time, xTile.Dimensions.Rectangle viewport, GameLocation currentLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canPassThroughActionTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Microsoft.Xna.Framework.Rectangle nextPosition(int direction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Location nextPositionPoint()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getHorizontalMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getVerticalMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 nextPositionVector2()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Location nextPositionTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doEmote(int whichEmote, bool playSound, bool nextEventCommand = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doEmote(int whichEmote, bool nextEventCommand = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doEmote(int whichEmote, int emoteYOffset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateEmote(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playNearbySoundLocal(string audioName, int? pitch = null, SoundContext context = SoundContext.Default)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playNearbySoundAll(string audioName, int? pitch = null, SoundContext context = SoundContext.Default)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetGrabTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetDropLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetToolLocation(Vector2 target_position, bool ignoreClick = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetToolLocation(bool ignoreClick = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getGeneralDirectionTowards(Vector2 target, int yBias = 0, bool opposite = false, bool useTileCalculations = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void faceGeneralDirection(Vector2 target, int yBias, bool opposite, bool useTileCalculations)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void faceGeneralDirection(Vector2 target, int yBias = 0, bool opposite = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, int ySourceRectOffset, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSpriteWidthForPositioning()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Microsoft.Xna.Framework.Rectangle GetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void stopWithoutChangingFrame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void collisionWithFarmerBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getStandingPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 getLocalPosition(xTile.Dimensions.Rectangle viewport)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isMoving()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTileX()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTileY()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getTileLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTileLocation(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startGlowing(Color glowingColor, bool border, float glowRate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void stopGlowing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void jumpWithoutSound(float velocity = 8f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void jump()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void jump(float jumpVelocity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void faceTowardFarmerForPeriod(int milliseconds, int radius, bool faceAway, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void performFaceTowardFarmerEvent(int milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLocationRemoved()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForFootstep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void update(GameTime time, GameLocation location, long id, bool move)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateFaceTowardsFarmer(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool hasSpecialCollisionRules()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isColliding(GameLocation l, Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void animateInFacingDirection(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateMovement(GameLocation location, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void updateSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateGlow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void convertEventMotionCommandToMovement(Vector2 command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawShadow(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetLocationNextToWhereYoureFacing(int offset = 64)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
