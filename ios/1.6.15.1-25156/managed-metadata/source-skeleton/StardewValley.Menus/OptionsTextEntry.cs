using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class OptionsTextEntry : OptionsElement
{
	public const int pixelsHigh = 11;

	public TextBox textBox;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsTextEntry(string label, int whichOption, int x = -1, int y = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, int slotX, int slotY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y)
	{
	}
}
