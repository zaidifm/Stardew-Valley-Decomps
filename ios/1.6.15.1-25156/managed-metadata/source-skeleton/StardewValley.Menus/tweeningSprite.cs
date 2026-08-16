using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TinyTween;

namespace StardewValley.Menus;

public class tweeningSprite
{
	private Tween<Vector2> posTween;

	public bool tweening;

	public bool isInGameworld;

	private ClickableTextureComponent sprite;

	private Vector2 startPosition;

	private Vector2 endPosition;

	private float duration;

	private float scale;

	private Item item;

	private int worldStartX;

	private int worldStartY;

	private ClickableTextureComponent buttonTarget;

	private bool hold;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public tweeningSprite(Item i, ClickableTextureComponent spriteToCopy, Vector2 startPosition, Vector2 endPosition, float durationInMilliseconds, bool isInGameworld = false, float scale = 4f, ClickableTextureComponent buttonTarget = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUp(ClickableTextureComponent buttonTarget, float durationInMilliseconds, bool hold = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUp(Vector2 startPosition, Vector2 endPosition, float durationInMilliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetVector(Vector2 startPosition, Vector2 endPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void start()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void stop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void update(GameTime t)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}
}
