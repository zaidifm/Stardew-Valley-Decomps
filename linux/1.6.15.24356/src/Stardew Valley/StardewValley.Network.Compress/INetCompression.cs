using System.IO;

namespace StardewValley.Network.Compress;

public interface INetCompression
{
	byte[] CompressAbove(byte[] data, int minSizeToCompress = 256);

	byte[] DecompressBytes(byte[] data);

	bool TryDecompressStream(Stream dataStream, out byte[] decompressed);
}
