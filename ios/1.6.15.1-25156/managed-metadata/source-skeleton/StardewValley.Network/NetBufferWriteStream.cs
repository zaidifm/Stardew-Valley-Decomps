using System.IO;
using System.Runtime.CompilerServices;
using Lidgren.Network;

namespace StardewValley.Network;

public class NetBufferWriteStream : Stream
{
	private int offset;

	public NetBuffer Buffer;

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
	public NetBufferWriteStream(NetBuffer buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Flush()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int Read(byte[] buffer, int offset, int count)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public override void Write(byte[] buffer, int offset, int count)
	{
	}
}
