using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal interface CHParsable
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	void Parse(CHJsonParserContext context);
}
