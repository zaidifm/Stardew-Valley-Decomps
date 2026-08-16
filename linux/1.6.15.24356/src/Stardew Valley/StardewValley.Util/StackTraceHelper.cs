using System;
using System.Diagnostics;

namespace StardewValley.Util;

public class StackTraceHelper
{
	private object _StackTrace;

	public static string StackTrace => Environment.StackTrace;

	public int FrameCount => (_StackTrace as StackTrace)?.FrameCount ?? 0;

	public static string FromException(Exception ex)
	{
		return ex?.StackTrace ?? "";
	}

	public StackTraceHelper()
	{
		_StackTrace = new StackTrace();
	}

	public StackFrame GetFrame(int index)
	{
		return (_StackTrace as StackTrace)?.GetFrame(index);
	}

	public StackFrame[] GetFrames()
	{
		return (_StackTrace as StackTrace)?.GetFrames() ?? LegacyShims.EmptyArray<StackFrame>();
	}

	public new string ToString()
	{
		return (_StackTrace as StackTrace)?.ToString() ?? "";
	}
}
