using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Util;

public static class SaveablePairExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this SaveablePair<TKey, TValue>[] pairs)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SaveablePair<TKey, TValue>[] ToSaveableArray<TKey, TValue>(this IDictionary<TKey, TValue> data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
