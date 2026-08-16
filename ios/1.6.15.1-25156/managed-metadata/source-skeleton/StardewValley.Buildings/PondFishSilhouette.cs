using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Buildings;

public class PondFishSilhouette
{
	public Vector2 position;

	protected FishPond _pond;

	protected Object _fishObject;

	protected Vector2 _velocity;

	protected float nextDart;

	protected bool _upRight;

	protected float _age;

	protected float _wiggleTimer;

	protected float _sinkAmount;

	protected float _randomOffset;

	protected bool _flipped;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PondFishSilhouette(FishPond pond)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetDartTime()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMoving()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(float time)
	{
	}
}
