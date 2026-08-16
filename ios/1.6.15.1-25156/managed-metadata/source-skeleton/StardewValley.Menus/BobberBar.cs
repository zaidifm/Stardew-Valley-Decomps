using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.BellsAndWhistles;

namespace StardewValley.Menus;

public class BobberBar : IClickableMenu
{
	public const int timePerFishSizeReduction = 800;

	public const int bobberTrackHeight = 548;

	public const int bobberBarTrackHeight = 568;

	public const int xOffsetToBobberTrack = 64;

	public const int yOffsetToBobberTrack = 12;

	public const int mixed = 0;

	public const int dart = 1;

	public const int smooth = 2;

	public const int sink = 3;

	public const int floater = 4;

	public const int CHALLENGE_BAIT_MAX_FISHES = 3;

	protected bool handledFishResult;

	private float difficulty;

	private int motionType;

	private string whichFish;

	private float distanceFromCatchPenaltyModifier;

	private string setFlagOnCatch;

	private float bobberPosition;

	private float bobberSpeed;

	private float bobberAcceleration;

	private float bobberTargetPosition;

	private float scale;

	private float everythingShakeTimer;

	private float floaterSinkerAcceleration;

	private float treasurePosition;

	private float treasureCatchLevel;

	private float treasureAppearTimer;

	private float treasureScale;

	private bool bobberInBar;

	private bool buttonPressed;

	private bool flipBubble;

	private bool fadeIn;

	private bool fadeOut;

	private bool treasure;

	private bool treasureCaught;

	private bool perfect;

	private bool bossFish;

	private bool beginnersRod;

	private bool fromFishPond;

	private bool goldenTreasure;

	private int bobberBarHeight;

	private int fishSize;

	private int fishQuality;

	private int minFishSize;

	private int maxFishSize;

	private int fishSizeReductionTimer;

	private int challengeBaitFishes;

	private List<string> bobbers;

	private Vector2 barShake;

	private Vector2 fishShake;

	private Vector2 everythingShake;

	private Vector2 treasureShake;

	private float reelRotation;

	private SparklingText sparkleText;

	private float bobberBarPos;

	private float bobberBarSpeed;

	private float bobberBarAcceleration;

	private float distanceFromCatching;

	public static ICue reelSound;

	public static ICue unReelSound;

	private Item fishObject;

	private float mobileScale;

	private bool _closing;

	private bool _soundsEnabled;

	private bool SeenTutorial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BobberBar(string whichFish, float fishSize, bool treasure, List<string> bobbers, string setFlagOnCatch, bool isBossFish, string baitID = "", bool goldenTreasure = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Reposition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int SafeNext(Random random, int minValue, int maxValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void emergencyShutDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KillReelSounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
