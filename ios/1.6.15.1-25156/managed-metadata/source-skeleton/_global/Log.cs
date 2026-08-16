using System;
using System.Runtime.CompilerServices;

internal class Log
{
	public static bool enabled;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void It(string s)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Exception(Exception exception)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Exception(Exception exception, string someText)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Log()
	{
	}
}
