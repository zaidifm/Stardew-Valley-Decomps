using System;
using System.IO;

namespace StardewValley;

internal static class LegacyShims
{
	public static T[] EmptyArray<T>()
	{
		return Array.Empty<T>();
	}

	public static string[] SplitAndTrim(string str, char separator, StringSplitOptions options = StringSplitOptions.None)
	{
		return str.Split(separator, options | StringSplitOptions.TrimEntries);
	}

	public static string[] SplitAndTrim(string str, string separator, StringSplitOptions options = StringSplitOptions.None)
	{
		return str.Split(separator, options | StringSplitOptions.TrimEntries);
	}

	public static void MoveFileWithOverwrite(string sourceFilePath, string destFilePath)
	{
		File.Move(sourceFilePath, destFilePath, overwrite: true);
	}
}
