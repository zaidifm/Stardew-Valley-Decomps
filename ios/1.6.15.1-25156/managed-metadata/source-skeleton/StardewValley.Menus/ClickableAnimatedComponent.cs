using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ClickableAnimatedComponent : ClickableComponent
{
	public TemporaryAnimatedSprite sprite;

	public Rectangle sourceRect;

	public float baseScale;

	public string hoverText;

	private bool drawLabel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableAnimatedComponent(Rectangle bounds, string name, string hoverText, TemporaryAnimatedSprite sprite, bool drawLabel)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableAnimatedComponent(Rectangle bounds, string name, string hoverText, TemporaryAnimatedSprite sprite)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string tryHover(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}
}
