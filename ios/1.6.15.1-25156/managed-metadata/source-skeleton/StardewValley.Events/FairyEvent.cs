using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Events;

public class FairyEvent : BaseFarmEvent
{
	public string lightSourceId;

	private Vector2 fairyPosition;

	private Vector2 targetCrop;

	private Farm f;

	private int fairyFrame;

	private int fairyAnimationTimer;

	private int animationLoopsDone;

	private int timerSinceFade;

	private bool animateLeft;

	private bool terminate;

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
	protected Vector2 ChooseCrop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FairyEvent()
	{
	}
}
