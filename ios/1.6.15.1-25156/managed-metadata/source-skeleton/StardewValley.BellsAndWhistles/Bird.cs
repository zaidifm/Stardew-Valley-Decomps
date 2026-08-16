using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class Bird
{
	public enum BirdState
	{
		Idle,
		Flying
	}

	public Vector2 position;

	public Point startPosition;

	public Point endPosition;

	public float pathPosition;

	public float velocity;

	public int framesUntilNextMove;

	public BirdState birdState;

	public PerchingBirds context;

	public int peckFrames;

	public int nextPeck;

	public int peckDirection;

	public int birdType;

	public int flapFrames;

	public float flyArcHeight;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bird()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bird(Point point, PerchingBirds context, int bird_type = 0, int flap_frames = 2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FlyToNewPoint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}
}
