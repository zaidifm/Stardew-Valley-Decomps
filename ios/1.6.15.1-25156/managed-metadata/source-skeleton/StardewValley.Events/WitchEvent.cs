using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Buildings;

namespace StardewValley.Events;

public class WitchEvent : BaseFarmEvent
{
	public string lightSourceId;

	private Vector2 witchPosition;

	private Building targetBuilding;

	private Farm f;

	private Random r;

	private int witchFrame;

	private int witchAnimationTimer;

	private int animationLoopsDone;

	private int timerSinceFade;

	private bool animateLeft;

	private bool terminate;

	public bool goldenWitch;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool setUp()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void afterLastFade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void makeChangesToLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WitchEvent()
	{
	}
}
