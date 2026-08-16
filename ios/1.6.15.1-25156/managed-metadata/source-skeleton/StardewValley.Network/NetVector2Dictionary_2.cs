using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Network;

public sealed class NetVector2Dictionary<T, TField> : NetFieldDictionary<Vector2, T, TField, SerializableDictionary<Vector2, T>, NetVector2Dictionary<T, TField>> where TField : NetField<T, TField>, new()
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetVector2Dictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetVector2Dictionary(IEnumerable<KeyValuePair<Vector2, T>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Vector2 ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, Vector2 key)
	{
	}
}
