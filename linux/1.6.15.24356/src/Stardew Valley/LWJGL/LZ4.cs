using System;
using System.Runtime.InteropServices;

namespace LWJGL;

public class LZ4
{
	[DllImport("liblwjgl_lz4", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Java_org_lwjgl_util_lz4_LZ4_LZ4_1compressBound")]
	private static extern int lwjgl_compressBound(IntPtr env, IntPtr clazz, int inputSize);

	[DllImport("liblwjgl_lz4", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Java_org_lwjgl_util_lz4_LZ4_nLZ4_1compress_1default")]
	private static extern int lwjgl_compress_default(IntPtr env, IntPtr clazz, byte[] src, IntPtr dest, int srcSize, int dstCapacity);

	[DllImport("liblwjgl_lz4", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Java_org_lwjgl_util_lz4_LZ4_nLZ4_1decompress_1safe")]
	private static extern int lwjgl_decompress_safe(IntPtr env, IntPtr clazz, IntPtr src, byte[] dest, int compressedSize, int dstCapacity);

	public static int CompressBound(int inputSize)
	{
		return lwjgl_compressBound(IntPtr.Zero, IntPtr.Zero, inputSize);
	}

	public static int CompressDefault(byte[] src, IntPtr dest, int srcSize, int dstCapacity)
	{
		return lwjgl_compress_default(IntPtr.Zero, IntPtr.Zero, src, dest, srcSize, dstCapacity);
	}

	public static int DecompressSafe(IntPtr src, byte[] dest, int compressedSize, int dstCapacity)
	{
		return lwjgl_decompress_safe(IntPtr.Zero, IntPtr.Zero, src, dest, compressedSize, dstCapacity);
	}
}
