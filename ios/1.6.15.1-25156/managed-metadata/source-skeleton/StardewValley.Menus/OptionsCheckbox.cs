using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class OptionsCheckbox : OptionsElement
{
	public const int HEIGHT = 72;

	public const int pixelsWide = 9;

	public bool isChecked;

	public static Rectangle sourceRectUnchecked;

	public static Rectangle sourceRectChecked;

	public override int ItemHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionsCheckbox(string label, int whichOption, int x = -1, int y = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, int slotX, int slotY)
	{
	}
}
