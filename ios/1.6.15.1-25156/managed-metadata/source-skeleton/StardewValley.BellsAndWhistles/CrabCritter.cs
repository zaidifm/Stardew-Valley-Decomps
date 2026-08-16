using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class CrabCritter : Critter
{
	public Rectangle movementRectangle;

	public float nextCharacterCheck;

	public float nextFrameChange;

	public float nextMovementChange;

	public bool moving;

	public bool diving;

	public bool skittering;

	protected float skitterTime;

	protected Rectangle _baseSourceRectangle;

	protected int _currentFrame;

	protected int _crabVariant;

	protected Vector2 movementDirection;

	public Rectangle movementBounds;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrabCritter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrabCritter(Vector2 start_position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateSpriteRectangle()
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
