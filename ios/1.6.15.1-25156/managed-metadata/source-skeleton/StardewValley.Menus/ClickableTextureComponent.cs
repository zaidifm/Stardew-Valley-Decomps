using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ClickableTextureComponent : ClickableComponent
{
	public Texture2D texture;

	public Rectangle sourceRect;

	public Rectangle startingSourceRect;

	public float baseScale;

	public string hoverText;

	public bool drawLabel;

	public bool drawShadow;

	public bool drawLabelWithShadow;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableTextureComponent(string name, Rectangle bounds, string label, string hoverText, Texture2D texture, Rectangle sourceRect, float scale, bool drawShadow = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableTextureComponent(Rectangle bounds, Texture2D texture, Rectangle sourceRect, float scale, bool drawShadow = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getVector2()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setPosition(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setPosition(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void tryHover(int x, int y, float maxScaleIncrease = 0.1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, Color c, float layerDepth, int frameOffset = 0, int xOffset = 0, int yOffset = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawItem(SpriteBatch b, int xOffset = 0, int yOffset = 0, float alpha = 1f)
	{
	}
}
