using System.Runtime.CompilerServices;

namespace Ionic.Zlib;

internal sealed class Tree
{
	private static readonly int HEAP_SIZE;

	internal static readonly int[] ExtraLengthBits;

	internal static readonly int[] ExtraDistanceBits;

	internal static readonly int[] extra_blbits;

	internal static readonly sbyte[] bl_order;

	internal const int Buf_size = 16;

	private static readonly sbyte[] _dist_code;

	internal static readonly sbyte[] LengthCode;

	internal static readonly int[] LengthBase;

	internal static readonly int[] DistanceBase;

	internal short[] dyn_tree;

	internal int max_code;

	internal StaticTree staticTree;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DistanceCode(int dist)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void gen_bitlen(DeflateManager s)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void build_tree(DeflateManager s)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int bi_reverse(int code, int len)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Tree()
	{
	}
}
