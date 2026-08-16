using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public abstract class NetHashSet<TValue> : AbstractNetSerializable, IEquatable<NetHashSet<TValue>>, ISet<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable
{
	public class IncomingChange
	{
		public uint Tick;

		public bool Removal;

		public TValue Value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IncomingChange(uint tick, bool removal, TValue value)
		{
		}
	}

	public class OutgoingChange
	{
		public bool Removal;

		public TValue Value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutgoingChange(bool removal, TValue value)
		{
		}
	}

	public delegate void ContentsChangeEvent(TValue value);

	public bool InterpolationWait;

	private readonly HashSet<TValue> Set;

	private readonly List<IncomingChange> IncomingChanges;

	private readonly List<OutgoingChange> OutgoingChanges;

	[CompilerGenerated]
	private ContentsChangeEvent m_OnValueAdded;

	[CompilerGenerated]
	private ContentsChangeEvent m_OnValueRemoved;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public event ContentsChangeEvent OnValueAdded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ContentsChangeEvent OnValueRemoved
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetHashSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetHashSet(IEnumerable<TValue> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Add(TValue item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(TValue item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(TValue[] array, int arrayIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(NetHashSet<TValue> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExceptWith(IEnumerable<TValue> other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<TValue> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IntersectWith(IEnumerable<TValue> other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsProperSubsetOf(IEnumerable<TValue> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsProperSupersetOf(IEnumerable<TValue> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSubsetOf(IEnumerable<TValue> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSupersetOf(IEnumerable<TValue> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Overlaps(IEnumerable<TValue> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(TValue item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RemoveWhere(Predicate<TValue> match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetEquals(IEnumerable<TValue> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SymmetricExceptWith(IEnumerable<TValue> other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnionWith(IEnumerable<TValue> other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ICollection<TValue>.Add(TValue item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool tickImpl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void removedEvent(TValue value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addedEvent(TValue value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ReadFull(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteFull(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract TValue ReadValue(BinaryReader reader);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void WriteValue(BinaryWriter writer, TValue value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CleanImpl()
	{
	}
}
