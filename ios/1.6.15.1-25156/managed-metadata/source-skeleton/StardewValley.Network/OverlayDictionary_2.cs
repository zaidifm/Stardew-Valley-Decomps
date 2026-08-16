using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public class OverlayDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	protected Dictionary<TKey, TValue> _dictionary;

	protected List<KeyValuePair<TKey, TValue>> _removedPairs;

	[CompilerGenerated]
	private Action<TKey, TValue> m_onValueAdded;

	[CompilerGenerated]
	private Action<TKey, TValue> m_onValueRemoved;

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

	public event Action<TKey, TValue> onValueAdded
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

	public event Action<TKey, TValue> onValueRemoved
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
	public OverlayDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OverlayDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OverlayDictionary(IEqualityComparer<TKey> comparer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(TKey key, TValue value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(KeyValuePair<TKey, TValue> item)
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
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(TKey key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(TKey key, out TValue value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TValue GetValueOrDefault(TKey key, TValue defaultValue = default(TValue))
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
