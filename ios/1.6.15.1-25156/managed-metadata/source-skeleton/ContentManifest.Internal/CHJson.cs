using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal class CHJson : CHParsable
{
	public CHElement Element;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parse(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHJson()
	{
	}
}
