using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public class NetIntDictionary<T, TField> : NetFieldDictionary<int, T, TField, SerializableDictionary<int, T>, NetIntDictionary<T, TField>> where TField : NetField<T, TField>, new()
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntDictionary(IEnumerable<KeyValuePair<int, T>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override int ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, int key)
	{
	}
}
