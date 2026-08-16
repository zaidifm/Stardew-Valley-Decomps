using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Netcode;

public class NetRootDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TValue : class, INetObject<INetSerializable>
{
	public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		private Dictionary<TKey, NetRoot<TValue>> _roots;

		private Dictionary<TKey, NetRoot<TValue>>.Enumerator _enumerator;

		private KeyValuePair<TKey, TValue> _current;

		private bool _done;

		public KeyValuePair<TKey, TValue> Current
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
		public Enumerator(Dictionary<TKey, NetRoot<TValue>> roots)
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

	public XmlSerializer Serializer;

	public Dictionary<TKey, NetRoot<TValue>> Roots;

	public TValue this[TKey key]
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

	public ICollection<TKey> Keys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ICollection<TValue> Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRootDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRootDictionary(IEnumerable<KeyValuePair<TKey, TValue>> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(KeyValuePair<TKey, TValue> item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(TKey key, TValue value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(TKey key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Enumerator GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(TKey key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(TKey key, out TValue value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
