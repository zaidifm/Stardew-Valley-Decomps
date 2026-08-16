using System.Collections;
using System.Collections.Generic;

namespace StardewValley.Inventories;

public interface IInventory : IList<Item>, ICollection<Item>, IEnumerable<Item>, IEnumerable
{
	bool IsLocalPlayerInventory { get; set; }

	long LastTickSlotChanged { get; }

	bool HasAny();

	bool HasEmptySlots();

	int CountItemStacks();

	void OverwriteWith(IList<Item> list);

	IList<Item> GetRange(int index, int count);

	void AddRange(ICollection<Item> collection);

	void RemoveRange(int index, int count);

	void RemoveEmptySlots();

	bool ContainsId(string itemId);

	bool ContainsId(string itemId, int minimum);

	int CountId(string itemId);

	IEnumerable<Item> GetById(string itemId);

	int Reduce(Item item, int count, bool reduceRemainderFromInventory = false);

	int ReduceId(string itemId, int count);

	bool RemoveButKeepEmptySlot(Item item);
}
