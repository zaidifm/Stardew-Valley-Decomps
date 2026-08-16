using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.Compress;

public interface INetCompression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	byte[] CompressAbove(byte[] data, int minSizeToCompress = 256);

	[MethodImpl(MethodImplOptions.NoInlining)]
	byte[] DecompressBytes(byte[] data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool TryDecompressStream(Stream dataStream, out byte[] decompressed);
}
