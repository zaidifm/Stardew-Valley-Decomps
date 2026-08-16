using System;

namespace StardewValley.Extensions;

public static class StringExtensions
{
	public static bool ContainsIgnoreCase(this string str, string value)
	{
		return str?.Contains(value, StringComparison.OrdinalIgnoreCase) ?? false;
	}

	public static bool EqualsIgnoreCase(this string str, string value)
	{
		return string.Equals(str, value, StringComparison.OrdinalIgnoreCase);
	}

	public static int IndexOfIgnoreCase(this string str, string value)
	{
		return str?.IndexOf(value, StringComparison.OrdinalIgnoreCase) ?? (-1);
	}

	public static bool StartsWithIgnoreCase(this string str, string value)
	{
		return str?.StartsWith(value, StringComparison.OrdinalIgnoreCase) ?? false;
	}

	public static bool EndsWithIgnoreCase(this string str, string value)
	{
		return str?.EndsWith(value, StringComparison.OrdinalIgnoreCase) ?? false;
	}
}
