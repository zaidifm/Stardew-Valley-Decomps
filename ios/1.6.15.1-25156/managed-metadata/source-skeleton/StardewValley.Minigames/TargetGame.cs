using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Menus;
using StardewValley.Mobile;
using StardewValley.Projectiles;

namespace StardewValley.Minigames;

[InstanceStatics]
public class TargetGame : IMinigame
{
	public class Target
	{
		public static int width;

		public static int spawnRightPosition;

		public static int spawnLeftPosition;

		public static int basicTarget;

		public static int bonusTarget;

		public static int deluxeTarget;

		public static int mediumSpeed;

		public static int slowSpeed;

		public static int fastSpeed;

		public static int nearLane;

		public static int middleLane;

		public static int farLane;

		public static int superNearLane;

		public static int behindLane;

		public static int pauseFarRight;

		public static int pauseRight;

		public static int pauseMiddleRight;

		public static int pauseMiddleLeft;

		public static int pauseLeft;

		public static int pauseFarLeft;

		public Rectangle Position;

		private int targetType;

		private int countdownBeforeSpawn;

		private int xPausePosition;

		private int xPauseTime;

		private int speed;

		private bool spawned;

		private bool atPausePosition;

		private Rectangle sourceRect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Target(int countdownBeforeSpawn, int whichLane, int type = 0, int speed = 4, bool spawnFromRight = true, int pauseAndReturn = -1, int pauseTime = -1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool update(GameTime time, GameLocation location)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void shatter(GameLocation location, Projectile stone)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void draw(SpriteBatch b)
		{
		}
	}

	internal GameLocation location;

	private int timerToStart;

	private int gameEndTimer;

	private int showResultsTimer;

	private bool gameDone;

	private bool exit;

	public static int score;

	public static int shotsFired;

	public static int successShots;

	public static int accuracy;

	public static int starTokensWon;

	public List<Target> targets;

	private float modifierBonus;

	private bool _aiming;

	public ClickableTextureComponent upperRightCloseButton;

	public bool _quit;

	public TapToMove tapToMove;

	private bool usingSlingshot;

	public bool _previousJoypadVisibility;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TargetGame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool overrideFreeMouseMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tick(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void gameDoneAfterFade()
	{
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
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void startMe()
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
	public void addTargets()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addTwinPausers(int initialDelay, int whichLane, int pauseArea, int speed, int pauseTime, int targetType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addRowOfTargetsOnLane(int initialDelayBeforeStarting, int whichLane, int delayBetween, int numberOfTargets, int speed, bool spawnFromRight = true, int targetType = 0)
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
	public void ReceiveMobileKeyStates(MobileKeyStates mobileKeyStates)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool forceQuit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckForVirtualJoypadInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetForcedScaleFactor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
