using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public abstract class NetFieldDictionary<TKey, TValue, TField, TSerialDict, TSelf> : NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> where TField : NetField<TValue, TField>, new() where TSerialDict : IDictionary<TKey, TValue>, new() where TSelf : NetDictionary<TKey, TValue, TField, TSerialDict, TSelf>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFieldDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFieldDictionary(IEnumerable<KeyValuePair<TKey, TValue>> pairs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void setFieldValue(TField field, TKey key, TValue value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override TValue getFieldValue(TField field)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override TValue getFieldTargetValue(TField field)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
