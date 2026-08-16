using System;
using System.Runtime.CompilerServices;

namespace StardewValley;

public class AbortNetSynchronizerException : Exception
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbortNetSynchronizerException()
	{
	}
}
