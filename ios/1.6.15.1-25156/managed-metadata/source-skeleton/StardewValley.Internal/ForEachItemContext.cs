using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.Delegates;

namespace StardewValley.Internal;

public readonly struct ForEachItemContext
{
	public readonly Item Item;

	public readonly Action RemoveItem;

	public readonly Action<Item> ReplaceItemWith;

	public readonly GetForEachItemPathDelegate GetPath;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ForEachItemContext(Item item, Action remove, Action<Item> replaceWith, GetForEachItemPathDelegate getPath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IList<string> GetDisplayPath(bool includeItem = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddDisplayPath(IList<string> path, object pathValue)
	{
	}
}
