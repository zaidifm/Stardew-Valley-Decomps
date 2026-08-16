using System;
using System.IO;
using System.Runtime.InteropServices;
using LWJGL;

namespace StardewValley.Network.Compress;

internal class LZ4NetCompression : INetCompression
{
	private const int HeaderSize = 9;

	public byte[] CompressAbove(byte[] data, int minSizeToCompress = 256)
	{
		if (data.Length < minSizeToCompress)
		{
			return data;
		}
		int num = LZ4.CompressBound(data.Length);
		IntPtr intPtr = Marshal.AllocHGlobal(num + 9);
		IntPtr dest = IntPtr.Add(intPtr, 9);
		int num2 = LZ4.CompressDefault(data, dest, data.Length, num);
		Marshal.WriteByte(intPtr, 0, 127);
		Marshal.WriteInt32(intPtr, 1, num2);
		Marshal.WriteInt32(intPtr, 5, data.Length);
		byte[] array = new byte[num2 + 9];
		Marshal.Copy(intPtr, array, 0, array.Length);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	public byte[] DecompressBytes(byte[] data)
	{
		if (data[0] != 127)
		{
			return data;
		}
		return DecompressImpl(data);
	}

	public bool TryDecompressStream(Stream dataStream, out byte[] decompressed)
	{
		decompressed = null;
		if (!dataStream.CanSeek || !dataStream.CanRead)
		{
			throw new ArgumentException("dataStream must support both reading and seeking");
		}
		long position = dataStream.Position;
		if ((byte)dataStream.ReadByte() != 127)
		{
			dataStream.Seek(position, SeekOrigin.Begin);
			return false;
		}
		byte[] array = new byte[4];
		dataStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		byte[] array2 = new byte[num + 9];
		dataStream.Read(array2, 5, 4 + num);
		decompressed = DecompressImpl(array2);
		return true;
	}

	private unsafe byte[] DecompressImpl(byte[] data)
	{
		int num = BitConverter.ToInt32(data, 5);
		byte[] array = new byte[num];
		fixed (byte* ptr = data)
		{
			LZ4.DecompressSafe(IntPtr.Add((IntPtr)ptr, 9), array, data.Length - 9, num);
		}
		return array;
	}
}
