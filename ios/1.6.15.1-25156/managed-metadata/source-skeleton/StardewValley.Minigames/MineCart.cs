using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.BellsAndWhistles;
using StardewValley.Menus;

namespace StardewValley.Minigames;

public class MineCart : IMinigame
{
	[XmlType("MineCart.GameStates")]
	public enum GameStates
	{
		Title,
		Ingame,
		FruitsSummary,
		Map,
		Cutscene
	}

	public class LevelTransition
	{
		public int startLevel;

		public int destinationLevel;

		public Point startGridCoordinates;

		public string pathString;

		public Func<bool> shouldTakePath;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LevelTransition(int start_level, int destination_level, int start_grid_x, int start_grid_y, string path_string, Func<bool> should_take_path = null)
		{
		}
	}

	public enum CollectableFruits
	{
		Cherry,
		Orange,
		Grape,
		MAX
	}

	public enum ObstacleTypes
	{
		Normal,
		Air,
		Difficult
	}

	public class GeneratorRoll
	{
		public float chance;

		public BaseTrackGenerator generator;

		public Func<bool> additionalGenerationCondition;

		public BaseTrackGenerator forcedNextGenerator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GeneratorRoll(float generator_chance, BaseTrackGenerator track_generator, Func<bool> additional_generation_condition = null, BaseTrackGenerator forced_next_generator = null)
		{
		}
	}

	public class MapJunimo : Entity
	{
		public enum MoveState
		{
			Idle,
			Moving,
			Finished
		}

		public int direction;

		public string moveString;

		public float moveSpeed;

		public float pixelsToMove;

		public MoveState moveState;

		public float nextBump;

		public float bumpHeight;

		private bool isOnWater;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartMoving()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapJunimo()
		{
		}
	}

	public class LakeDecor
	{
		public Point _position;

		public int spriteIndex;

		protected MineCart _game;

		public int _lastCycle;

		public bool _bgDecor;

		private int _animationFrames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LakeDecor(MineCart game, int theme = -1, bool bgDecor = false, int forceXPosition = -1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw(SpriteBatch b)
		{
		}
	}

	public class StraightAwayGenerator : BaseTrackGenerator
	{
		public int straightAwayLength;

		public List<int> staggerPattern;

		public int minLength;

		public int maxLength;

		public float staggerChance;

		public int minimuimDistanceBetweenStaggers;

		public int currentStaggerDistance;

		public bool generateCheckpoint;

