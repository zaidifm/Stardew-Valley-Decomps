using System;
using System.Runtime.CompilerServices;

internal class MonoPInvokeCallbackAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonoPInvokeCallbackAttribute(Type type)
	{
	}
}
