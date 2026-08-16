using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace StardewValley.Util;

internal class ProfanityFilter
{
	private readonly List<Regex> _words;

	private readonly StringBuilder _cleanup;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProfanityFilter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProfanityFilter(string profanityFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Filter(string words)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
