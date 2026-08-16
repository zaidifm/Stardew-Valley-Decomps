using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetEventBinary : AbstractNetEvent1<byte[]>
{
	public delegate void ArgWriter(BinaryWriter writer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fire(ArgWriter argWriter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddReaderHandler(Action<BinaryReader> handler)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override byte[] readEventArg(BinaryReader reader, NetVersion version)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void writeEventArg(BinaryWriter writer, byte[] arg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetEventBinary()
	{
	}
}
