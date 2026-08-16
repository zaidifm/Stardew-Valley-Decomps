using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

internal class LinkCreditsBlock : ICreditsBlock
{
	private string text;

	private string url;

	private bool currentlyHovered;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LinkCreditsBlock(string text, string url)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(int topLeftX, int topLeftY, int widthToOccupy, SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int getHeight(int maxWidth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void hovered()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LaunchBrowser(string url)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void clicked()
	{
	}
}
