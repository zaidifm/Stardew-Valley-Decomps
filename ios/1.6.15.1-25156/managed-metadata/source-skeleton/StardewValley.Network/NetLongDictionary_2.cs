using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public class NetLongDictionary<T, TField> : NetFieldDictionary<long, T, TField, SerializableDictionary<long, T>, NetLongDictionary<T, TField>> where TField : NetField<T, TField>, new()
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLongDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLongDictionary(IEnumerable<KeyValuePair<long, T>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override long ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, long key)
	{
	}
}
