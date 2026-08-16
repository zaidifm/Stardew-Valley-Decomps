using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetCollection<T> : AbstractNetSerializable, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IEquatable<NetCollection<T>> where T : class, INetObject<INetSerializable>
{
	public delegate void ContentsChangeEvent(T value);

	private List<Guid> guids;

	private List<T> list;

	private NetGuidDictionary<T, NetRef<T>> elements;

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

	public bool InterpolationWait
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public T this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public T this[Guid guid]
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
	public NetCollection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetCollection(IEnumerable<T> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(Guid id, out T value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(object item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(NetCollection<T> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<T>.Enumerator GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(ICollection<T> other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsGuid(Guid guid)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Guid GuidOf(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int IndexOf(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Insert(int index, T item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAt(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(Guid guid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RemoveWhere(Func<T, bool> match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Use RemoveWhere instead.")]
	public void Filter(Func<T, bool> f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ForEachChild(Action<INetSerializable> childAction)
	{
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
}
