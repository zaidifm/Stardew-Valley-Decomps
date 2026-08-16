using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public abstract class NetField<T, TSelf> : NetFieldBase<T, TSelf>, IEnumerable<T>, IEnumerable where TSelf : NetField<T, TSelf>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetField()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetField(T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<T> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(object value)
	{
	}
}
