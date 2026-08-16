using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal class CHBoolean : CHParsable
{
	public bool RawBoolean;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parse(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHBoolean()
	{
	}
}
