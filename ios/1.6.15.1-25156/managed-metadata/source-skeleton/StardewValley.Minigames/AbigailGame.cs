using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Netcode;
using StardewValley.Menus;

namespace StardewValley.Minigames;

[XmlInclude(typeof(JOTPKProgress))]
[InstanceStatics]
public class AbigailGame : IMinigame
{
	public delegate void behaviorAfterMotionPause();

	public enum GameKeys
	{
		MoveLeft,
		MoveRight,
		MoveUp,
		MoveDown,
		ShootLeft,
		ShootRight,
		ShootUp,
		ShootDown,
		UsePowerup,
		SelectOption,
		Exit,
		MAX
	}

	public class CowboyPowerup
	{
		public int which;

		public Point position;

		public int duration;

		public float yOffset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CowboyPowerup(int which, Point position, int duration)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void draw(SpriteBatch b)
		{
		}
	}

	public class JOTPKProgress : INetObject<NetFields>
	{
		public NetInt bulletDamage;

		public NetInt fireSpeedLevel;

		public NetInt ammoLevel;

		public NetBool spreadPistol;

		public NetInt runSpeedLevel;

		public NetInt lives;

		public NetInt coins;

		public NetInt score;

		public NetBool died;

		public NetInt whichRound;

		public NetInt whichWave;

		public NetInt heldItem;

		public NetInt world;

		public NetInt waveTimer;

		public NetList<Vector2, NetVector2> monsterChances;

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
		public JOTPKProgress()
		{
		}
	}

	public class CowboyBullet
	{
		public Point position;

		public Point motion;

		public int damage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CowboyBullet(Point position, Point motion, int damage)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CowboyBullet(Point position, int direction, int damage)
		{
		}
	}

	public class CowboyMonster
	{
		public const int MonsterAnimationDelay = 500;

		public int health;

		public int type;

		public int speed;

		public float movementAnimationTimer;

		public Rectangle position;

		public int movementDirection;

		public bool movedLastTurn;

		public bool oppositeMotionGuy;

		public bool invisible;

		public bool special;

		public bool uninterested;

		public bool flyer;

		public Color tint;

		public Color flashColor;

		public float flashColorTimer;

		public int ticksSinceLastMovement;

		public Vector2 acceleration;

		private Point targetPosition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CowboyMonster(int which, int health, int speed, Point position)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CowboyMonster(int which, Point position)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool takeDamage(int damage)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int getLootDrop()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool move(Vector2 playerPosition, GameTime time)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void spikeyEndBehavior(int extraInfo)
		{
		}
	}

	public class Dracula : CowboyMonster
	{
		public const int gloatingPhase = -1;

		public const int walkRandomlyAndShootPhase = 0;

		public const int spreadShotPhase = 1;

		public const int summonDemonPhase = 2;

		public const int summonMummyPhase = 3;

		public int phase;

		public int phaseInternalTimer;

		public int phaseInternalCounter;

		public int shootTimer;

		public int fullHealth;

		public Point homePosition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dracula()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int getLootDrop()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool takeDamage(int damage)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool move(Vector2 playerPosition, GameTime time)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void fireSpread(Point origin, double offsetAngle)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void summonEnemies(Point origin, int which)
		{
		}
	}

	public class Outlaw : CowboyMonster
	{
		public const int talkingPhase = -1;

		public const int hidingPhase = 0;

		public const int dartOutAndShootPhase = 1;

		public const int runAndGunPhase = 2;

		public const int runGunAndPantPhase = 3;

		public const int shootAtPlayerPhase = 4;

		public int phase;

		public int phaseCountdown;

		public int shootTimer;

		public int phaseInternalTimer;

		public int phaseInternalCounter;

		public bool dartLeft;

		public int fullHealth;

		public Point homePosition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Outlaw(Point position, int health)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool move(Vector2 playerPosition, GameTime time)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int getLootDrop()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool takeDamage(int damage)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private const int joystickPixelScale = 4;

	public ClickableTextureComponent leftJoystick;

	public ClickableTextureComponent rightJoystick;

	public ClickableTextureComponent upperRightCloseButton;

	public ClickableComponent buttonRestart;

	public ClickableComponent buttonQuit;

	public ClickableComponent buttonPowerup;

	private int _maxJoystickMoveDistance;

	private const int MAX_JOYSTICK_HITAREA_RADIUS = 350;

	private const int MIN_JOYSTICK_MOVE_THRESHOLD = 5;

	private bool _lastLeftJoystickHeld;

	private bool _lastRightJoystickHeld;

	private bool _leftJoystickHeld;

