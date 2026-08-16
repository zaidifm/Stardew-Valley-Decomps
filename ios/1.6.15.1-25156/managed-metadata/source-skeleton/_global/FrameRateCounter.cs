using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;

public class FrameRateCounter : DrawableGameComponent
{
	private LocalizedContentManager content;

	private SpriteBatch spriteBatch;

	private int frameRate;

	private int frameCounter;

	private TimeSpan elapsedTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FrameRateCounter(Game game)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LoadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UnloadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Draw(GameTime gameTime)
	{
	}
}
