using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley;

public class NetStringIntArrayDictionary : NetDictionary<string, int[], NetArray<int, NetInt>, SerializableDictionary<string, int[]>, NetStringIntArrayDictionary>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void setFieldValue(NetArray<int, NetInt> field, string key, int[] value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override int[] getFieldValue(NetArray<int, NetInt> field)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override int[] getFieldTargetValue(NetArray<int, NetInt> field)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetStringIntArrayDictionary()
	{
	}
}
