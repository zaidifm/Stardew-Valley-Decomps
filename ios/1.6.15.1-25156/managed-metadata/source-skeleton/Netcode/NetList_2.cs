using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetList<T, TField> : AbstractNetSerializable, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IEquatable<NetList<T, TField>> where TField : NetField<T, TField>, new()
{
	public delegate void ElementChangedEvent(NetList<T, TField> list, int index, T oldValue, T newValue);

	public delegate void ArrayReplacedEvent(NetList<T, TField> list, IList<T> before, IList<T> after);

	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private readonly NetList<T, TField> _list;

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
		public Enumerator(NetList<T, TField> list)
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

	private const int initialSize = 10;

	private const double resizeFactor = 1.5;

	protected readonly NetInt count;

	protected readonly NetRef<NetArray<T, TField>> array;

	[CompilerGenerated]
	private ElementChangedEvent m_OnElementChanged;

	[CompilerGenerated]
	private ArrayReplacedEvent m_OnArrayReplaced;

	public virtual T this[int index]
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

	public int Capacity
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

	public event ElementChangedEvent OnElementChanged
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

	public event ArrayReplacedEvent OnArrayReplaced
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
	public NetList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetList(IEnumerable<T> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetList(int capacity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hookField(int index, TField field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hookArray(NetArray<T, TField> array)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Resize(int capacity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureCapacity(int neededCapacity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Add(T item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(object item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fillNull()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CopyFrom(IList<T> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(IList<T> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveFrom(NetList<T, TField> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Any()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool Contains(T item)
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
	public bool Equals(NetList<T, TField> other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Enumerator GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int IndexOf(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Insert(int index, T item)
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
	public virtual void RemoveAt(int index)
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
