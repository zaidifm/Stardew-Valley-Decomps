using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.BellsAndWhistles;

public class EmilysParrot : TemporaryAnimatedSprite
{
	public const int flappingPhase = 1;

	public const int hoppingPhase = 0;

	public const int lookingSidewaysPhase = 2;

	public const int nappingPhase = 3;

	public const int headBobbingPhase = 4;

	private int currentFrame;

	private int currentFrameTimer;

	private int currentPhaseTimer;

	private int currentPhase;

	private int shakeTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmilysParrot(Vector2 location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateFlappingPhase()
	{
	}
}
