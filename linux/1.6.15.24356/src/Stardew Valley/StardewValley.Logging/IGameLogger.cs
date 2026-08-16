using System;

namespace StardewValley.Logging;

public interface IGameLogger
{
	void Verbose(string message);

	void Debug(string message);

	void Info(string message);

	void Warn(string message);

	void Error(string error, Exception exception = null);
}
