using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Minigames;

public class BoatJourney : IMinigame
{
	public class WaterSparkle : Entity
	{
		protected Vector2 _startPosition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WaterSparkle(BoatJourney context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomizePosition()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnAnimationFinished()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override float GetLayerDepth()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class Wave : Entity
	{
		protected Vector2 _startPosition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Wave(BoatJourney context, Vector2 position = default(Vector2))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Update(GameTime time)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override float GetLayerDepth()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class Boat : Entity
	{
		protected float nextSmokeStackSmoke;

		protected float nextRipple;

		public Vector2? smokeStack;

		public Vector2 _lastPosition;

		public float idleAnimationInterval;

		public float moveAnimationInterval;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Boat(BoatJourney context, string texture_path, Rectangle source_rect, Vector2 origin = default(Vector2), Vector2 position = default(Vector2))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Update(GameTime time)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class Entity
	{
		protected BoatJourney _context;

		public Vector2 position;

		protected Texture2D _texture;

		protected Rectangle _sourceRect;

		protected float lifeTime;

		protected float _age;

		public Vector2 velocity;

		public Vector2 origin;

		public bool flipX;

		protected float _frameTime;

		public float frameInterval;

		public int currentFrame;

		public int numFrames;

		public int columns;

		public bool destroyAfterAnimation;

		public bool drawOnTop;

		public float layerDepth;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Entity(BoatJourney context, string texture_path, Rectangle source_rect, Vector2 origin = default(Vector2), Vector2 position = default(Vector2))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Update(GameTime time)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnAnimationFinished()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSourceRect(Rectangle rectangle)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Rectangle GetSourceRect()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual float GetLayerDepth()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Draw(SpriteBatch b)
		{
		}
	}

	public float _age;

	public Texture2D texture;

	public Rectangle mapSourceRectangle;

	protected float _zoomLevel;

	protected Vector2 viewTarget;

	protected Vector2 _upperLeft;

	public List<Entity> entities;

	protected float _currentBoatSpeed;

	public float boatSpeed;

	public float dockSpeed;

	protected float _nextSlosh;

	protected bool _fadeComplete;

	public Vector2[] points;

	protected List<Vector2> _interpolatedPoints;

	protected List<float> _cumulativeDistances;

	protected float _totalPathDistance;

	protected float traveledBoatDistance;

	protected float nextSmoke;

	public float departureDelay;

	protected Boat _boat;

	protected List<Entity> _seagulls;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoatJourney()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetAssetName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnBoat(Rectangle boat_sprite_rect, Vector2 direction, List<Vector2> other_boat_positions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateFlockOfSeagulls(int x, int y, int depth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 TransformDraw(Vector2 position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle TransformDraw(Rectangle dest)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tick(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void afterFade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool forceQuit()
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
	public void receiveKeyPress(Keys k)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveKeyRelease(Keys k)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color getWaterColorForSeason()
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
	public bool overrideFreeMouseMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetForcedScaleFactor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
