using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal class CHString : CHParsable
{
	public string RawString;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parse(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int ParseHexChar(char hexChar)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHString()
	{
	}
}
