using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class MermaidHouse : GameLocation
{
	private Texture2D mermaidSprites;

	private float showTimer;

	private float curtainMovement;

	private float curtainOpenPercent;

	private float blackBGAlpha;

	private float bigMermaidAlpha;

	private float oldStopWatchTime;

	private float finalLeftMermaidAlpha;

	private float finalRightMermaidAlpha;

	private float finalBigMermaidAlpha;

	private float fairyTimer;

	private int[] mermaidFrames;

	private Stopwatch stopWatch;

	private List<Vector2> bubbles;

	private TemporaryAnimatedSpriteList sparkles;

	private TemporaryAnimatedSpriteList alwaysFrontTempSprites;

	private List<int> lastFiveClamTones;

	private Farmer pearlRecipient;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MermaidHouse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MermaidHouse(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playClamTone(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playClamTone(int which, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}
}
