using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class CalderaMonkey : Critter
{
	private const int phase_tailBOB = 0;

	private const int phase_footPaddle = 1;

	private const int phase_relaxing = 2;

	private const int phase_scream = 3;

	public Rectangle movementRectangle;

	private int currentPhase;

	private int currentFrame;

	private float nextFrameTimer;

	private float nextPhaseTimer;

	private float currentFrameDelay;

	protected Rectangle _baseSourceRectangle;

	protected Vector2 movementDirection;

	private List<Vector2> buddies;

	private Texture2D texture;

	private Texture2D swimShadow;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CalderaMonkey()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CalderaMonkey(Vector2 start_position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setFrame(int frame)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveFrontLayer(SpriteBatch b)
	{
	}
}
