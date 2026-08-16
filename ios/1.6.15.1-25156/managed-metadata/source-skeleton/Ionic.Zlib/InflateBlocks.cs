using System.Runtime.CompilerServices;

namespace Ionic.Zlib;

internal sealed class InflateBlocks
{
	private enum InflateBlockMode
	{
		TYPE,
		LENS,
		STORED,
		TABLE,
		BTREE,
		DTREE,
		CODES,
		DRY,
		DONE,
		BAD
	}

	private const int MANY = 1440;

	internal static readonly int[] border;

	private InflateBlockMode mode;

	internal int left;

	internal int table;

	internal int index;

	internal int[] blens;

	internal int[] bb;

	internal int[] tb;

	internal InflateCodes codes;

	internal int last;

	internal ZlibCodec _codec;

	internal int bitk;

	internal int bitb;

	internal int[] hufts;

	internal byte[] window;

	internal int end;

	internal int readAt;

	internal int writeAt;

	internal object checkfn;

	internal uint check;

	internal InfTree inftree;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint Reset()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Process(int r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Free()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetDictionary(byte[] d, int start, int n)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int SyncPoint()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Flush(int r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
