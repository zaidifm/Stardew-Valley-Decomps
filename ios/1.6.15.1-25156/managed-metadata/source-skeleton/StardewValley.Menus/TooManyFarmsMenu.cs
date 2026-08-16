using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class TooManyFarmsMenu : IClickableMenu
{
	public const int cWidth = 800;

	public const int cHeight = 180;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TooManyFarmsMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawBox(SpriteBatch b, int xPos, int yPos, int boxWidth, int boxHeight)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
