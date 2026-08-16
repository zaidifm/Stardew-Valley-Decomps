using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public class CosmeticDebris : TemporaryAnimatedSprite
{
	public const float gravity = 0.3f;

	public const float bounciness = 0.45f;

	private new Vector2 position;

	private new float rotation;

	private float rotationSpeed;

	private float xVelocity;

	private float yVelocity;

	private new Rectangle sourceRect;

	private int groundYLevel;

	private int disappearTimer;

	private int lightTailLength;

	private int timeToDisappearAfterReachingGround;

	private new int id;

	private new Color color;

	private ICue tapSound;

	private LightSource light;

	private Queue<Vector2> lightTail;

	private new Texture2D texture;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CosmeticDebris(Texture2D texture, Vector2 startingPosition, float rotationSpeed, float xVelocity, float yVelocity, int groundYLevel, Rectangle sourceRect, Color color, ICue tapSound, LightSource light, int lightTailLength, int disappearTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, bool localPosition = false, int xOffset = 0, int yOffset = 0, float extraAlpha = 1f)
	{
	}
}
