using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal class CHObject : CHParsable
{
	public readonly Dictionary<string, object> Members;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parse(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHObject()
	{
	}
}
