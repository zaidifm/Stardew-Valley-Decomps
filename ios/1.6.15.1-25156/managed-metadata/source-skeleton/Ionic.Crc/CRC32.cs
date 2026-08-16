using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Ionic.Crc;

[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class CRC32
{
	private uint dwPolynomial;

	private long _TotalBytesRead;

	private bool reverseBits;

	private uint[] crc32Table;

	private const int BUFFER_SIZE = 8192;

	private uint _register;

	public long TotalBytesRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int Crc32Result
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCrc32(Stream input)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCrc32AndCopy(Stream input, Stream output)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ComputeCrc32(int W, byte B)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int _InternalComputeCrc32(uint W, byte B)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SlurpBlock(byte[] block, int offset, int count)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCRC(byte b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCRC(byte b, int n)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint ReverseBits(uint data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte ReverseBits(byte data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateLookupTable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private uint gf2_matrix_times(uint[] matrix, uint vec)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gf2_matrix_square(uint[] square, uint[] mat)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Combine(int crc, int length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CRC32()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CRC32(bool reverseBits)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CRC32(int polynomial, bool reverseBits)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
	}
}
