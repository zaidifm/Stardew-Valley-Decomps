using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetObjectShrinkList<T> : AbstractNetSerializable, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IEquatable<NetObjectShrinkList<T>> where T : class, INetObject<INetSerializable>
{
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private readonly NetArray<T, NetRef<T>> _array;

		private int _index;

		private T _current;

		private bool _done;

		public T Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator(NetArray<T, NetRef<T>> array)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IEnumerator.Reset()
		{
		}
	}

	private NetArray<T, NetRef<T>> array;

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

	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetObjectShrinkList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetObjectShrinkList(IEnumerable<T> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyFrom(IList<T> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(IList<T> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveFrom(IList<T> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<T> GetRange(int index, int count)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRange(IEnumerable<T> collection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveRange(int index, int count)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(NetObjectShrinkList<T> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Enumerator GetEnumerator()
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
	public int IndexOf(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Insert(int index, T item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ReadFull(BinaryReader reader, NetVersion version)
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
	public override void Write(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteFull(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ForEachChild(Action<INetSerializable> childAction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
