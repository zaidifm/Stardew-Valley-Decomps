using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetEnum<T> : NetFieldBase<T, NetEnum<T>>, IEnumerable<string>, IEnumerable where T : struct, IConvertible
{
	private bool xmlInitialized;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetEnum()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetEnum(T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(T newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReadDelta(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteDelta(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<string> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(object value)
	{
	}
}
