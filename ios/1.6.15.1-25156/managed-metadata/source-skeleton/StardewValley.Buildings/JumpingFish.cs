using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Buildings;

public class JumpingFish
{
	public Vector2 startPosition;

	public Vector2 endPosition;

	protected float _age;

	public float jumpTime;

	protected FishPond _pond;

	protected Object _fishObject;

	protected bool _flipped;

	public Vector2 position;

	public float jumpHeight;

	public float angularVelocity;

	public float angle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JumpingFish(FishPond pond, Vector2 start_position, Vector2 end_position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Splash()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Update(float time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(SpriteBatch b)
	{
	}
}
