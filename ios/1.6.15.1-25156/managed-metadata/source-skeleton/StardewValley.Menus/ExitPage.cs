using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ExitPage : IClickableMenu
{
	public ClickableComponent exitToTitle;

	public ClickableComponent exitToDesktop;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExitPage(int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
