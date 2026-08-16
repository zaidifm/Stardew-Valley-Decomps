using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Netcode;

public abstract class NetHashSet<TValue> : AbstractNetSerializable, IEquatable<NetHashSet<TValue>>, ISet<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable
{
	public class IncomingChange
	{
		public uint Tick;

		public bool Removal;

		public TValue Value;

		public IncomingChange(uint tick, bool removal, TValue value)
		{
			Tick = tick;
			Removal = removal;
			Value = value;
		}
	}

	public class OutgoingChange
	{
		public bool Removal;

		public TValue Value;

		public OutgoingChange(bool removal, TValue value)
		{
			Removal = removal;
			Value = value;
		}
	}

	public delegate void ContentsChangeEvent(TValue value);

	public bool InterpolationWait = true;

	private readonly HashSet<TValue> Set = new HashSet<TValue>();

	private readonly List<IncomingChange> IncomingChanges = new List<IncomingChange>();

	private readonly List<OutgoingChange> OutgoingChanges = new List<OutgoingChange>();

	public int Count => Set.Count;

	public bool IsReadOnly => false;

	public event ContentsChangeEvent OnValueAdded;

	public event ContentsChangeEvent OnValueRemoved;

	public NetHashSet()
	{
	}

	public NetHashSet(IEnumerable<TValue> values)
		: this()
	{
		foreach (TValue value in values)
		{
			Add(value);
		}
	}

	public bool Add(TValue item)
	{
		if (!Set.Add(item))
		{
			return false;
		}
		OutgoingChanges.Add(new OutgoingChange(removal: false, item));
		MarkDirty();
		addedEvent(item);
		return true;
	}

	public void Clear()
	{
		TValue[] array = Set.ToArray();
		foreach (TValue item in array)
		{
			Remove(item);
		}
		OutgoingChanges.RemoveAll((OutgoingChange ch) => !ch.Removal);
	}

	public bool Contains(TValue item)
	{
		return Set.Contains(item);
	}

	public void CopyTo(TValue[] array, int arrayIndex)
	{
		Set.CopyTo(array, arrayIndex);
	}

	public bool Equals(NetHashSet<TValue> other)
	{
		return Set.Equals(other?.Set);
	}

	public void ExceptWith(IEnumerable<TValue> other)
	{
		Set.ExceptWith(other);
	}

	public IEnumerator<TValue> GetEnumerator()
	{
		return Set.GetEnumerator();
	}

	public void IntersectWith(IEnumerable<TValue> other)
	{
		Set.IntersectWith(other);
	}

	public bool IsProperSubsetOf(IEnumerable<TValue> other)
	{
		return Set.IsProperSubsetOf(other);
	}

	public bool IsProperSupersetOf(IEnumerable<TValue> other)
	{
		return Set.IsProperSupersetOf(other);
	}

	public bool IsSubsetOf(IEnumerable<TValue> other)
	{
		return Set.IsSubsetOf(other);
	}

	public bool IsSupersetOf(IEnumerable<TValue> other)
	{
		return Set.IsSupersetOf(other);
	}

	public bool Overlaps(IEnumerable<TValue> other)
	{
		return Set.Overlaps(other);
	}

	public bool Remove(TValue item)
	{
		if (!Set.Remove(item))
		{
			return false;
		}
		OutgoingChanges.Add(new OutgoingChange(removal: true, item));
		MarkDirty();
		removedEvent(item);
		return true;
	}

	public int RemoveWhere(Predicate<TValue> match)
	{
		int num = Set.RemoveWhere(delegate(TValue value)
		{
			if (match(value))
			{
				OutgoingChanges.Add(new OutgoingChange(removal: true, value));
				removedEvent(value);
				return true;
			}
			return false;
		});
		if (num > 0)
		{
			MarkDirty();
		}
		return num;
	}

	public bool SetEquals(IEnumerable<TValue> other)
	{
		return Set.SetEquals(other);
	}

	public void SymmetricExceptWith(IEnumerable<TValue> other)
	{
		Set.SymmetricExceptWith(other);
	}

	public void UnionWith(IEnumerable<TValue> other)
	{
		Set.UnionWith(other);
	}

	void ICollection<TValue>.Add(TValue item)
	{
		Add(item);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return Set.GetEnumerator();
	}

	protected override bool tickImpl()
	{
		List<IncomingChange> list = null;
		foreach (IncomingChange incomingChange in IncomingChanges)
		{
			if (base.Root == null || GetLocalTick() >= incomingChange.Tick)
			{
				if (list == null)
				{
					list = new List<IncomingChange>();
				}
				list.Add(incomingChange);
				continue;
			}
			break;
		}
		if (list != null)
		{
			foreach (IncomingChange item in list)
			{
				IncomingChanges.Remove(item);
			}
			foreach (IncomingChange item2 in list)
			{
				if (item2.Removal)
				{
					if (Set.Remove(item2.Value))
					{
						removedEvent(item2.Value);
					}
				}
				else if (Set.Add(item2.Value))
				{
					addedEvent(item2.Value);
				}
			}
		}
		return IncomingChanges.Count > 0;
	}

	private void removedEvent(TValue value)
	{
		OnValueRemoved?.Invoke(value);
	}

	private void addedEvent(TValue value)
	{
		OnValueAdded?.Invoke(value);
	}

	public override bool Equals(object obj)
	{
		if (obj is NetHashSet<TValue> other)
		{
			return Equals(other);
		}
		return false;
	}

	public override void Read(BinaryReader reader, NetVersion version)
	{
		uint tick = GetLocalTick() + (uint)((InterpolationWait && base.Root != null) ? base.Root.Clock.InterpolationTicks : 0);
		uint num = reader.Read7BitEncoded();
		for (uint num2 = 0u; num2 < num; num2++)
		{
			bool removal = reader.ReadBoolean();
			TValue value = ReadValue(reader);
			IncomingChanges.Add(new IncomingChange(tick, removal, value));
			base.NeedsTick = true;
		}
	}

	public override void Write(BinaryWriter writer)
	{
		writer.Write7BitEncoded((uint)OutgoingChanges.Count);
		foreach (OutgoingChange outgoingChange in OutgoingChanges)
		{
			writer.Write(outgoingChange.Removal);
			WriteValue(writer, outgoingChange.Value);
		}
	}

	public override void ReadFull(BinaryReader reader, NetVersion version)
	{
		Set.Clear();
		int num = reader.ReadInt32();
		Set.EnsureCapacity(num);
		for (int i = 0; i < num; i++)
		{
			TValue val = ReadValue(reader);
			Set.Add(val);
			addedEvent(val);
		}
	}

	public override void WriteFull(BinaryWriter writer)
	{
		writer.Write(Set.Count);
		foreach (TValue item in Set)
		{
			WriteValue(writer, item);
		}
	}

	public override int GetHashCode()
	{
		return Set.GetHashCode();
	}

	public abstract TValue ReadValue(BinaryReader reader);

	public abstract void WriteValue(BinaryWriter writer, TValue value);

	protected override void CleanImpl()
	{
		base.CleanImpl();
		OutgoingChanges.Clear();
	}
}
