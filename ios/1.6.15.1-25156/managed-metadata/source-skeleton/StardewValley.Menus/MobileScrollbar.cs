using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class MobileScrollbar
{
	public Rectangle Bounds;

	public ClickableTextureComponent upArrow;

	public ClickableTextureComponent downArrow;

	public ClickableTextureComponent slider;

	public ClickableTextureComponent top;

	public ClickableTextureComponent bottom;

	public Rectangle middle;

	private Texture2D middleTex;

	public int sliderMin;

	public int sliderMax;

	public float percentage;

	private int addWL;

	private int addWR;

	public bool showArrows;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileScrollbar(int x, int y, int width, int height, int additionalWidthLeft = 0, int additionalWidthRight = 0, bool showArrows = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setPercentage(float newPercent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float setY(int newY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool upArrowContains(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool downArrowContains(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool sliderContains(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool sliderRunnerContains(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
