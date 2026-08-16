using System;
using System.Collections.Generic;
using Netcode;

namespace StardewValley.Extensions;

public static class CollectionExtensions
{
	public static int RemoveWhere<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, Func<KeyValuePair<TKey, TValue>, bool> match)
	{
		if (dictionary.Count == 0)
		{
			return 0;
		}
		int num = 0;
		foreach (KeyValuePair<TKey, TValue> item in dictionary)
		{
			if (match(item))
			{
				dictionary.Remove(item.Key);
				num++;
			}
		}
		return num;
	}

	public static int TryAddMany<TKey, TValue>(this IDictionary<TKey, TValue> dict, Dictionary<TKey, TValue> values)
	{
		if (values == null)
		{
			return 0;
		}
		int num = 0;
		foreach (KeyValuePair<TKey, TValue> value in values)
		{
			if (dict.TryAdd(value.Key, value.Value))
			{
				num++;
			}
		}
		return num;
	}

	public static int RemoveWhere<T>(this IList<T> list, Predicate<T> match)
	{
		if (list is List<T> list2)
		{
			return list2.RemoveAll(match);
		}
		int num = 0;
		for (int num2 = list.Count - 1; num2 >= 0; num2--)
		{
			if (match(list[num2]))
			{
				list.RemoveAt(num2);
				num++;
			}
		}
		return num;
	}

	public static void Toggle<T>(this ISet<T> set, T value, bool add)
	{
		if (add)
		{
			set.Add(value);
		}
		else
		{
			set.Remove(value);
		}
	}

	public static int AddRange<T>(this ISet<T> set, IEnumerable<T> values)
	{
		if (values == null)
		{
			return 0;
		}
		int num = 0;
		foreach (T value in values)
		{
			if (set.Add(value))
			{
				num++;
			}
		}
		return num;
	}

	public static int RemoveWhere<T>(this ISet<T> set, Predicate<T> match)
	{
		if (!(set is HashSet<T> hashSet))
		{
			if (set is NetHashSet<T> netHashSet)
			{
				return netHashSet.RemoveWhere(match);
			}
			List<T> list = null;
			foreach (T item in set)
			{
				if (match(item))
				{
					if (list == null)
					{
						list = new List<T>();
					}
					list.Add(item);
				}
			}
			if (list != null)
			{
				foreach (T item2 in list)
				{
					set.Remove(item2);
				}
				return list.Count;
			}
			return 0;
		}
		return hashSet.RemoveWhere(match);
	}
}