		protected bool _generatedCheckpoint;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StraightAwayGenerator SetMinimumDistanceBetweenStaggers(int min)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StraightAwayGenerator SetLength(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StraightAwayGenerator SetCheckpoint(bool checkpoint)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StraightAwayGenerator SetStaggerChance(float chance)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StraightAwayGenerator SetStaggerValues(params int[] args)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StraightAwayGenerator SetStaggerValueRange(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StraightAwayGenerator(MineCart game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _GenerateTrack()
		{
		}
	}

	public class SmallGapGenerator : BaseTrackGenerator
	{
		public int minLength;

		public int maxLength;

		public int minDepth;

		public int maxDepth;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmallGapGenerator SetLength(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmallGapGenerator SetDepth(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmallGapGenerator(MineCart game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _GenerateTrack()
		{
		}
	}

	public class RapidHopsGenerator : BaseTrackGenerator
	{
		public int minLength;

		public int maxLength;

		private int startY;

		public int yStep;

		public bool chaotic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RapidHopsGenerator SetLength(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RapidHopsGenerator SetYStep(int yStep)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RapidHopsGenerator SetChaotic(bool chaotic)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RapidHopsGenerator(MineCart game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _GenerateTrack()
		{
		}
	}

	public class NoxiousMushroom : Obstacle
	{
		public float nextFire;

		public float firePeriod;

		protected Track _track;

		public Rectangle[] frames;

		public int currentFrame;

		public float frameDuration;

		public float frameTimer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeObstacle(Track track)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanSpawnHere(Track track)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NoxiousMushroom()
		{
		}
	}

	public class MushroomSpring : Obstacle
	{
		protected HashSet<MineCartCharacter> _bouncedPlayers;

		public Rectangle[] frames;

		public int currentFrame;

		public float frameDuration;

		public float frameTimer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeObstacle(Track track)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanSpawnHere(Track track)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBounce(MineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBump(PlayerMineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BouncePlayer(MineCartCharacter player)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShootDebris(int x, int y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerReset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomSpring()
		{
		}
	}

	public class MushroomBalanceTrackGenerator : BaseTrackGenerator
	{
		protected int minHopSize;

		protected int maxHopSize;

		protected float releaseJumpChance;

		protected List<int> staggerPattern;

		protected Track.TrackType trackType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBalanceTrackGenerator SetTrackType(Track.TrackType track_type)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBalanceTrackGenerator SetStaggerValues(params int[] args)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBalanceTrackGenerator SetReleaseJumpChance(float chance)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBalanceTrackGenerator SetHopSize(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBalanceTrackGenerator(MineCart game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _GenerateTrack()
		{
		}
	}

	public class MushroomBunnyHopGenerator : BaseTrackGenerator
	{
		protected int numberOfHops;

		protected int minHops;

		protected int maxHops;

		protected int minHopSize;

		protected int maxHopSize;

		protected float releaseJumpChance;

		protected List<int> staggerPattern;

		protected Track.TrackType trackType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBunnyHopGenerator SetStaggerValues(params int[] args)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBunnyHopGenerator SetReleaseJumpChance(float chance)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBunnyHopGenerator SetHopSize(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBunnyHopGenerator SetNumberOfHops(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MushroomBunnyHopGenerator(MineCart game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _GenerateTrack()
		{
		}
	}

	public class BunnyHopGenerator : BaseTrackGenerator
	{
		protected int numberOfHops;

		protected int minHops;

		protected int maxHops;

		protected int minHopSize;

		protected int maxHopSize;

		protected float releaseJumpChance;

		protected List<int> staggerPattern;

		protected Track.TrackType trackType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BunnyHopGenerator SetTrackType(Track.TrackType track_type)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BunnyHopGenerator SetStaggerValues(params int[] args)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BunnyHopGenerator SetReleaseJumpChance(float chance)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BunnyHopGenerator SetHopSize(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BunnyHopGenerator SetNumberOfHops(int min, int max)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BunnyHopGenerator(MineCart game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _GenerateTrack()
		{
		}
	}

	public class BaseTrackGenerator
	{
		public const int OBSTACLE_NONE = -10;

		public const int OBSTACLE_MIDDLE = -10;

		public const int OBSTACLE_FRONT = -11;

		public const int OBSTACLE_BACK = -12;

		public const int OBSTACLE_RANDOM = -13;

		protected List<Track> _generatedTracks;

		protected MineCart _game;

		protected Dictionary<int, KeyValuePair<ObstacleTypes, float>> _obstacleIndices;

		protected Func<Track, BaseTrackGenerator, bool> _pickupFunction;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FlatsOnly(Track track, BaseTrackGenerator generator)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool UpSlopesOnly(Track track, BaseTrackGenerator generator)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DownSlopesOnly(Track track, BaseTrackGenerator generator)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IceDownSlopesOnly(Track track, BaseTrackGenerator generator)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Always(Track track, BaseTrackGenerator generator)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool EveryOtherTile(Track track, BaseTrackGenerator generator)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T AddObstacle<T>(ObstacleTypes obstacle_type, int position, float obstacle_chance = 1f) where T : BaseTrackGenerator
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T AddPickupFunction<T>(Func<Track, BaseTrackGenerator, bool> pickup_spawn_function) where T : BaseTrackGenerator
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BaseTrackGenerator(MineCart game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Track AddTrack(int x, int y, Track.TrackType track_type = Track.TrackType.Straight)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Track AddTrack(Track track)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Track AddPickupTrack(int x, int y, Track.TrackType track_type = Track.TrackType.Straight)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GenerateTrack()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PopulateObstacles()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _GenerateTrack()
		{
		}
	}

	public class Spark
	{
		public float x;

		public float y;

		public Color c;

		public float dx;

		public float dy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Spark(float x, float y, float dx, float dy)
		{
		}
	}

	public class Entity
	{
		public Vector2 position;

		protected MineCart _game;

		public bool visible;

		public bool enabled;

		protected bool _destroyed;

		public Vector2 drawnPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPlayerReset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsOnScreen()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActive()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(MineCart game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Destroy()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _Initialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool ShouldReap()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Entity()
		{
		}
	}

	public class BaseCharacter : Entity
	{
		public Vector2 velocity;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BaseCharacter()
		{
		}
	}

	public interface ICollideable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		Rectangle GetLocalBounds();

		[MethodImpl(MethodImplOptions.NoInlining)]
		Rectangle GetBounds();
	}

	public class Bubble : Obstacle
	{
		public Vector2 _normalizedVelocity;

		public float moveSpeed;

		protected float _age;

		protected int _currentFrame;

		protected float _timePerFrame;

		protected int[] _frames;

		protected int _repeatedFrameCount;

		protected float _lifeTime;

		public Vector2 bubbleOffset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerReset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bubble(float angle, float speed)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBump(PlayerMineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBounce(MineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Pop(bool play_sound = true)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}
	}

	public class PlayerBubbleSpawner : Entity
	{
		public int bubbleCount;

		public float timer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerBubbleSpawner()
		{
		}
	}

	public class Whale : Entity
	{
		public enum CurrentState
		{
			Idle,
			OpenMouth,
			FireBubbles,
			CloseMouth
		}

		protected CurrentState _currentState;

		protected float _stateTimer;

		public float mouthCloseTime;

		protected float _nextFire;

		protected int _currentFrame;

		protected Vector2 _basePosition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(CurrentState new_state, float state_timer = 1f)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerReset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Initialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Whale()
		{
		}
	}

	public class EndingJunimo : Entity
	{
		protected Color _color;

		protected Vector2 _velocity;

		private bool _special;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EndingJunimo(bool special = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Initialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}
	}

	public class FallingBoulderSpawner : Obstacle
	{
		public float period;

		public float currentTime;

		protected Track _track;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeObstacle(Track track)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FallingBoulderSpawner()
		{
		}
	}

	public class WillOWisp : Obstacle
	{
		protected float _age;

		protected Vector2 offset;

		public float tailRotation;

		public float tailLength;

		public float scale;

		public float nextDebris;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBump(PlayerMineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WillOWisp()
		{
		}
	}

	public class CosmeticFallingBoulder : FallingBoulder
	{
		private float yBreakPosition;

		private float delayBeforeAppear;

		private Color color;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticFallingBoulder(float yBreakPosition, Color color, float fallSpeed = 96f, float delayBeforeAppear = 0f)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}
	}

	public class NoxiousGas : Obstacle
	{
		protected float _age;

		protected float _currentRiseSpeed;

		protected float _riseSpeed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerReset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBounce(MineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ShouldReap()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NoxiousGas()
		{
		}
	}

	public class FallingBoulder : Obstacle
	{
		protected float _age;

		protected List<Track> _tracks;

		protected float _currentFallSpeed;

		protected float _fallSpeed;

		protected bool _wasBouncedOn;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerReset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeObstacle(Track track)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBounce(MineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBump(PlayerMineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ShouldReap()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FallingBoulder()
		{
		}
	}

	public class MineCartSlime : Obstacle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ShouldReap()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MineCartSlime()
		{
		}
	}

	public class SlimeTrack : Obstacle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ShouldReap()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SlimeTrack()
		{
		}
	}

	public class HugeSlime : Obstacle
	{
		protected float _timeUntilHop;

		protected float _yVelocity;

		protected bool _grounded;

		protected float _lastTrackY;

		public Vector2 spriteScale;

		protected int _currentFrame;

		protected Vector2 _desiredScale;

		protected float _scaleSpeed;

		protected float _jumpStrength;

		private bool _hasPeparedToJump;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerReset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Initialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ShouldReap()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HugeSlime()
		{
		}
	}

	public class Roadblock : Obstacle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanSpawnHere(Track track)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBounce(MineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnBump(PlayerMineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShootDebris(int x, int y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Roadblock()
		{
		}
	}

	public class MineDebris : Entity
	{
		protected Rectangle _sourceRect;

		protected float _dX;

		protected float _dY;

		protected float _age;

		protected float _lifeTime;

		protected float _gravityMultiplier;

		protected float _scale;

		protected Color _color;

		protected int _numAnimationFrames;

		protected bool _holdLastFrame;

		protected float _animationInterval;

		protected int _currentAnimationFrame;

		protected float _animationTimer;

		public float ySinWaveMagnitude;

		public float flipRate;

		public float depth;

		private float timeBeforeDisplay;

		private string destroySound;

		private string startSound;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MineDebris(Rectangle source_rect, Vector2 spawn_position, float dx, float dy, float flip_rate = 0f, float gravity_multiplier = 1f, float life_time = 0.5f, float scale = 1f, int num_animation_frames = 1, float animation_interval = 0.1f, float draw_depth = 0.45f, bool holdLastFrame = false, float timeBeforeDisplay = 0f)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void reset(Rectangle source_rect, Vector2 spawn_position, float dx, float dy, float flip_rate = 0f, float gravity_multiplier = 1f, float life_time = 0.5f, float scale = 1f, int num_animation_frames = 1, float animation_interval = 0.1f, float draw_depth = 0.45f, bool holdLastFrame = false, float timeBeforeDisplay = 0f)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color color)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDestroySound(string sound)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStartSound(string sound)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Rectangle _GetSourceRect()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}
	}

	public class Obstacle : Entity, ICollideable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitializeObstacle(Track track)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool OnBounce(MineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool OnBump(PlayerMineCartCharacter player)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Rectangle GetBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool CanSpawnHere(Track track)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Obstacle()
		{
		}
	}

	public class Fruit : Pickup
	{
		protected CollectableFruits _fruitType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Fruit(CollectableFruits fruit_type)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Collect(PlayerMineCartCharacter player)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}
	}

	public class Coin : Pickup
	{
		public float age;

		public float afterCollectionTimer;

		public bool collected;

		public float flashSpeed;

		public float flashDelay;

		public float collectYDelta;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Collect(PlayerMineCartCharacter player)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Coin()
		{
		}
	}

	public class Pickup : Entity, ICollideable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Rectangle GetBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Collect(PlayerMineCartCharacter player)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Pickup()
		{
		}
	}

	public class BalanceTrack : Track
	{
		public List<BalanceTrack> connectedTracks;

		public List<BalanceTrack> counterBalancedTracks;

		public float startY;

		public float moveSpeed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BalanceTrack(TrackType type, bool showSecondTile)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerReset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WhileCartGrounded(MineCartCharacter character, float time)
		{
		}
	}

	public class Track : Entity
	{
		public enum TrackType
		{
			None = -1,
			Straight = 0,
			UpSlope = 2,
			DownSlope = 3,
			IceDownSlope = 4,
			SlimeUpSlope = 5,
			MushroomLeft = 6,
			MushroomMiddle = 7,
			MushroomRight = 8
		}

		public Obstacle obstacle;

		private bool _showSecondTile;

		public TrackType trackType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Track(TrackType type, bool showSecondTile)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WhileCartGrounded(MineCartCharacter character, float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanLandHere(Vector2 test_position)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetYAtPoint(float x)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class PlayerMineCartCharacter : MineCartCharacter, ICollideable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Rectangle GetLocalBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Rectangle GetBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnJump()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnFall()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnLand()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnTrackChange()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerMineCartCharacter()
		{
		}
	}

	public class CheckpointIndicator : Entity
	{
		public const int CENTER_TO_POST_BASE_OFFSET = 5;

		public float rotation;

		protected bool _activated;

		public float swayRotation;

		public float swayTimer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CheckpointIndicator()
		{
		}
	}

	public class GoalIndicator : Entity
	{
		public float rotation;

		protected bool _activated;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GoalIndicator()
		{
		}
	}

	public class MineCartCharacter : BaseCharacter
	{
		public float minecartBumpOffset;

		public float jumpStrength;

		public float maxFallSpeed;

		public float jumpGravity;

		public float fallGravity;

		public float jumpFloatDuration;

		public float gravity;

		protected float _jumpBuffer;

		protected float _jumpFloatAge;

		protected float _speedMultiplier;

		protected float _jumpMomentumThreshhold;

		public float jumpGracePeriod;

		protected bool _grounded;

		protected bool _jumping;

		public float rotation;

		public Vector2 cartScale;

		public Track.TrackType currentTrackType;

		public float characterExtraHeight;

		protected bool _hasJustSnapped;

		public float forcedJumpTime;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void QueueJump()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDie()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SnapToFloor()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Track GetTrack(Vector2 offset = default(Vector2))
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _Update(float time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetMaxFallSpeed()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnLand()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnTrackChange()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnFall()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnJump()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseJump()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsJumping()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsGrounded()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Bounce(float forced_bounce_time = 0f)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Jump()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceGrounded()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MineCartCharacter()
		{
		}
	}

	public GameStates gameState;

	public const int followDistance = 96;

	public float pixelScale;

	public const int tilesBeyondViewportToSimulate = 4;

	public const int bgLoopWidth = 96;

	public const float gravity = 0.21f;

	public const int brownArea = 0;

	public const int frostArea = 1;

	public const int darkArea = 3;

	public const int waterArea = 2;

	public const int lavaArea = 4;

	public const int heavenlyArea = 5;

	public const int sunsetArea = 6;

	public const int endingCutscene = 7;

	public const int bonusLevel1 = 8;

	public const int mushroomArea = 9;

	public const int LAST_LEVEL = 6;

	public readonly int[] infiniteModeLevels;

	public float shakeMagnitude;

	protected Vector2 _shakeOffset;

	public const int infiniteMode = 2;

	public const int progressMode = 3;

	public const int respawnTime = 1400;

	public static float maxJumpGraceTime;

	public float slimeBossPosition;

	public float slimeBossSpeed;

	public float secondsOnThisLevel;

	public int fruitEatCount;

	public int currentFruitCheckIndex;

	public float currentFruitCheckMagnitude;

	public const int checkpointScanDistance = 16;

	public int coinCount;

	public bool gamePaused;

	private SparklingText perfectText;

	private float lakeSpeedAccumulator;

	private float backBGPosition;

	private float midBGPosition;

	private float waterFallPosition;

	public Vector2 upperLeft;

	private Stopwatch musicSW;

	private bool titleJunimoStartedBobbing;

	private bool lastLevelWasPerfect;

	private bool completelyPerfect;

	private int screenWidth;

	private int screenHeight;

	public int tileSize;

	private int waterfallWidth;

	private int ytileOffset;

	private int score;

	private int levelsBeat;

	private int gameMode;

	private int livesLeft;

	private int distanceToTravel;

	private int respawnCounter;

	private int currentTheme;

	private bool reachedFinish;

	private bool gameOver;

	private float screenDarkness;

	protected string cutsceneText;

	public float fadeDelta;

	private ICue minecartLoop;

	private Texture2D texture;

	private Dictionary<int, List<Track>> _tracks;

	private List<LakeDecor> lakeDecor;

	private List<Point> obstacles;

	private List<Spark> sparkShower;

	private List<int> levelThemesFinishedThisRun;

	private Color backBGTint;

	private Color midBGTint;

	private Color caveTint;

	private Color lakeTint;

	private Color waterfallTint;

	private Color trackShadowTint;

	private Color trackTint;

	private Rectangle midBGSource;

	private Rectangle backBGSource;

	private Rectangle lakeBGSource;

	private int backBGYOffset;

	private int midBGYOffset;

	protected double _totalTime;

	private MineCartCharacter player;

	private MineCartCharacter trackBuilderCharacter;

	private MineDebris titleScreenJunimo;

	private List<Entity> _entities;

	public LevelTransition[] LEVEL_TRANSITIONS;

	protected BaseTrackGenerator _lastGenerator;

	protected BaseTrackGenerator _forcedNextGenerator;

	public float screenLeftBound;

	public Point generatorPosition;

	private BaseTrackGenerator _trackGenerator;

	protected GoalIndicator _goalIndicator;

	public int bottomTile;

	public int topTile;

	public float deathTimer;

	protected int _lastTilePosition;

	public int slimeResetPosition;

	public float checkpointPosition;

	public int furthestGeneratedCheckpoint;

	public bool isJumpPressed;

	public float stateTimer;

	public int cutsceneTick;

	public float pauseBeforeTitleFadeOutTimer;

	public float mapTimer;

	private List<KeyValuePair<string, int>> _currentHighScores;

	private int currentHighScore;

	public float scoreUpdateTimer;

	protected HashSet<CollectableFruits> _spawnedFruit;

	protected HashSet<CollectableFruits> _collectedFruit;

	public List<int> checkpointPositions;

	protected Dictionary<ObstacleTypes, List<Type>> _validObstacles;

	private ClickableTextureComponent buttonExit;

	protected List<GeneratorRoll> _generatorRolls;

	private bool _trackAddedFlip;

	protected bool _buttonState;

	public bool _wasJustChatting;

	public double totalTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public double totalTimeMS
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MineCart(int whichTheme, int mode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initLevelTransitions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowTitle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshHighScore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Obstacle AddObstacle(Track track, ObstacleTypes obstacle_type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual T AddEntity<T>(T new_entity) where T : Entity
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Track GetTrackForXPosition(float x)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCheckpoint(int tile_x)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Track> GetTracksForXPosition(float x)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool _IsGeneratingOnUpperHalf()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool _IsGeneratingOnLowerHalf()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _GenerateMoreTrack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Track AddTrack(int x, int y, Track.TrackType type = Track.TrackType.Straight)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Track AddTrack(Track track_object)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool overrideFreeMouseMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateMapTick(float time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneTick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutSceneForBrownArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneForFrostArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneForLavaArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneForWaterArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneForDarkArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneForMushroomArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneForSunsetArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneForHeavenlyArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCutsceneForEnding(ref int fadeOutTimer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFruitsSummary(float time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanPause()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tick(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateScoreState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetValidCheckpointPosition(int x_pos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CollectFruit(CollectableFruits fruit_type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CollectCoin(int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void submitHighScore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Die()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReapEntities()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveLeftClick(int x, int y, bool playSound = true)
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
	public void receiveRightClick(int x, int y, bool playSound = true)
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
	public void ResetState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void QuitGame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void restartLevel(bool new_game = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowFruitsSummary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowCutscene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayLevelMusic()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndCutscene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createSparkShower(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createSparkShower()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateLakeDecor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateBGDecor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createBeginningOfLevel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setGameModeParameters()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddValidObstacle(ObstacleTypes obstacle_type, Type type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpTheme(int whichTheme)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int KeepTileInBounds(int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTileInBounds(int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetOverlap<T>(ICollideable source) where T : Entity
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<T> GetOverlaps<T>(ICollideable source) where T : Entity
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pickup CreatePickup(Vector2 position, bool fruit_only = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetPixelScale()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle TransformDraw(Rectangle dest)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Mod(int x, int m)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 TransformDraw(Vector2 dest)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public bool forceQuit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void leftClickHeld(int x, int y)
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
	public float GetForcedScaleFactor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
