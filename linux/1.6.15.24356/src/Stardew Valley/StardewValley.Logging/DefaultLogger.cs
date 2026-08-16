using System;
using System.IO;
using System.Text;

namespace StardewValley.Logging;

internal class DefaultLogger : IGameLogger
{
	private readonly StringBuilder MessageBuilder = new StringBuilder();

	private string _LogPath;

	private bool StartedLogFile;

	private string LogPath
	{
		get
		{
			if (_LogPath == null)
			{
				_LogPath = Program.GetDebugLogPath();
			}
			return _LogPath;
		}
	}

	public bool ShouldWriteToConsole { get; }

	public bool ShouldWriteToLogFile { get; }

	public DefaultLogger(bool shouldWriteToConsole, bool shouldWriteToLogFile)
	{
		ShouldWriteToConsole = shouldWriteToConsole;
		ShouldWriteToLogFile = shouldWriteToLogFile;
		if (shouldWriteToLogFile)
		{
			WriteMessageToFile("");
		}
	}

	public void Verbose(string message)
	{
		LogImpl("Verbose", message);
	}

	public void Debug(string message)
	{
		LogImpl("Debug", message);
	}

	public void Info(string message)
	{
		LogImpl("Info", message);
	}

	public void Warn(string message)
	{
		LogImpl("Warn", message);
	}

	public void Error(string error, Exception exception)
	{
		LogImpl("Error", error, exception);
	}

	private void WriteMessageToFile(string message)
	{
		if (LogPath == null)
		{
			return;
		}
		if (!StartedLogFile)
		{
			File.WriteAllText(LogPath, message);
			StartedLogFile = true;
			Game1.log.Verbose($"Starting log file at {DateTime.Now:yyyy-MM-dd HH:mm:ii}.");
			return;
		}
		try
		{
			File.AppendAllText(LogPath, message);
		}
		catch (Exception value)
		{
			if (ShouldWriteToConsole)
			{
				Console.WriteLine($"Failed writing to log file:\n{value}");
			}
		}
	}

	private void LogImpl(string level, string message, Exception exception = null)
	{
		bool shouldWriteToConsole = ShouldWriteToConsole;
		bool shouldWriteToLogFile = ShouldWriteToLogFile;
		if (shouldWriteToConsole | shouldWriteToLogFile)
		{
			message = FormatLog(level, message, exception);
			if (shouldWriteToConsole)
			{
				Console.WriteLine(message);
			}
			if (shouldWriteToLogFile)
			{
				WriteMessageToFile(message);
			}
		}
	}

	private string FormatLog(string level, string text, Exception exception = null)
	{
		StringBuilder messageBuilder = MessageBuilder;
		try
		{
			int num = Game1.game1?.instanceId ?? 0;
			StringBuilder stringBuilder = messageBuilder.Append('[');
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder);
			handler.AppendFormatted(DateTime.Now, "HH:mm:ss");
			handler.AppendLiteral(" ");
			stringBuilder.Append(ref handler).Append(level).Append(' ')
				.Append((num == 0) ? "game" : $"screen{num}")
				.Append("] ")
				.Append(text)
				.AppendLine();
			if (exception != null)
			{
				messageBuilder.Append(exception).AppendLine();
			}
			return messageBuilder.ToString();
		}
		finally
		{
			messageBuilder.Clear();
		}
	}
}