	private bool _rightJoystickHeld;

	private Vector2 _joystickLeftStartPosition;

	private Vector2 _joystickRightStartPosition;

	private Vector2 _joystickLeftTapStartPoint;

	private Vector2 _joystickRightTapStartPoint;

	private Vector2 _joystickLeftTapPoint;

	private Vector2 _joystickRightTapPoint;

	private Vector2 _joystickLeftLastTapPoint;

	private Vector2 _joystickRightLastTapPoint;

	public const int mapWidth = 16;

	public const int mapHeight = 16;

	public const int pixelZoom = 3;

	public const int bulletSpeed = 8;

	public const double lootChance = 0.05;

	public const double coinChance = 0.05;

	public int lootDuration;

	public int powerupDuration;

	public const int abigailPortraitDuration = 6000;

	public const float playerSpeed = 3f;

	public const int baseTileSize = 16;

	public const int orcSpeed = 2;

	public const int ogreSpeed = 1;

	public const int ghostSpeed = 3;

	public const int spikeySpeed = 3;

	public const int spikeyHealth = 2;

	public const int cactusDanceDelay = 800;

	public const int playerMotionDelay = 100;

	public const int playerFootStepDelay = 200;

	public const int deathDelay = 3000;

	public const int MAP_BARRIER1 = 0;

	public const int MAP_BARRIER2 = 1;

	public const int MAP_ROCKY1 = 2;

	public const int MAP_DESERT = 3;

	public const int MAP_GRASSY = 4;

	public const int MAP_CACTUS = 5;

	public const int MAP_FENCE = 7;

	public const int MAP_TRENCH1 = 8;

	public const int MAP_TRENCH2 = 9;

	public const int MAP_BRIDGE = 10;

	public const int orc = 0;

	public const int ghost = 1;

	public const int ogre = 2;

	public const int mummy = 3;

	public const int devil = 4;

	public const int mushroom = 5;

	public const int spikey = 6;

	public const int dracula = 7;

	public const int desert = 0;

	public const int woods = 2;

	public const int graveyard = 1;

	public const int POWERUP_LOG = -1;

	public const int POWERUP_SKULL = -2;

	public const int coin1 = 0;

	public const int coin5 = 1;

	public const int POWERUP_SPREAD = 2;

	public const int POWERUP_RAPIDFIRE = 3;

	public const int POWERUP_NUKE = 4;

	public const int POWERUP_ZOMBIE = 5;

	public const int POWERUP_SPEED = 6;

	public const int POWERUP_SHOTGUN = 7;

	public const int POWERUP_LIFE = 8;

	public const int POWERUP_TELEPORT = 9;

	public const int POWERUP_SHERRIFF = 10;

	public const int POWERUP_HEART = -3;

	public const int ITEM_FIRESPEED1 = 0;

	public const int ITEM_FIRESPEED2 = 1;

	public const int ITEM_FIRESPEED3 = 2;

	public const int ITEM_RUNSPEED1 = 3;

	public const int ITEM_RUNSPEED2 = 4;

	public const int ITEM_LIFE = 5;

	public const int ITEM_AMMO1 = 6;

	public const int ITEM_AMMO2 = 7;

	public const int ITEM_AMMO3 = 8;

	public const int ITEM_SPREADPISTOL = 9;

	public const int ITEM_STAR = 10;

	public const int ITEM_SKULL = 11;

	public const int ITEM_LOG = 12;

	public const int option_retry = 0;

	public const int option_quit = 1;

	public int runSpeedLevel;

	public int fireSpeedLevel;

	public int ammoLevel;

	public int whichRound;

	public bool spreadPistol;

	public const int waveDuration = 80000;

	public const int betweenWaveDuration = 5000;

	public static List<CowboyMonster> monsters;

	protected HashSet<Vector2> _borderTiles;

	public Vector2 playerPosition;

	public static Vector2 player2Position;

	public Rectangle playerBoundingBox;

	public Rectangle merchantBox;

	public Rectangle player2BoundingBox;

	public Rectangle noPickUpBox;

	public static List<int> playerMovementDirections;

	public static List<int> playerShootingDirections;

	public List<int> player2MovementDirections;

	public List<int> player2ShootingDirections;

	public int shootingDelay;

	public int shotTimer;

	public int motionPause;

	public int bulletDamage;

	public int lives;

	public int coins;

	public int score;

	public int player2deathtimer;

	public int player2invincibletimer;

	public List<CowboyBullet> bullets;

	public static List<CowboyBullet> enemyBullets;

	public static int[,] map;

	public static int[,] nextMap;

	public List<Point>[] spawnQueue;

