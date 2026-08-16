using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Locations;

public class BathHousePool : GameLocation
{
	public const float steamZoom = 4f;

	public const float steamYMotionPerMillisecond = 0.1f;

	private Texture2D steamAnimation;

	private Texture2D swimShadow;

	private Vector2 steamPosition;

	private float steamYOffset;

	private int swimShadowTimer;

	private int swimShadowFrame;

	private int _counter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BathHousePool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BathHousePool(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}
}
