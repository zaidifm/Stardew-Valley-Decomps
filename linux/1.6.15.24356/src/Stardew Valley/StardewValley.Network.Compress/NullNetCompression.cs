using System.IO;

namespace StardewValley.Network.Compress;

internal class NullNetCompression : INetCompression
{
	public byte[] CompressAbove(byte[] data, int minSizeToCompress = 256)
	{
		return data;
	}

	public byte[] DecompressBytes(byte[] data)
	{
		return data;
	}

	public bool TryDecompressStream(Stream dataStream, out byte[] decompressed)
	{
		decompressed = null;
		return false;
	}
}
