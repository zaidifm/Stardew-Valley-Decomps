using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.TerrainFeatures;

public class Leaf
{
	public Vector2 position;

	public float rotation;

	public float rotationRate;

	public float yVelocity;

	public int type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Leaf(Vector2 position, float rotationRate, int type, float yVelocity)
	{
	}
}
