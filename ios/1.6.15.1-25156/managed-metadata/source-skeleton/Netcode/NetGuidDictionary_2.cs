using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetGuidDictionary<T, TField> : NetFieldDictionary<Guid, T, TField, Dictionary<Guid, T>, NetGuidDictionary<T, TField>> where TField : NetField<T, TField>, new()
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetGuidDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetGuidDictionary(IEnumerable<KeyValuePair<Guid, T>> pairs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Guid ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, Guid key)
	{
	}
}
