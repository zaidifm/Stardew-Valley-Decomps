using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal class CHElement : CHParsable
{
	public CHValue Value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parse(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHElement()
	{
	}
}
