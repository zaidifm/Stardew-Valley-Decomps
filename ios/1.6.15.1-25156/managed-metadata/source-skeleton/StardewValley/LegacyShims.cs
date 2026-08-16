using System;
using System.Runtime.CompilerServices;

namespace StardewValley;

internal static class LegacyShims
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T[] EmptyArray<T>()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] SplitAndTrim(string str, char separator, StringSplitOptions options = StringSplitOptions.None)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] SplitAndTrim(string str, string separator, StringSplitOptions options = StringSplitOptions.None)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MoveFileWithOverwrite(string sourceFilePath, string destFilePath)
	{
	}
}
