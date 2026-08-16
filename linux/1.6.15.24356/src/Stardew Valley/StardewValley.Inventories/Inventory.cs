using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Netcode;
using StardewValley.SaveSerialization;

namespace StardewValley.Inventories;

[XmlRoot("items")]
public class Inventory : INetObject<NetFields>, IXmlSerializable, IInventory, IList<Item>, ICollection<Item>, IEnumerable<Item>, IEnumerable
{
	private readonly NetObjectList<Item> Items = new NetObjectList<Item>();

	private InventoryIndex ItemsById;

	private int? CachedItemStackCount;

	public NetFields NetFields { get; } = new NetFields("Inventory");

	public int Count => Items.Count;

	public bool IsReadOnly => Items.IsReadOnly;

	public Item this[int index]
	{
		get
		{
			return Items[index];
		}
		set
		{
			Items[index] = value;
		}
	}

	public bool IsLocalPlayerInventory { get; set; }

	public long LastTickSlotChanged { get; private set; }

	public event OnSlotChangedDelegate OnSlotChanged;

	public event OnInventoryReplacedDelegate OnInventoryReplaced;

	public Inventory()
	{
		NetFields.SetOwner(this).AddField(Items, "this.Items");
		Items.OnElementChanged += HandleElementChanged;
		Items.OnArrayReplaced += HandleArrayReplaced;
	}

	public bool HasAny()
	{
		return GetItemsById().CountKeys() > 0;
	}

	public bool HasEmptySlots()
	{
		return Count > CountItemStacks();
	}

	public int CountItemStacks()
	{
		int? cachedItemStackCount = CachedItemStackCount;
		if (!cachedItemStackCount.HasValue)
		{
			int? num = (CachedItemStackCount = GetItemsById().CountItems());
			return num.Value;
		}
		return cachedItemStackCount.GetValueOrDefault();
	}

	public void OverwriteWith(IList<Item> list)
	{
		if (this != list && Items != list)
		{
			ClearIndex();
			Items.CopyFrom(list);
		}
	}

	public IList<Item> GetRange(int index, int count)
	{
		return Items.GetRange(index, count);
	}

	public void AddRange(ICollection<Item> collection)
	{
		Items.AddRange(collection);
	}

	public void RemoveRange(int index, int count)
	{
		Items.RemoveRange(index, count);
	}

	public void RemoveEmptySlots()
	{
		if (!HasEmptySlots())
		{
			return;
		}
		for (int num = Count - 1; num >= 0; num--)
		{
			if (this[num] == null)
			{
				RemoveAt(num);
			}
		}
	}

	public bool ContainsId(string itemId)
	{
		itemId = ItemRegistry.QualifyItemId(itemId);
		if (itemId == null)
		{
			return false;
		}
		return GetItemsById().Contains(itemId);
	}

	public bool ContainsId(string itemId, int minimum)
	{
		itemId = ItemRegistry.QualifyItemId(itemId);
		if (itemId == null)
		{
			return false;
		}
		if (GetItemsById().TryGet(itemId, out var items))
		{
			if (minimum <= 1)
			{
				return true;
			}
			int num = 0;
			foreach (Item item in items)
			{
				if (item.QualifiedItemId == itemId)
				{
					num += item.Stack;
				}
				if (num >= minimum)
				{
					return true;
				}
			}
		}
		return false;
	}

	public int CountId(string itemId)
	{
		itemId = ItemRegistry.QualifyItemId(itemId);
		if (itemId == null)
		{
			return 0;
		}
		if (GetItemsById().TryGet(itemId, out var items))
		{
			int num = 0;
			{
				foreach (Item item in items)
				{
					if (item.QualifiedItemId == itemId)
					{
						num += item.Stack;
					}
				}
				return num;
			}
		}
		return 0;
	}

	public IEnumerable<Item> GetById(string itemId)
	{
		itemId = ItemRegistry.QualifyItemId(itemId);
		if (itemId == null || !GetItemsById().TryGet(itemId, out var items))
		{
			return LegacyShims.EmptyArray<Item>();
		}
		return items;
	}

