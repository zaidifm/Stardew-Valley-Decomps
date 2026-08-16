using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Ionic.Zlib;

[Guid("ebc25cf6-9120-4283-b972-0e5520d0000E")]
public class ZlibException : Exception
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZlibException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZlibException(string s)
	{
	}
}
