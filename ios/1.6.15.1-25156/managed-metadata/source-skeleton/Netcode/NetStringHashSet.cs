using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetStringHashSet : NetHashSet<string>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ReadValue(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteValue(BinaryWriter writer, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetStringHashSet()
	{
	}
}
