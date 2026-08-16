using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class SparklingText
{
	public static int maxDistanceForSparkle;

	private SpriteFont font;

	private Color color;

	private Color sparkleColor;

	private bool rainbow;

	private int millisecondsDuration;

	private int amplitude;

	private int period;

	private int colorCycle;

	public string text;

	private float[] individualCharacterOffsets;

	public float offsetDecay;

	public float alpha;

	public float textWidth;

	public float drawnTextWidth;

	public float layerDepth;

	private double sparkleFrequency;

	private TemporaryAnimatedSpriteList sparkles;

	private Rectangle boundingBox;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SparklingText(SpriteFont font, string text, Color color, Color sparkleColor, bool rainbow = false, double sparkleFrequency = 0.1, int millisecondsDuration = 2500, int amplitude = -1, int speed = 500, float depth = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void incrementRainbowColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Color getRainbowColorFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, Vector2 onScreenPosition)
	{
	}
}
