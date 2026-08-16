using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

[InstanceStatics]
public class WeatherDebris
{
	public const int pinkPetals = 0;

	public const int greenLeaves = 1;

	public const int fallLeaves = 2;

	public const int snow = 3;

	public const int animationInterval = 100;

	public const float gravity = -0.5f;

	public Vector2 position;

	public Rectangle sourceRect;

	public int which;

	public int animationIndex;

	public int animationTimer;

	public int animationDirection;

	public int animationIntervalOffset;

	public float dx;

	public float dy;

	public static float globalWind;

	private bool blowing;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WeatherDebris()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WeatherDebris(Vector2 position, int which, float rotationVelocity, float dx, float dy)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Initialize(Vector2 position, int which, float rotationVelocity, float dx, float dy)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void update(bool slow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}
}
