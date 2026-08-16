using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class HandPointer
{
	public const int TAP_SCREEN_X_Y = 0;

	public const int TAP_GRID_X_Y = 1;

	public const int TAP_HOLD_SCREEN_X_Y = 2;

	public const int TAP_HOLD_GRID_X_Y = 3;

	public const int DRAG_SCREEN = 4;

	public int X;

	public int Y;

	public int destX;

	public int destY;

	private ClickableTextureComponent hand;

	private tweeningSprite handSprite;

	private const int xOffset = 32;

	private const int yOffset = 32;

	private const float transitionTimeTap = 500f;

	private const float holdTimeTap = 500f;

	private const float transitionTimeTapHold = 500f;

	private const float holdTimeTapHold = 1000f;

	private const float transitionTimeDrag = 700f;

	private const float holdTimeDrag = 50f;

	private bool isHolding;

	public int mode;

	private ClickableTextureComponent buttonTarget;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandPointer(int x, int y, int mode = 0, int destX = -1, int destY = -1, ClickableTextureComponent buttonTarget = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void start()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetVector(Vector2 startPosition, Vector2 endPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}
}
