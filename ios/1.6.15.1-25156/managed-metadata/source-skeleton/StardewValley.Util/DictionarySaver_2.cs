using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Util;

public static class DictionarySaver<TKey, TValue>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SaveablePair<TKey, TValue>[] ArrayFrom(IDictionary<TKey, TValue> data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SaveablePair<TKey, TValue>[] ArrayFrom<TSourceValue>(IDictionary<TKey, TSourceValue> data, Func<TSourceValue, TValue> getValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SaveablePair<TKey, TValue>[] ArrayFrom<TSourceKey, TSourceValue>(IDictionary<TSourceKey, TSourceValue> data, Func<TSourceKey, TKey> getKey, Func<TSourceValue, TValue> getValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
