using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Extensions;

public static class CollectionExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int RemoveWhere<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, Func<KeyValuePair<TKey, TValue>, bool> match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TryAddMany<TKey, TValue>(this IDictionary<TKey, TValue> dict, Dictionary<TKey, TValue> values)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int RemoveWhere<T>(this IList<T> list, Predicate<T> match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Toggle<T>(this ISet<T> set, T value, bool add)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int AddRange<T>(this ISet<T> set, IEnumerable<T> values)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int RemoveWhere<T>(this ISet<T> set, Predicate<T> match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
