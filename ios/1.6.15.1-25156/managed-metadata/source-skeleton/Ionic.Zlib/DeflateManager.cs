using System.Runtime.CompilerServices;

namespace Ionic.Zlib;

internal sealed class DeflateManager
{
	internal delegate BlockState CompressFunc(FlushType flush);

	internal class Config
	{
		internal int GoodLength;

		internal int MaxLazy;

		internal int NiceLength;

		internal int MaxChainLength;

		internal DeflateFlavor Flavor;

		private static readonly Config[] Table;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Config Lookup(CompressionLevel level)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Config()
		{
		}
	}

	private static readonly int MEM_LEVEL_MAX;

	private static readonly int MEM_LEVEL_DEFAULT;

	private CompressFunc DeflateFunction;

	private static readonly string[] _ErrorMessage;

	private static readonly int PRESET_DICT;

	private static readonly int INIT_STATE;

	private static readonly int BUSY_STATE;

	private static readonly int FINISH_STATE;

	private static readonly int Z_DEFLATED;

	private static readonly int STORED_BLOCK;

	private static readonly int STATIC_TREES;

	private static readonly int DYN_TREES;

	private static readonly int Z_BINARY;

	private static readonly int Z_ASCII;

	private static readonly int Z_UNKNOWN;

	private static readonly int Buf_size;

	private static readonly int MIN_MATCH;

	private static readonly int MAX_MATCH;

	private static readonly int MIN_LOOKAHEAD;

	private static readonly int HEAP_SIZE;

	private static readonly int END_BLOCK;

	internal ZlibCodec _codec;

	internal int status;

	internal byte[] pending;

	internal int nextPending;

	internal int pendingCount;

	internal sbyte data_type;

	internal int last_flush;

	internal int w_size;

	internal int w_bits;

	internal int w_mask;

	internal byte[] window;

	internal int window_size;

	internal short[] prev;

	internal short[] head;

	internal int ins_h;

	internal int hash_size;

	internal int hash_bits;

	internal int hash_mask;

	internal int hash_shift;

	internal int block_start;

	private Config config;

	internal int match_length;

	internal int prev_match;

	internal int match_available;

	internal int strstart;

	internal int match_start;

	internal int lookahead;

	internal int prev_length;

	internal CompressionLevel compressionLevel;

	internal CompressionStrategy compressionStrategy;

	internal short[] dyn_ltree;

	internal short[] dyn_dtree;

	internal short[] bl_tree;

	internal Tree treeLiterals;

	internal Tree treeDistances;

	internal Tree treeBitLengths;

	internal short[] bl_count;

	internal int[] heap;

	internal int heap_len;

	internal int heap_max;

	internal sbyte[] depth;

	internal int _lengthOffset;

	internal int lit_bufsize;

	internal int last_lit;

	internal int _distanceOffset;

	internal int opt_len;

	internal int static_len;

	internal int matches;

	internal int last_eob_len;

	internal short bi_buf;

	internal int bi_valid;

	private bool Rfc1950BytesEmitted;

	private bool _WantRfc1950HeaderBytes;

	internal bool WantRfc1950HeaderBytes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal DeflateManager()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _InitializeLazyMatch()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _InitializeTreeData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _InitializeBlocks()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void pqdownheap(short[] tree, int k)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void scan_tree(short[] tree, int max_code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int build_bl_tree()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void send_all_trees(int lcodes, int dcodes, int blcodes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void send_tree(short[] tree, int max_code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void put_bytes(byte[] p, int start, int len)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void send_code(int c, short[] tree)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void send_bits(int value, int length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _tr_align()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool _tr_tally(int dist, int lc)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void send_compressed_block(short[] ltree, short[] dtree)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void set_data_type()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void bi_flush()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void bi_windup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void copy_block(int buf, int len, bool header)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void flush_block_only(bool eof)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal BlockState DeflateNone(FlushType flush)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _tr_stored_block(int buf, int stored_len, bool eof)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _tr_flush_block(int buf, int stored_len, bool eof)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _fillWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal BlockState DeflateFast(FlushType flush)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal BlockState DeflateSlow(FlushType flush)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int longest_match(int cur_match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Initialize(ZlibCodec codec, CompressionLevel level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int End()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDeflater()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int SetDictionary(byte[] dictionary)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Deflate(FlushType flush)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
