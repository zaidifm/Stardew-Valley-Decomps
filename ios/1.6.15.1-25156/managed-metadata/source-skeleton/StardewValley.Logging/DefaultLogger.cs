using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace StardewValley.Logging;

internal class DefaultLogger : IGameLogger
{
	private readonly StringBuilder MessageBuilder;

	private string _LogPath;

	private bool StartedLogFile;

	private string LogPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool ShouldWriteToConsole
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool ShouldWriteToLogFile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DefaultLogger(bool shouldWriteToConsole, bool shouldWriteToLogFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Verbose(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Debug(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Info(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Warn(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Error(string error, Exception exception)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteMessageToFile(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogImpl(string level, string message, Exception exception = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string FormatLog(string level, string text, Exception exception = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
