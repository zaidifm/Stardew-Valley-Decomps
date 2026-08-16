using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetEvent1<T> : AbstractNetEvent1<T> where T : NetEventArg, new()
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override T readEventArg(BinaryReader reader, NetVersion version)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void writeEventArg(BinaryWriter writer, T eventArg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetEvent1()
	{
	}
}
