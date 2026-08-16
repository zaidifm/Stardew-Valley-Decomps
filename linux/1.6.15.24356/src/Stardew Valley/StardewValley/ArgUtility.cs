using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public static class ArgUtility
{
	public static string[] SplitBySpace(string value)
	{
		return value?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? LegacyShims.EmptyArray<string>();
	}

	public static string[] SplitBySpace(string value, int limit)
	{
		return value?.Split(' ', limit, StringSplitOptions.RemoveEmptyEntries) ?? LegacyShims.EmptyArray<string>();
	}

	public static string SplitBySpaceAndGet(string value, int index, string defaultValue = null)
	{
		if (value == null)
		{
			return defaultValue;
		}
		return Get(value.Split(' ', index + 2, StringSplitOptions.RemoveEmptyEntries), index, defaultValue);
	}

	public static string[] SplitBySpaceQuoteAware(string input)
	{
		return SplitQuoteAware(input, ' ', StringSplitOptions.RemoveEmptyEntries);
	}

	public static string[] SplitQuoteAware(string input, char delimiter, StringSplitOptions splitOptions = StringSplitOptions.None, bool keepQuotesAndEscapes = false)
	{
		if (string.IsNullOrEmpty(input))
		{
			return LegacyShims.EmptyArray<string>();
		}
		if (!input.Contains('"'))
		{
			return input.Split(delimiter, splitOptions);
		}
		bool flag = false;
		if (splitOptions.HasFlag(StringSplitOptions.TrimEntries))
		{
			flag = true;
			splitOptions &= ~StringSplitOptions.TrimEntries;
		}
		bool flag2 = splitOptions.HasFlag(StringSplitOptions.RemoveEmptyEntries);
		string[] array = input.Split('"');
		List<string> list = new List<string>(array.Length * 4);
		bool flag3 = true;
		bool flag4 = true;
		string text = null;
		int i = 0;
		for (int num = array.Length - 1; i <= num; i++)
		{
			flag3 = !flag3;
			string text2 = array[i];
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = text2.EndsWith(delimiter);
			if (keepQuotesAndEscapes && i != 0)
			{
				text2 = "\"" + text2;
			}
			if (!flag4)
			{
				if (text.EndsWith('\\'))
				{
					text2 = (keepQuotesAndEscapes ? (text + text2) : (text.Substring(0, text.Length - 1) + "\"" + text2));
					flag3 = !flag3;
					flag5 = true;
				}
				else if (flag3 || !text2.StartsWith(delimiter))
				{
					flag6 = true;
				}
				else
				{
					text2 = text2.Substring(1);
				}
			}
			if (list.Count == 0)
			{
				flag5 = false;
				flag6 = false;
			}
			if (flag3)
			{
				flag7 = false;
				if (flag5)
				{
					list[list.Count - 1] = text2;
				}
				else if (flag6)
				{
					list[list.Count - 1] += text2;
					text2 = list[list.Count - 1];
				}
				else
				{
					list.Add(text2);
				}
				text = text2;
				flag4 = false;
				continue;
			}
			if (flag7 && !flag2 && i != num && text2.Length > 0)
			{
				text2 = text2.Substring(0, text2.Length - 1);
			}
			string[] array2 = text2.Split(delimiter, splitOptions);
			int num2 = array2.Length;
			if (num2 != 0)
			{
				if (num2 == 1 && flag7 && array2[0] == string.Empty)
				{
					text = string.Empty;
				}
				else
				{
					if (flag5)
					{
						list.RemoveAt(list.Count - 1);
						list.AddRange(array2);
					}
					else if (flag6)
					{
						list[list.Count - 1] += array2[0];
						if (array2.Length > 1)
						{
							list.AddRange(new ArraySegment<string>(array2, 1, array2.Length - 1));
						}
					}
					else
					{
						list.AddRange(array2);
					}
					text = array2[^1];
				}
			}
			else
			{
				text = string.Empty;
			}
			flag4 = flag7;
		}
		if (flag)
		{
			for (int num3 = list.Count - 1; num3 >= 0; num3--)
			{
				list[num3] = list[num3].Trim();
				if (flag2 && list[num3].Length == 0)
				{
					list.RemoveAt(num3);
				}
			}
		}
		return list.ToArray();
	}

	public static string UnsplitQuoteAware(string[] input, char delimiter, int startAt = 0, int count = int.MaxValue)
	{
		if (startAt < 0)
		{
			throw new ArgumentException("Can't start unsplitting before the bounds of the array.", "startAt");
		}
		if (input == null || count == 0 || startAt >= input.Length)
		{
			return string.Empty;
		}
		count = Math.Min(count, input.Length - startAt);
		string[] array = new string[count];
		int i = startAt;
		for (int num = startAt + count - 1; i <= num; i++)
		{
			string text = input[i];
			if (text.Contains('"'))
			{
				text = EscapeQuotes(text);
			}
			if (text.Contains(delimiter))
			{
				text = "\"" + text + "\"";
			}
			array[i - startAt] = text;
		}
		return string.Join(delimiter, array);
	}

	public static string EscapeQuotes(string input)
	{
		return input.Replace("\"", "\\\"");
	}

	public static bool HasIndex<T>(T[] array, int index)
	{
		if (index >= 0)
		{
			if (array == null)
			{
				return false;
			}
			return array.Length > index;
		}
		return false;
	}

	public static T[] GetSubsetOf<T>(T[] array, int startAt, int length = -1)
	{
		if (startAt < 0)
		{
			throw new ArgumentException("Can't start copying before the bounds of the array.", "startAt");
		}
		if (array == null || length == 0 || startAt > array.Length - 1)
		{
			return LegacyShims.EmptyArray<T>();
		}
		if (startAt == 0 && (length == -1 || length == array.Length))
		{
			return array.ToArray();
		}
		if (length < 0)
		{
			length = array.Length - startAt;
		}
		T[] array2 = new T[length];
		Array.Copy(array, startAt, array2, 0, length);
		return array2;
	}

	public static string Get(string[] array, int index, string defaultValue = null, bool allowBlank = true)
	{
		if (index >= 0 && index < array?.Length)
		{
			string text = array[index];
			if (allowBlank || !string.IsNullOrWhiteSpace(text))
			{
				return text;
			}
		}
		return defaultValue;
	}

	public static bool TryGet(string[] array, int index, out string value, out string error, bool allowBlank = true, [CallerArgumentExpression("value")] string name = null)
	{
		if (array == null)
		{
			value = null;
			error = "argument list is null";
			return false;
		}
		if (index < 0 || index >= array.Length)
		{
			value = null;
			error = GetMissingRequiredIndexError(array, index, name);
			return false;
		}
		value = array[index];
		if (!allowBlank && string.IsNullOrWhiteSpace(value))
		{
			value = null;
			error = "required " + GetFieldLabel(index, name) + " has a blank value";
			return false;
		}
		error = null;
		return true;
	}

	public static bool TryGetOptional(string[] array, int index, out string value, out string error, string defaultValue = null, bool allowBlank = true, [CallerArgumentExpression("value")] string name = null)
	{
		if (array == null || index < 0 || index >= array.Length || (!allowBlank && array[index] == string.Empty))
		{
			value = defaultValue;
			error = null;
			return true;
		}
		value = array[index];
		if (!allowBlank && string.IsNullOrWhiteSpace(value))
		{
			value = defaultValue;
			error = "optional " + GetFieldLabel(index, name) + " can't have a blank value";
			return false;
		}
		error = null;
		return true;
	}

	public static bool GetBool(string[] array, int index, bool defaultValue = false)
	{
		if (!bool.TryParse(Get(array, index), out var result))
		{
			return defaultValue;
		}
		return result;
	}

	public static bool TryGetBool(string[] array, int index, out bool value, out string error, [CallerArgumentExpression("value")] string name = null)
	{
		if (!TryGet(array, index, out var value2, out error, allowBlank: false, name))
		{
			value = false;
			return false;
		}
		if (!bool.TryParse(value2, out value))
		{
			value = false;
			error = GetValueParseError(array, index, name, required: true, "a boolean (should be 'true' or 'false')");
			return false;
		}
		error = null;
		return true;
	}

	public static bool TryGetOptionalBool(string[] array, int index, out bool value, out string error, bool defaultValue = false, [CallerArgumentExpression("value")] string name = null)
	{
		if (array == null || index < 0 || index >= array.Length || array[index] == string.Empty)
		{
			error = null;
			value = defaultValue;
			return true;
		}
		if (!bool.TryParse(array[index], out value))
		{
			error = GetValueParseError(array, index, name, required: false, "a boolean");
			value = defaultValue;
			return false;
		}
		error = null;
		return true;
	}

	public static int GetDirection(string[] array, int index, int defaultValue = 0)
	{
		if (!Utility.TryParseDirection(Get(array, index), out var parsed))
		{
			return defaultValue;
		}
		return parsed;
	}

	public static bool TryGetDirection(string[] array, int index, out int value, out string error, [CallerArgumentExpression("value")] string name = null)
	{
		if (!TryGet(array, index, out var value2, out error, allowBlank: false, name))
		{
			value = 0;
			return false;
		}
		if (!Utility.TryParseDirection(value2, out value))
		{
			value = 0;
			error = GetValueParseError(array, index, name, required: true, "a direction (should be 'up', 'down', 'left', or 'right')");
			return false;
		}
		error = null;
		return true;
	}

	public static bool TryGetOptionalDirection(string[] array, int index, out int value, out string error, int defaultValue = 0, [CallerArgumentExpression("value")] string name = null)
	{
		if (array == null || index < 0 || index >= array.Length || array[index] == string.Empty)
		{
			error = null;
			value = defaultValue;
			return true;
		}
		if (!Utility.TryParseDirection(array[index], out value))
		{
			error = GetValueParseError(array, index, name, required: true, "a direction (should be one of 'up', 'down', 'left', or 'right')");
			value = defaultValue;
			return false;
		}
		error = null;
		return true;
	}

	public static TEnum GetEnum<TEnum>(string[] array, int index, TEnum defaultValue = default(TEnum)) where TEnum : struct
	{
		if (!Utility.TryParseEnum<TEnum>(Get(array, index), out var parsed))
		{
			return defaultValue;
		}
		return parsed;
	}

	public static bool TryGetEnum<TEnum>(string[] array, int index, out TEnum value, out string error, [CallerArgumentExpression("value")] string name = null) where TEnum : struct
	{
		if (!TryGet(array, index, out var value2, out error, allowBlank: false, name))
		{
			value = default(TEnum);
			return false;
		}
		if (!Utility.TryParseEnum<TEnum>(value2, out value))
		{
			Type typeFromHandle = typeof(TEnum);
			value = default(TEnum);
			error = GetValueParseError(array, index, name, required: true, $"an enum of type '{typeFromHandle.FullName ?? typeFromHandle.Name}' (should be one of {string.Join(", ", Enum.GetNames(typeof(TEnum)))})");
			return false;
		}
		error = null;
		return true;
	}

	public static bool TryGetOptionalEnum<TEnum>(string[] array, int index, out TEnum value, out string error, TEnum defaultValue = default(TEnum), [CallerArgumentExpression("value")] string name = null) where TEnum : struct
	{
		if (array == null || index < 0 || index >= array.Length || array[index] == string.Empty)
		{
			error = null;
			value = defaultValue;
			return true;
		}
		if (!Utility.TryParseEnum<TEnum>(array[index], out value))
		{
			Type typeFromHandle = typeof(TEnum);
			error = GetValueParseError(array, index, name, required: false, "an enum of type '" + (typeFromHandle.FullName ?? typeFromHandle.Name) + "'");
			value = defaultValue;
			return false;
		}
		error = null;
		return true;
	}

	public static float GetFloat(string[] array, int index, float defaultValue = 0f)
	{
		if (!float.TryParse(Get(array, index), out var result))
		{
			return defaultValue;
		}
		return result;
	}

	public static bool TryGetFloat(string[] array, int index, out float value, out string error, [CallerArgumentExpression("value")] string name = null)
	{
		if (!TryGet(array, index, out var value2, out error, allowBlank: false, name))
		{
			value = 0f;
			return false;
		}
		if (!float.TryParse(value2, out value))
		{
			value = 0f;
			error = GetValueParseError(array, index, name, required: true, "a number");
			return false;
		}
		error = null;
		return true;
	}

	public static bool TryGetOptionalFloat(string[] array, int index, out float value, out string error, float defaultValue = 0f, [CallerArgumentExpression("value")] string name = null)
	{
		if (array == null || index < 0 || index >= array.Length || array[index] == string.Empty)
		{
			error = null;
			value = defaultValue;
			return true;
		}
		if (!float.TryParse(array[index], out value))
		{
			error = GetValueParseError(array, index, name, required: false, "a float");
			value = defaultValue;
			return false;
		}
		error = null;
		return true;
	}

	public static int GetInt(string[] array, int index, int defaultValue = 0)
	{
		if (!int.TryParse(Get(array, index), out var result))
		{
			return defaultValue;
		}
		return result;
	}

	public static bool TryGetInt(string[] array, int index, out int value, out string error, [CallerArgumentExpression("value")] string name = null)
	{
		if (!TryGet(array, index, out var value2, out error, allowBlank: false, name))
		{
			value = 0;
			return false;
		}
		if (!int.TryParse(value2, out value))
		{
			value = 0;
			error = GetValueParseError(array, index, name, required: true, "an integer");
			return false;
		}
		error = null;
		return true;
	}

	public static bool TryGetOptionalInt(string[] array, int index, out int value, out string error, int defaultValue = 0, [CallerArgumentExpression("value")] string name = null)
	{
		if (array == null || index < 0 || index >= array.Length || array[index] == string.Empty)
		{
			error = null;
			value = defaultValue;
			return true;
		}
		if (!int.TryParse(array[index], out value))
		{
			error = GetValueParseError(array, index, name, required: false, "an integer");
			value = defaultValue;
			return false;
		}
		error = null;
		return true;
	}

	public static bool TryGetPoint(string[] array, int index, out Point value, out string error, [CallerArgumentExpression("value")] string name = null)
	{
		if (!TryGetInt(array, index, out var value2, out error, (name != null) ? (name + " > x") : null) || !TryGetInt(array, index + 1, out var value3, out error, (name != null) ? (name + " > y") : null))
		{
			value = Point.Zero;
			return false;
		}
		error = null;
		value = new Point(value2, value3);
		return true;
	}

	public static bool TryGetRectangle(string[] array, int index, out Rectangle value, out string error, [CallerArgumentExpression("value")] string name = null)
	{
		if (!TryGetInt(array, index, out var value2, out error, (name != null) ? (name + " > x") : null) || !TryGetInt(array, index + 1, out var value3, out error, (name != null) ? (name + " > y") : null) || !TryGetInt(array, index + 2, out var value4, out error, (name != null) ? (name + " > width") : null) || !TryGetInt(array, index + 3, out var value5, out error, (name != null) ? (name + " > height") : null))
		{
			value = Rectangle.Empty;
			return false;
		}
		error = null;
		value = new Rectangle(value2, value3, value4, value5);
		return true;
	}

	public static bool TryGetVector2(string[] array, int index, out Vector2 value, out string error, bool integerOnly = false, [CallerArgumentExpression("value")] string name = null)
	{
		string name2 = ((name != null) ? (name + " > x") : null);
		string name3 = ((name != null) ? (name + " > y") : null);
		float value4;
		float value5;
		if (integerOnly)
		{
			if (TryGetInt(array, index, out var value2, out error, name2) && TryGetInt(array, index + 1, out var value3, out error, name3))
			{
				value = new Vector2(value2, value3);
				return true;
			}
		}
		else if (TryGetFloat(array, index, out value4, out error, name2) && TryGetFloat(array, index + 1, out value5, out error, name3))
		{
			value = new Vector2(value4, value5);
			return true;
		}
		value = Vector2.Zero;
		return false;
	}

	public static string GetRemainder(string[] array, int index, string defaultValue = null, char delimiter = ' ')
	{
		if (array == null || index < 0 || index >= array.Length)
		{
			return defaultValue;
		}
		if (array.Length - index == 1)
		{
			return array[index];
		}
		return string.Join(delimiter, array[index..]);
	}

	public static bool TryGetRemainder(string[] array, int index, out string value, out string error, char delimiter = ' ', [CallerArgumentExpression("value")] string name = null)
	{
		if (array == null)
		{
			value = null;
			error = "argument list is null";
			return false;
		}
		if (index < 0 || index >= array.Length)
		{
			value = null;
			error = GetMissingRequiredIndexError(array, index, name);
			return false;
		}
		if (array.Length - index == 1)
		{
			value = array[index];
		}
		else
		{
			value = string.Join(delimiter, array[index..]);
		}
		error = null;
		return true;
	}

	public static bool TryGetOptionalRemainder(string[] array, int index, out string value, string defaultValue = null, char delimiter = ' ')
	{
		if (array == null || index < 0 || index >= array.Length)
		{
			value = defaultValue;
			return true;
		}
		if (array.Length - index == 1)
		{
			value = array[index];
		}
		else
		{
			value = string.Join(delimiter, array[index..]);
		}
		return true;
	}

	internal static string GetMissingRequiredIndexError(string[] array, int index, string name)
	{
		return array.Length switch
		{
			0 => "required " + GetFieldLabel(index, name) + " not found (list is empty)", 
			1 => "required " + GetFieldLabel(index, name) + " not found (list has a single value at index 0)", 
			_ => $"required {GetFieldLabel(index, name)} not found (list has indexes 0 through {array.Length - 1})", 
		};
	}

	internal static string GetValueParseError(string[] array, int index, string name, bool required, string typeSummary)
	{
		return $"{(required ? "required" : "optional")} {GetFieldLabel(index, name)} has value '{array[index]}', which can't be parsed as {typeSummary}";
	}

	private static string GetFieldLabel(int index, string name)
	{
		if (name != null)
		{
			return $"index {index} ({name})";
		}
		return $"index {index}";
	}
}
