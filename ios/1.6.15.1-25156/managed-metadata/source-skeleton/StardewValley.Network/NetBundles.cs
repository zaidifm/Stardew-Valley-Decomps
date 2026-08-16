using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public class NetBundles : NetDictionary<int, bool[], NetArray<bool, NetBool>, SerializableDictionary<int, bool[]>, NetBundles>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override int ReadKey(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteKey(BinaryWriter writer, int key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void setFieldValue(NetArray<bool, NetBool> field, int key, bool[] value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool[] getFieldValue(NetArray<bool, NetBool> field)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool[] getFieldTargetValue(NetArray<bool, NetBool> field)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetBundles()
	{
	}
}
