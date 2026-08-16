using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Menus;

namespace StardewValley.Minigames;

public class CraneGame : IMinigame
{
	public enum GameButtons
	{
		Action,
		Tool,
		Confirm,
		Cancel,
		Run,
		Up,
		Left,
		Down,
		Right,
		MAX
	}

	public class GameLogic : CraneGameObject
	{
		[XmlType("CraneGame.GameStates")]
		public enum GameStates
		{
			Setup,
			Idle,
			MoveClawRight,
			WaitForMoveDown,
			MoveClawDown,
			ClawDescend,
			ClawAscend,
			ClawReturn,
			ClawRelease,
			ClawReset,
			EndGame
		}

		public List<Item> collectedItems;

		public const int CLAW_HEIGHT = 50;

		protected Claw _claw;

		public int maxLives;

		public int lives;

		public Vector2 _startPosition;

		public Vector2 _dropPosition;

		public Rectangle playArea;

		public Rectangle prizeChute;

		protected GameStates _currentState;

		protected int _stateTimer;

		public CraneGameObject moveRightIndicator;

		public CraneGameObject moveDownIndicator;

		public CraneGameObject creditsDisplay;

		public CraneGameObject timeDisplay1;

		public CraneGameObject timeDisplay2;

		public CraneGameObject sunShockedFace;

		public int currentTimer;

		public CraneGameObject joystick;

		public int[] conveyerBeltTiles;

		public int[] prizeMap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameLogic(CraneGame game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameStates GetCurrentState()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update(GameTime time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Draw(SpriteBatch b, float layer_depth)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(GameStates new_state)
		{
		}
	}

	public class Trampoline : CraneGameObject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Trampoline(CraneGame game, int x, int y)
		{
		}
	}

	public class Shadow : CraneGameObject
	{
		public CraneGameObject _target;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Shadow(CraneGame game, CraneGameObject target)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update(GameTime time)
		{
		}
	}

	public class Claw : CraneGameObject
	{
		protected CraneGameObject _leftArm;

		protected CraneGameObject _rightArm;

		protected Prize _grabbedPrize;

		protected Vector2 _prizePositionOffset;

		protected int _nextDropCheckTimer;

		protected int _dropChances;

		protected int _grabTime;

		public float openAngle
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
		public Claw(CraneGame game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckDropPrize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyDrawEffectToArms(DrawEffect new_effect)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseGrabbedObject()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GrabObject()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Prize GetGrabbedPrize()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update(GameTime time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
		}
	}

	public class ConveyerBelt : CraneGameObject
	{
		protected int _direction;

		protected Vector2 _spriteStartPosition;

		protected int _spriteOffset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetDirection()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConveyerBelt(CraneGame game, int x, int y, int direction)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSpriteFromCorner(int x, int y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update(GameTime time)
		{
		}
	}

	public class Bush : CraneGameObject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bush(CraneGame game, int tile_index, int tile_width, int tile_height, int x, int y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update(GameTime time)
		{
		}
	}

	public class Prize : CraneGameObject
	{
		protected Vector2 _conveyerBeltMove;

		public bool grabbed;

		public float gravity;

		protected Vector2 _velocity;

		protected Item _item;

		protected float _restingZPosition;

		protected float _angularSpeed;

		protected bool _isBeingCollected;

		public bool isLargeItem;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetRestingZPosition()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Prize(CraneGame game, Item item)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrop()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _UpdateItemSprite()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanBeGrabbed()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update(GameTime time)
		{
		}
	}

	public class CraneGameObject
	{
		protected CraneGame _game;

		public Vector2 position;

		public float rotation;

		public Vector2 scale;

		public bool flipX;

		public bool flipY;

		public Rectangle spriteRect;

		public Texture2D texture;

		public Vector2 spriteAnchor;

		public Color color;

		public float layerDepth;

		public int width;

		public int height;

		public float zPosition;

		public bool visible;

		public List<DrawEffect> drawEffects;

		protected bool _destroyed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CraneGameObject(CraneGame game)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSpriteFromIndex(int index = 0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsDestroyed()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Destroy()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Move(float x, float y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Rectangle GetBounds()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update(GameTime time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetRendererLayerDepth()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyDrawEffect(DrawEffect new_effect)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Draw(SpriteBatch b, float layer_depth)
		{
		}
	}

	public class SwayEffect : DrawEffect
	{
		public float swayMagnitude;

		public float swaySpeed;

		public int swayDuration;

		public int age;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SwayEffect(float magnitude, float speed = 1f, int sway_duration = 10)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Apply(ref Vector2 position, ref float rotation, ref Vector2 scale)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class ShakeEffect : DrawEffect
	{
		public Vector2 shakeAmount;

		public int shakeDuration;

		public int age;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShakeEffect(float shake_x, float shake_y, int shake_duration = 10)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Apply(ref Vector2 position, ref float rotation, ref Vector2 scale)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class StretchEffect : DrawEffect
	{
		public Vector2 stretchScale;

		public int stretchDuration;

		public int age;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StretchEffect(float x_scale, float y_scale, int stretch_duration = 10)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Apply(ref Vector2 position, ref float rotation, ref Vector2 scale)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class DrawEffect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Apply(ref Vector2 position, ref float rotation, ref Vector2 scale)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DrawEffect()
		{
		}
	}

	public int gameWidth;

	public int gameHeight;

	protected LocalizedContentManager _content;

	public Texture2D spriteSheet;

	public Vector2 upperLeft;

	protected List<CraneGameObject> _gameObjects;

	protected Dictionary<GameButtons, int> _buttonStates;

	protected bool _shouldQuit;

	public Action onQuit;

	public ICue music;

	public ICue fastMusic;

	public Effect _effect;

	public int freezeFrames;

	public ICue craneSound;

	public List<Type> _gameObjectTypes;

	public Dictionary<Type, List<CraneGameObject>> _gameObjectsByType;

	private ClickableTextureComponent buttonExit;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CraneGame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Quit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _UpdateInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsButtonPressed(GameButtons button)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsButtonDown(GameButtons button)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _UpdateButtonState(GameButtons button, InputButton[] keys, HashSet<InputButton> emulated_keys)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetObjectAtPoint<T>(Vector2 point, int max_count = -1) where T : CraneGameObject
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<T> GetObjectsAtPoint<T>(Vector2 point, int max_count = -1) where T : CraneGameObject
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetObjectOfType<T>() where T : CraneGameObject
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<T> GetObjectsOfType<T>() where T : CraneGameObject
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<T> GetOverlaps<T>(CraneGameObject target, int max_count = -1) where T : CraneGameObject
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tick(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool forceQuit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool overrideFreeMouseMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool doMainGameUpdates()
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
	public void RegisterGameObject(CraneGameObject game_object)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterGameObject(CraneGameObject game_object)
	{
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
	public float GetForcedScaleFactor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
