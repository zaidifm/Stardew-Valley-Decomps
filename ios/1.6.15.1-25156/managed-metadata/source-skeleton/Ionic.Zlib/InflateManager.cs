using System.Runtime.CompilerServices;

namespace Ionic.Zlib;

internal sealed class InflateManager
{
	private enum InflateManagerMode
	{
		METHOD,
		FLAG,
		DICT4,
		DICT3,
		DICT2,
		DICT1,
		DICT0,
		BLOCKS,
		CHECK4,
		CHECK3,
		CHECK2,
		CHECK1,
		DONE,
		BAD
	}

	private const int PRESET_DICT = 32;

	private const int Z_DEFLATED = 8;

	private InflateManagerMode mode;

	internal ZlibCodec _codec;

	internal int method;

	internal uint computedCheck;

	internal uint expectedCheck;

	internal int marker;

	private bool _handleRfc1950HeaderBytes;

	internal int wbits;

	internal InflateBlocks blocks;

	private static readonly byte[] mark;

	internal bool HandleRfc1950HeaderBytes
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
	public InflateManager()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InflateManager(bool expectRfc1950HeaderBytes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Reset()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int End()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Initialize(ZlibCodec codec, int w)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Inflate(FlushType flush)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int SetDictionary(byte[] dictionary)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int Sync()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int SyncPoint(ZlibCodec z)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
