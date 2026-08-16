using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class ScreenSwipe
{
	public const int swipe_bundleComplete = 0;

	public const int swipe_raccoon = 1;

	public const int borderPixelWidth = 7;

	private Rectangle bgSource;

	private Rectangle flairSource;

	private Rectangle messageSource;

	private Rectangle movingFlairSource;

	private Rectangle bgDest;

	private int yPosition;

	private int durationAfterSwipe;

	private int originalBGSourceXLimit;

	private List<Vector2> flairPositions;

	private Vector2 messagePosition;

	private Vector2 movingFlairPosition;

	private Vector2 movingFlairMotion;

	private float swipeVelocity;

	private Texture2D texture;

	private int width;

	private int height;

	private int ViewportWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private int ViewportHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScreenSwipe(int which, float swipeVelocity = -1f, int durationAfterSwipe = -1, int w = -1, int h = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle getAdjustedSourceRect(Rectangle sourceRect, float xStartPosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}
}
