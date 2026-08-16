using System;
using System.Runtime.CompilerServices;

namespace StardewValley;

public class DialogueLine
{
	public string Text;

	public Action SideEffects;

	public bool HasText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogueLine(string text, Action sideEffects = null)
	{
	}
}
