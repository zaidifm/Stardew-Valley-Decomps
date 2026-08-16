using System;
using System.Collections.Generic;

namespace StardewValley.Inventories;

public class InventoryIndex
{
	private readonly Dictionary<string, List<Item>> Index = new Dictionary<string, List<Item>>();

	private readonly Action<InventoryIndex, Item> AddImpl;

	private readonly Action<InventoryIndex, Item> RemoveImpl;

	public InventoryIndex(Action<InventoryIndex, Item> addImpl, Action<InventoryIndex, Item> removeImpl)
	{
		AddImpl = addImpl;
		RemoveImpl = removeImpl;
	}

	public static InventoryIndex ById(IList<Item> items)
	{
		InventoryIndex inventoryIndex = new InventoryIndex(delegate(InventoryIndex index, Item item)
		{
			index.AddWithKey(item.QualifiedItemId, item);
		}, delegate(InventoryIndex index, Item item)
		{
			index.RemoveItem(item.QualifiedItemId, item);
		});
		foreach (Item item in items)
		{
			inventoryIndex.Add(item);
		}
		return inventoryIndex;
	}

	public int CountKeys()
	{
		return Index.Count;
	}

	public int CountItems()
	{
		int num = 0;
		foreach (List<Item> value in Index.Values)
		{
			num += value.Count;
		}
		return num;
	}

	public bool Contains(string key)
	{
		if (key != null)
		{
			return Index.ContainsKey(key);
		}
		return false;
	}

	public bool TryGet(string key, out IReadOnlyList<Item> items)
	{
		if (key != null && Index.TryGetValue(key, out var value))
		{
			items = value;
			return true;
		}
		items = null;
		return false;
	}

	public bool TryGetMutable(string key, out IList<Item> items)
	{
		if (key != null && Index.TryGetValue(key, out var value))
		{
			items = value;
			return true;
		}
		items = null;
		return false;
	}

	public void Add(Item item)
	{
		if (item != null)
		{
			AddImpl(this, item);
		}
	}

	public void AddWithKey(string key, Item item)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (item != null)
		{
			if (!Index.TryGetValue(key, out var value))
			{
				value = (Index[key] = new List<Item>());
			}
			value.Add(item);
		}
	}

	public void Remove(Item item)
	{
		if (item != null)
		{
			RemoveImpl(this, item);
		}
	}

	public void RemoveKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Index.Remove(key);
	}

	public void RemoveItem(string key, Item item)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (item != null && Index.TryGetValue(key, out var value))
		{
			value.Remove(item);
			if (value.Count == 0)
			{
				Index.Remove(key);
			}
		}
	}
}