	public static Vector2 topLeftScreenCoordinate;

	public float cactusDanceTimer;

	public float playerMotionAnimationTimer;

	public float playerFootstepSoundTimer;

	public behaviorAfterMotionPause behaviorAfterPause;

	public List<Vector2> monsterChances;

	public Rectangle shoppingCarpetNoPickup;

	public Dictionary<int, int> activePowerups;

	public NPC abigail;

	public static List<CowboyPowerup> powerups;

	public string AbigailDialogue;

	public static TemporaryAnimatedSpriteList temporarySprites;

	public CowboyPowerup heldItem;

	public static int world;

	public int gameOverOption;

	public int gamerestartTimer;

	public int player2TargetUpdateTimer;

	public int player2shotTimer;

	public int player2AnimationTimer;

	public int fadethenQuitTimer;

	public int abigailPortraitYposition;

	public int abigailPortraitTimer;

	public int abigailPortraitExpression;

	public static int waveTimer;

	public static int betweenWaveTimer;

	public static int whichWave;

	public static int monsterConfusionTimer;

	public static int zombieModeTimer;

	public static int shoppingTimer;

	public static int holdItemTimer;

	public static int itemToHold;

	public static int newMapPosition;

	public static int playerInvincibleTimer;

	public static int screenFlash;

	public static int gopherTrainPosition;

	public static int endCutsceneTimer;

	public static int endCutscenePhase;

	public static int startTimer;

	public static float deathTimer;

	public static bool onStartMenu;

	public static bool shopping;

	public static bool gopherRunning;

	public static bool store;

	public static bool merchantLeaving;

	public static bool merchantArriving;

	public static bool merchantShopOpen;

	public static bool waitingForPlayerToMoveDownAMap;

	public static bool scrollingMap;

	public static bool hasGopherAppeared;

	public static bool shootoutLevel;

	public static bool gopherTrain;

	public static bool playerJumped;

	public static bool endCutscene;

	public static bool gameOver;

	public static bool playingWithAbigail;

	public static bool beatLevelWithAbigail;

	public Dictionary<Rectangle, int> storeItems;

	public bool quit;

	public bool died;

	public static Rectangle gopherBox;

	public Point gopherMotion;

	internal static ICue overworldSong;

	internal static ICue outlawSong;

	internal static ICue zombieSong;

	protected Dictionary<GameKeys, List<Keys>> _binds;

	protected HashSet<GameKeys> _buttonHeldState;

	protected Dictionary<GameKeys, int> _buttonHeldFrames;

	private int player2FootstepSoundTimer;

	public CowboyMonster targetMonster;

	public static int TileSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LoadGame()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveGame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbigailGame(NPC abigail = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbigailGame(int coins, int ammoLevel, int bulletDamage, int fireSpeedLevel, int runSpeedLevel, int lives, bool spreadPistol, int whichRound)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyNewGamePlus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reset(bool playingWithAbby)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float getMovementSpeed(float speed, int directions)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool getPowerUp(CowboyPowerup c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool overrideFreeMouseMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void usePowerup(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addGuts(Point position, int whichGuts)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void endOfGopherAnimationBehavior2(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void endOfGopherAnimationBehavior(int extrainfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateBullets(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playerDie()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void afterPlayerDeathFunction(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startAbigailPortrait(int whichExpression, string sayWhat)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startNewRound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _UpdateInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetupBinds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Keys GetBoundKey(InputButton[] button)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBoundButtonDown(GameKeys game_key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tick(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ProcessInputs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyLevelSpecificStates()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateAbigail(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int[,] getMap(int wave)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void releaseRightClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void spawnBullets(IList<int> directions, Vector2 spawn)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isSpawnQueueEmpty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isMapTilePassable(int tileType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isMapTilePassableForMonsters(int tileType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isCollidingWithMonster(Rectangle r, CowboyMonster subject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isCollidingWithMapForMonsters(Rectangle positionToCheck)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isCollidingWithMap(Rectangle positionToCheck)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isCollidingWithMap(Point position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addPlayer2MovementDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addPlayerMovementDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addPlayer2ShootingDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addPlayerShootingDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startShoppingLevel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveKeyPress(Keys k)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveKeyRelease(Keys k)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getPriceForItem(int whichItem)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeScreenSize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveEventPoke(int data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string minigameId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool doMainGameUpdates()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool forceQuit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void drawJoysticks(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetJoystickStartPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMobile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTap(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapLeftJoystick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapRightJoystick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapHeldJoystickLeft(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapHeldJoystickRight(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _InitializeMobileControls()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetForcedScaleFactor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
