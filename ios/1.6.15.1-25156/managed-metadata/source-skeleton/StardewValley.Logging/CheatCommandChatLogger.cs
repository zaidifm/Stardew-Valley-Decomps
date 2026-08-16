using System;
using System.Runtime.CompilerServices;
using StardewValley.Menus;

namespace StardewValley.Logging;

public class CheatCommandChatLogger : IGameLogger
{
	private readonly ChatBox ChatBox;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CheatCommandChatLogger(ChatBox chatBox)
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
	public void Error(string error, Exception exception = null)
	{
	}
}
