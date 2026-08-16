using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Network;

public class OverlaidDictionary : IEnumerable<SerializableDictionary<Vector2, Object>>, IEnumerable
{
	private NetVector2Dictionary<Object, NetRef<Object>> baseDict;

	private OverlayDictionary<Vector2, Object> overlayDict;

	private Dictionary<Vector2, Object> compositeDict;

	private bool _locked;

	private Dictionary<Vector2, Object> _changes;

	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Object this[Vector2 key]
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

	public Dictionary<Vector2, Object>.KeyCollection Keys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Dictionary<Vector2, Object>.ValueCollection Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public IEnumerable<KeyValuePair<Vector2, Object>> Pairs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueAdded(Vector2 key, Object value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueRemoved(Vector2 key, Object value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEqualityComparer(IEqualityComparer<Vector2> comparer, ref NetVector2Dictionary<Object, NetRef<Object>> base_dict, ref OverlayDictionary<Vector2, Object> overlay_dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OverlaidDictionary(NetVector2Dictionary<Object, NetRef<Object>> baseDict, OverlayDictionary<Vector2, Object> overlayDict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Any()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Count()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Lock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unlock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(Vector2 key, Object value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAdd(Vector2 key, Object value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(Vector2 key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(Vector2 key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(Vector2 key, out Object value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object GetValueOrDefault(Vector2 key, Object defaultValue = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<SerializableDictionary<Vector2, Object>> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(SerializableDictionary<Vector2, Object> dict)
	{
	}
}
