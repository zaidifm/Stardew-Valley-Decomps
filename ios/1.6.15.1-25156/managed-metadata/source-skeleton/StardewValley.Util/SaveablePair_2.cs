using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace StardewValley.Util;

public struct SaveablePair<TKey, TValue>
{
	public TKey[] key;

	public TValue[] value;

	[XmlIgnore]
	public TKey Key
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public TValue Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveablePair(TKey key, TValue value)
	{
	}
}
