using System;
using System.Collections.Generic;

namespace StardewValley.Util;

public static class DictionarySaver<TKey, TValue>
{
	public static SaveablePair<TKey, TValue>[] ArrayFrom(IDictionary<TKey, TValue> data)
	{
		SaveablePair<TKey, TValue>[] array = new SaveablePair<TKey, TValue>[data?.Count ?? 0];
		int num = 0;
		if (data != null)
		{
			foreach (KeyValuePair<TKey, TValue> datum in data)
			{
				array[num++] = new SaveablePair<TKey, TValue>(datum.Key, datum.Value);
			}
		}
		return array;
	}

	public static SaveablePair<TKey, TValue>[] ArrayFrom<TSourceValue>(IDictionary<TKey, TSourceValue> data, Func<TSourceValue, TValue> getValue)
	{
		SaveablePair<TKey, TValue>[] array = new SaveablePair<TKey, TValue>[data?.Count ?? 0];
		int num = 0;
		if (data != null)
		{
			foreach (KeyValuePair<TKey, TSourceValue> datum in data)
			{
				array[num++] = new SaveablePair<TKey, TValue>(datum.Key, getValue(datum.Value));
			}
		}
		return array;
	}

	public static SaveablePair<TKey, TValue>[] ArrayFrom<TSourceKey, TSourceValue>(IDictionary<TSourceKey, TSourceValue> data, Func<TSourceKey, TKey> getKey, Func<TSourceValue, TValue> getValue)
	{
		SaveablePair<TKey, TValue>[] array = new SaveablePair<TKey, TValue>[data?.Count ?? 0];
		int num = 0;
		if (data != null)
		{
			foreach (KeyValuePair<TSourceKey, TSourceValue> datum in data)
			{
				array[num++] = new SaveablePair<TKey, TValue>(getKey(datum.Key), getValue(datum.Value));
			}
		}
		return array;
	}
}
