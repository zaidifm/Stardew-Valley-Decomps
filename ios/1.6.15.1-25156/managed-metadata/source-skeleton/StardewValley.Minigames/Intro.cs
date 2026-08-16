using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Menus;

namespace StardewValley.Minigames;

[InstanceStatics]
public class Intro : IMinigame
{
	public class Balloon
	{
		public Vector2 position;

		public Color color;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Balloon(int screenWidth, int screenHeight)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void update(float speed, GameTime time)
		{
		}
	}

	public int pixelScale;

	public const int skyLoopWidth = 112;

	public const int cloudLoopWidth = 170;

	public const int tilesBeyondViewportToSimulate = 6;

	public const int leftFence = 0;

	public const int centerFence = 1;

	public const int rightFence = 2;

	public const int busYRest = 240;

	public const int choosingCharacterState = 0;

	public const int panningDownFromCloudsState = 1;

	public const int panningDownToRoadState = 2;

	public const int drivingState = 3;

	public const int stardewInViewState = 4;

	public float speed;

	private float valleyPosition;

	private float skyPosition;

	private float roadPosition;

	private float bigCloudPosition;

	private float backCloudPosition;

	private float globalYPan;

	private float globalYPanDY;

	private float drivingTimer;

	private float fadeAlpha;

	private float treePosition;

	private int screenWidth;

	private int screenHeight;

	private int tileSize;

	private Matrix transformMatrix;

	private Texture2D texture;

	private Texture2D roadsideTexture;

	private Texture2D cloudTexture;

	private Texture2D treeStripTexture;

	private List<Point> backClouds;

	private List<int> road;

	private List<int> sky;

	private List<int> roadsideObjects;

	private List<int> roadsideFences;

	private Color skyColor;

	private Color roadColor;

	private Color carColor;

	private bool cameraCenteredOnBus;

	private bool addedSign;

	private Vector2 busPosition;

	private Vector2 carPosition;

	private Vector2 birdPosition;

	private CharacterCustomization characterCreateMenu;

	private List<Balloon> balloons;

	private int birdFrame;

	private float birdTimer;

	private float birdXTimer;

	public static ICue roadNoise;

	private int fenceBuildStatus;

	private int currentState;

	private bool quit;

	private bool hasQuit;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Intro()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Intro(int startingGameMode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool overrideFreeMouseMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createBeginningOfLevel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateRoad(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateUpperClouds(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tick(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doneCreatingCharacter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveLeftClick(int x, int y, bool playSound = true)
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
	public void leftClickHeld(int x, int y)
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
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawRoadArea(SpriteBatch b)
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
	public float GetForcedScaleFactor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
