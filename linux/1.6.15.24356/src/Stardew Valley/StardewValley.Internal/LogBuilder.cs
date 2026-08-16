using System;
using System.Text;

namespace StardewValley.Internal;

public class LogBuilder
{
	public readonly StringBuilder Log;

	public readonly int Indent;

	public LogBuilder(int indent = 0)
		: this(new StringBuilder(), indent)
	{
	}

	public LogBuilder(StringBuilder log, int indent = 0)
	{
		Log = log ?? throw new ArgumentNullException("log");
		Indent = indent;
	}

	public void AppendLine()
	{
		Log.AppendLine();
	}

	public void AppendLine(string message)
	{
		if (Indent > 0 && message.Length > 0)
		{
			message = message.PadLeft(message.Length + Indent, ' ');
		}
		Log.AppendLine(message);
	}

	public LogBuilder GetIndentedLog(int indent = 3)
	{
		return new LogBuilder(Log, Indent + indent);
	}
}
