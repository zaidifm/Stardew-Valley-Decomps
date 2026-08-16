using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Locations;
using xTile.Dimensions;

namespace StardewValley;

public class Background
{
	public int defaultChunkIndex;

	public int numChunksInSheet;

	public double chanceForDeviationFromDefault;

	protected Texture2D backgroundImage;

	protected Texture2D cloudsTexture;

	protected Vector2 position;

	protected int chunksWide;

	protected int chunksHigh;

	protected int chunkWidth;

	protected int chunkHeight;

	protected int[] chunks;

	protected float zoom;

	public Color c;

	protected bool summitBG;

	protected bool onlyMapBG;

	public int yOffset;

	public TemporaryAnimatedSpriteList tempSprites;

	protected int initialViewportY;

	public bool cursed;

	protected GameLocation location;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Background(Summit location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Background(GameLocation location, Color color, bool onlyMapBG)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Background(GameLocation location, Texture2D bgImage, int seedValue, int chunksWide, int chunksHigh, int chunkWidth, int chunkHeight, float zoom, int defaultChunkIndex, int numChunksInSheet, double chanceForDeviation, Color c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void update(xTile.Dimensions.Rectangle viewport)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}
}
