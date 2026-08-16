using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.Compress;

internal class NullNetCompression : INetCompression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] CompressAbove(byte[] data, int minSizeToCompress = 256)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] DecompressBytes(byte[] data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryDecompressStream(Stream dataStream, out byte[] decompressed)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NullNetCompression()
	{
	}
}
