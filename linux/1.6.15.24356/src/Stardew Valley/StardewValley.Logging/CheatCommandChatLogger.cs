using System;
using Microsoft.Xna.Framework;
using StardewValley.Menus;

namespace StardewValley.Logging;

public class CheatCommandChatLogger : IGameLogger
{
	private readonly ChatBox ChatBox;

	public CheatCommandChatLogger(ChatBox chatBox)
	{
		ChatBox = chatBox;
	}

	public void Verbose(string message)
	{
		Game1.log.Verbose(message);
	}

	public void Debug(string message)
	{
		ChatBox.addMessage(message, Color.Gray);
		Game1.log.Debug(message);
	}

	public void Info(string message)
	{
		ChatBox.addInfoMessage(message);
		Game1.log.Info(message);
	}

	public void Warn(string message)
	{
		ChatBox.addErrorMessage(message);
		Game1.log.Warn("[Warn] " + message);
	}

	public void Error(string error, Exception exception = null)
	{
		string text = "[Error] " + error;
		if (exception != null)
		{
			text = text + ": " + exception.Message;
		}
		ChatBox.addErrorMessage(text);
		Game1.log.Error(error, exception);
	}
}
