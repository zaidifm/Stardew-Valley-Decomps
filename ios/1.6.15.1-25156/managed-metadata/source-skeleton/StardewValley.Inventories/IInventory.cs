using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Inventories;

public interface IInventory : IList<Item>, ICollection<Item>, IEnumerable<Item>, IEnumerable
{
	bool IsLocalPlayerInventory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	long LastTickSlotChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool HasAny();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool HasEmptySlots();

	[MethodImpl(MethodImplOptions.NoInlining)]
	int CountItemStacks();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void OverwriteWith(IList<Item> list);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IList<Item> GetRange(int index, int count);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void AddRange(ICollection<Item> collection);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RemoveRange(int index, int count);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RemoveEmptySlots();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ContainsId(string itemId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ContainsId(string itemId, int minimum);

	[MethodImpl(MethodImplOptions.NoInlining)]
	int CountId(string itemId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerable<Item> GetById(string itemId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	int Reduce(Item item, int count, bool reduceRemainderFromInventory = false);

	[MethodImpl(MethodImplOptions.NoInlining)]
	int ReduceId(string itemId, int count);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool RemoveButKeepEmptySlot(Item item);
}
