using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal class CHArray : CHParsable
{
	private static readonly List<object> ElementList;

	public object[] Elements;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parse(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHArray()
	{
	}
}
