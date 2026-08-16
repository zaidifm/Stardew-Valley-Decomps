using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class OverheadParrot : Critter
{
	protected Texture2D _texture;

	public Vector2 velocity;

	public float age;

	public float flyOffset;

	public float height;

	public Rectangle sourceRect;

	public Vector2 drawOffset;

	public int[] spriteFlapFrames;

	public int currentFlapIndex;

	public int flapFrameAccumulator;

	public Vector2 swayAmount;

	public Vector2 lastDrawPosition;

	protected bool _shouldDrawShadow;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OverheadParrot(Vector2 start_position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetDrawPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetShadowPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
