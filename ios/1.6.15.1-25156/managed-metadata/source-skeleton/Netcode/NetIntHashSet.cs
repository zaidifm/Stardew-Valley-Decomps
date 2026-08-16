using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetIntHashSet : NetHashSet<int>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int ReadValue(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteValue(BinaryWriter writer, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntHashSet()
	{
	}
}
