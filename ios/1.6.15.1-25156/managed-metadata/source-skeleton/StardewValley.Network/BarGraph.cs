using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Network;

public class BarGraph
{
	public static double DYNAMIC_SCALE_MAX;

	public static double DYNAMIC_SCALE_AVG;

	private Queue<double> elements;

	private int height;

	private int width;

	private int x;

	private int y;

	private double maxValue;

	private Color barColor;

	private int elementWidth;

	private Texture2D whiteTexture;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BarGraph(Queue<double> elements, int x, int y, int width, int height, int elementWidth, double maxValue, Color barColor, Texture2D whiteTexture)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(SpriteBatch sb)
	{
	}
}
