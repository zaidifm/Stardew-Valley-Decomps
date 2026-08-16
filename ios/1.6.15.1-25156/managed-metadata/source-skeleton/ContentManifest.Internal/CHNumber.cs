using System.Runtime.CompilerServices;
using System.Text;

namespace ContentManifest.Internal;

internal class CHNumber : CHParsable
{
	private static StringBuilder DoubleSb;

	public double RawDouble;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidPrefix(char prefixChar)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parse(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ParseDigits(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void EnsureStringBuilderInitialized()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHNumber()
	{
	}
}
