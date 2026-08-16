using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Ionic.Crc;

public class CrcCalculatorStream : Stream, IDisposable
{
	private static readonly long UnsetLengthLimit;

	internal Stream _innerStream;

	private CRC32 _Crc32;

	private long _lengthLimit;

	private bool _leaveOpen;

	public long TotalBytesSlurped
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int Crc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool LeaveOpen
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

	public override bool CanRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool CanSeek
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool CanWrite
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override long Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override long Position
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
	public CrcCalculatorStream(Stream stream)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrcCalculatorStream(Stream stream, bool leaveOpen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrcCalculatorStream(Stream stream, long length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int Read(byte[] buffer, int offset, int count)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Flush()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override long Seek(long offset, SeekOrigin origin)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLength(long value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IDisposable.Dispose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Close()
	{
	}
}
