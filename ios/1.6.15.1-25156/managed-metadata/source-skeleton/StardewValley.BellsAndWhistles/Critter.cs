using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public abstract class Critter
{
	public const int spriteWidth = 32;

	public const int spriteHeight = 32;

	public const float gravity = 0.25f;

	public static string critterTexture;

	public Vector2 position;

	public Vector2 startingPosition;

	public int baseFrame;

	public AnimatedSprite sprite;

	public bool flip;

	public float gravityAffectedDY;

	public float yOffset;

	public float yJumpOffset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Critter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Critter(int baseFrame, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle getBoundingBox(int xOffset, int yOffset)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawAboveFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string GenerateLightSourceId(int identifier)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
