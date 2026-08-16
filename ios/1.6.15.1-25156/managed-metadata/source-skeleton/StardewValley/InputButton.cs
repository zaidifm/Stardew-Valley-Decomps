using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Input;

namespace StardewValley;

public struct InputButton
{
	public Keys key;

	public bool mouseLeft;

	public bool mouseRight;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputButton(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputButton(bool mouseLeft)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
