using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public class NetStringDictionary<T, TField> : NetFieldDictionary<string, T, TField, SerializableDictionary<string, T>, NetStringDictionary<T, TField>> where TField : NetField<T, TField>, new()
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetStringDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetStringDictionary(IEnumerable<KeyValuePair<string, T>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, string key)
	{
	}
}
