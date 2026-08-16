using System.Collections.Generic;

namespace StardewValley.Util;

public static class SaveablePairExtensions
{
	public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this SaveablePair<TKey, TValue>[] pairs)
	{
		Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
		if (pairs != null)
		{
			for (int i = 0; i < pairs.Length; i++)
			{
				SaveablePair<TKey, TValue> saveablePair = pairs[i];
				dictionary[saveablePair.Key] = saveablePair.Value;
			}
		}
		return dictionary;
	}

	public static SaveablePair<TKey, TValue>[] ToSaveableArray<TKey, TValue>(this IDictionary<TKey, TValue> data)
	{
		return DictionarySaver<TKey, TValue>.ArrayFrom(data);
	}
}
