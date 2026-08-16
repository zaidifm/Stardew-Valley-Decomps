using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley;

public class LoggingBinaryWriter : BinaryWriter, ILoggingWriter
{
	protected BinaryWriter writer;

	protected List<KeyValuePair<string, long>> stack;

	public override Stream BaseStream
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoggingBinaryWriter(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string currentPath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Push(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Pop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Close()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Flush()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override long Seek(int offset, SeekOrigin origin)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(short value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(ushort value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(uint value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(long value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(ulong value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(float value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(decimal value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(byte value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(sbyte value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(byte[] buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(byte[] buffer, int index, int count)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(char ch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(char[] chars)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(char[] chars, int index, int count)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(double value)
	{
	}
}
