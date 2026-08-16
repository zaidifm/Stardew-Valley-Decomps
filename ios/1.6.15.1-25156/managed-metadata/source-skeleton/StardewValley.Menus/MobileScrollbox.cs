using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class MobileScrollbox
{
	public Rectangle Bounds;

	public Rectangle scissorRectangle;

	public MobileScrollbar scrollBar;

	public bool panelScrolling;

	public bool havePanelScrolled;

	public bool scrollingWithMomentum;

	public int yOffsetForScroll;

	public int panelScrollStartY;

	public int yOffSetAtStartOfPanelScroll;

	public int lastYValue;

	private float[] speedMeasure;

	private int currentSpeedMeasure;

	private float speed;

	private const float minSpeed = 1f;

	private const float dampingFactor = 1.05f;

	public int maxYOffset;

	private RasterizerState _rasterizerState;

	private Rectangle _scissorRectangleBackup;

	private const int yChangeToRegisterScroll = 12;

	private static int oldYDiff;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileScrollbox(int boxX, int boxY, int boxWidth, int boxHeight, int boxContentHeight, Rectangle clipRect, MobileScrollbar scrollBar = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpForScrollBoxDrawing(SpriteBatch b, float scale = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void finishScrollBoxDrawing(SpriteBatch b, float scale = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setMaxYOffset(int offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getMaxYOffset()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setYOffsetForScroll(int offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getYOffsetForScroll()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveScrollWheelAction(int direction)
	{
	}
}
