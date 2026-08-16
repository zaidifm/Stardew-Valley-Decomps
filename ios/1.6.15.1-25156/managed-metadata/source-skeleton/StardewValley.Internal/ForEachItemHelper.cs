using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Delegates;

namespace StardewValley.Internal;

public static class ForEachItemHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ForEachItemInWorld(ForEachItemDelegate handler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ForEachItemInLocation(GameLocation location, ForEachItemDelegate handler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ApplyToItem<TItem>(TItem item, ForEachItemDelegate handler, Action remove, Action<Item> replaceWith, GetForEachItemPathDelegate getParentPath) where TItem : Item
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ApplyToField<TItem>(NetRef<TItem> field, ForEachItemDelegate handler, GetForEachItemPathDelegate getParentPath, Action<Item, Item> onChanged = null) where TItem : Item
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ApplyToList<TItem>(IList<TItem> list, ForEachItemDelegate handler, GetForEachItemPathDelegate getParentPath, bool leaveNullSlotsOnRemoval = false, Action<Item, Item, int> onChanged = null) where TItem : Item
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IList<object> CombinePath(GetForEachItemPathDelegate parentPath, params object[] pathValues)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static TItem PrepareForReplaceWith<TItem>(TItem previousItem, TItem newItem) where TItem : Item
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
