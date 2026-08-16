using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

internal class TextCreditsBlock : ICreditsBlock
{
	private string text;

	private Color color;

	private bool renderNameInEnglish;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TextCreditsBlock(string rawtext)
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
}