	public int Reduce(Item item, int count, bool reduceRemainderFromInventory = false)
	{
		int num = -1;
		if (IsLocalPlayerInventory)
		{
			num = Game1.player.CurrentToolIndex;
			if (num < 0 || num >= Count || Items[num] != item)
			{
				num = -1;
			}
		}
		if (num < 0)
		{
			num = IndexOf(item);
		}
		int num2 = count;
		if (num > -1)
		{
			num2 -= item.Stack;
			Items[num] = item.ConsumeStack(count);
		}
		else
		{
			Game1.log.Warn($"Can't deduct item with ID '{item.QualifiedItemId}' from {(IsLocalPlayerInventory ? "the player's" : "this")} inventory because it's not in that inventory.");
		}
		if (reduceRemainderFromInventory && num2 > 0)
		{
			num2 -= ReduceId(item.QualifiedItemId, num2);
		}
		if (num2 > 0)
		{
			return count - num2;
		}
		return count;
	}

	public int ReduceId(string itemId, int count)
	{
		itemId = ItemRegistry.QualifyItemId(itemId);
		if (itemId == null)
		{
			return 0;
		}
		InventoryIndex itemsById = GetItemsById();
		if (itemsById.TryGetMutable(itemId, out var items))
		{
			bool flag = false;
			int num = count;
			for (int i = 0; i < items.Count; i++)
			{
				if (num <= 0)
				{
					break;
				}
				Item item = items[i];
				int num2 = Math.Min(num, item.Stack);
				items[i] = item.ConsumeStack(num2);
				if (items[i] == null)
				{
					flag = true;
					items.RemoveAt(i);
					item.SetTempData("__Inventory_ReduceId_Remove", "");
					i--;
				}
				num -= num2;
			}
			if (items.Count == 0)
			{
				itemsById.RemoveKey(itemId);
			}
			if (flag)
			{
				for (int num3 = Items.Count - 1; num3 >= 0; num3--)
				{
					if (Items[num3]?.tempData?.Remove("__Inventory_ReduceId_Remove") ?? false)
					{
						Items[num3] = null;
					}
				}
			}
			return count - num;
		}
		return 0;
	}

	public bool RemoveButKeepEmptySlot(Item item)
	{
		if (item == null)
		{
			return false;
		}
		int num = Items.IndexOf(item);
		if (num == -1)
		{
			return false;
		}
		Items[num] = null;
		return true;
	}

	public IEnumerator<Item> GetEnumerator()
	{
		return Items.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return Items.GetEnumerator();
	}

	public void Add(Item item)
	{
		Items.Add(item);
	}

	public void Clear()
	{
		ClearIndex();
		Items.Clear();
	}

	public bool Contains(Item item)
	{
		if (item == null)
		{
			return false;
		}
		if (GetItemsById().TryGetMutable(item.QualifiedItemId, out var items))
		{
			return items.Contains(item);
		}
		return false;
	}

	public void CopyTo(Item[] array, int arrayIndex)
	{
		Items.CopyTo(array, arrayIndex);
	}

	public bool Remove(Item item)
	{
		if (item == null)
		{
			return false;
		}
		return Items.Remove(item);
	}

	public int IndexOf(Item item)
	{
		return Items.IndexOf(item);
	}

	public void Insert(int index, Item item)
	{
		Items.Insert(index, item);
	}

	public void RemoveAt(int index)
	{
		Items.RemoveAt(index);
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader reader)
	{
		bool isEmptyElement = reader.IsEmptyElement;
		reader.Read();
		if (!isEmptyElement)
		{
			while (reader.NodeType != XmlNodeType.EndElement)
			{
				Item item = SaveSerializer.Deserialize<Item>(reader);
				Items.Add(item);
				reader.MoveToContent();
			}
			reader.ReadEndElement();
		}
	}

	public void WriteXml(XmlWriter writer)
	{
		foreach (Item item in Items)
		{
			SaveSerializer.Serialize(writer, item);
		}
	}

	private InventoryIndex GetItemsById()
	{
		return ItemsById ?? (ItemsById = InventoryIndex.ById(Items));
	}

	private void HandleArrayReplaced(NetList<Item, NetRef<Item>> list, IList<Item> before, IList<Item> after)
	{
		if (before.Count != 0 || after.Count != 0)
		{
			ClearIndex();
			CachedItemStackCount = null;
			LastTickSlotChanged = DateTime.UtcNow.Ticks;
			OnInventoryReplaced?.Invoke(this, before, after);
		}
	}

	private void HandleElementChanged(NetList<Item, NetRef<Item>> list, int index, Item before, Item after)
	{
		if (before != after)
		{
			ItemsById?.Remove(before);
			ItemsById?.Add(after);
			CachedItemStackCount = null;
			LastTickSlotChanged = DateTime.UtcNow.Ticks;
			OnSlotChanged?.Invoke(this, index, before, after);
		}
	}

	private void ClearIndex()
	{
		ItemsById = null;
	}
}
