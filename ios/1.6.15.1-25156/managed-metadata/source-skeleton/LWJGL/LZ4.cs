using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LWJGL;

public class LZ4
{
	private const string NativeName = "__Internal";

	[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Java_org_lwjgl_util_lz4_LZ4_LZ4_1compressBound")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern int lwjgl_compressBound(nint env, nint clazz, int inputSize);

	[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Java_org_lwjgl_util_lz4_LZ4_nLZ4_1compress_1default")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern int lwjgl_compress_default(nint env, nint clazz, byte[] src, nint dest, int srcSize, int dstCapacity);

	[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Java_org_lwjgl_util_lz4_LZ4_nLZ4_1decompress_1safe")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern int lwjgl_decompress_safe(nint env, nint clazz, nint src, byte[] dest, int compressedSize, int dstCapacity);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int CompressBound(int inputSize)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int CompressDefault(byte[] src, nint dest, int srcSize, int dstCapacity)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int DecompressSafe(nint src, byte[] dest, int compressedSize, int dstCapacity)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LZ4()
	{
	}
}
