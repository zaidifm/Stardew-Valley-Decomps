using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Logging;

public interface IGameLogger
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	void Verbose(string message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Debug(string message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Info(string message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Warn(string message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Error(string error, Exception exception = null);
}
