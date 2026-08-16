using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Locations;

public class IslandForestLocation : IslandLocation
{
	protected Color _ambientLightColor;

	private List<Wisp> _wisps;

	private List<WeatherDebris> weatherDebris;

	protected Texture2D _rayTexture;

	protected int _raySeed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandForestLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandForestLocation(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void tryToAddCritters(bool onlyIfOnScreen = false)
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
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _updateWoodsLighting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateLocationSpecificWeatherDebris()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawRays(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}
}
