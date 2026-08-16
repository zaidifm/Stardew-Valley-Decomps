using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Locations;

public class Wisp
{
	public Vector2 position;

	public Vector2 drawPosition;

	public Vector2[] oldPositions;

	public int oldPositionIndex;

	public int index;

	public int tailUpdateTimer;

	public float rotationSpeed;

	public float rotationOffset;

	public float rotationRadius;

	public float age;

	public float lifeTime;

	public Color baseColor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Wisp(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Reinitialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}
}
