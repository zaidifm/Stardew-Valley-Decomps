using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public abstract class ICreditsBlock
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(int topLeftX, int topLeftY, int widthToOccupy, SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getHeight(int maxWidth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void hovered()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void clicked()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ICreditsBlock()
	{
	}
}
