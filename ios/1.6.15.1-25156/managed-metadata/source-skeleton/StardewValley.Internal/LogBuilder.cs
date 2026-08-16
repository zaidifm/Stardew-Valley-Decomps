using System.Runtime.CompilerServices;
using System.Text;

namespace StardewValley.Internal;

public class LogBuilder
{
	public readonly StringBuilder Log;

	public readonly int Indent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LogBuilder(int indent = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LogBuilder(StringBuilder log, int indent = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AppendLine()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AppendLine(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LogBuilder GetIndentedLog(int indent = 3)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
