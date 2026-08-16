using System.Runtime.CompilerServices;

namespace ContentManifest.Internal;

internal class CHValue : CHParsable
{
	public CHValueUnion RawValue;

	public CHValueEnum ValueType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CHValue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parse(CHJsonParserContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object GetManagedObject()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
