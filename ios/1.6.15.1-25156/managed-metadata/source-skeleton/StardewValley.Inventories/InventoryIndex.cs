using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Inventories;

public class InventoryIndex
{
	private readonly Dictionary<string, List<Item>> Index;

	private readonly Action<InventoryIndex, Item> AddImpl;

	private readonly Action<InventoryIndex, Item> RemoveImpl;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InventoryIndex(Action<InventoryIndex, Item> addImpl, Action<InventoryIndex, Item> removeImpl)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static InventoryIndex ById(IList<Item> items)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CountKeys()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CountItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGet(string key, out IReadOnlyList<Item> items)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetMutable(string key, out IList<Item> items)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddWithKey(string key, Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveKey(string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveItem(string key, Item item)
	{
	}
}
