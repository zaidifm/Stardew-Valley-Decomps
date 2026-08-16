using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal class CHJsonParserContext
{
	public int ReadHead;

	public string JsonText;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHJsonParserContext(string jsonText)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SkipWhitespace()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AssertReadHeadIsValid()
	{
	}
}
