using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley;

public class NetFarmerPairDictionary<T, TField> : NetFieldDictionary<FarmerPair, T, TField, SerializableDictionary<FarmerPair, T>, NetFarmerPairDictionary<T, TField>> where TField : NetField<T, TField>, new()
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFarmerPairDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFarmerPairDictionary(IEnumerable<KeyValuePair<FarmerPair, T>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override FarmerPair ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, FarmerPair key)
	{
	}
}
