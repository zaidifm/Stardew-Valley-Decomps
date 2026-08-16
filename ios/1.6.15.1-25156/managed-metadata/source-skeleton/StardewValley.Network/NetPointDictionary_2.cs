using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Network;

public class NetPointDictionary<T, TField> : NetFieldDictionary<Point, T, TField, SerializableDictionary<Point, T>, NetPointDictionary<T, TField>> where TField : NetField<T, TField>, new()
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetPointDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetPointDictionary(IEnumerable<KeyValuePair<Point, T>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Point ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, Point key)
	{
	}
}
