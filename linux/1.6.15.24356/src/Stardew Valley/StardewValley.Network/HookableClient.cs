using System;

namespace StardewValley.Network;

public abstract class HookableClient : Client, IHookableClient
{
	public Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage { get; set; }

	public Action<OutgoingMessage, Action<OutgoingMessage>, Action> OnSendingMessage { get; set; }

	public HookableClient()
	{
		OnProcessingMessage = OnClientProcessingMessage;
		OnSendingMessage = OnClientSendingMessage;
	}

	private void OnClientProcessingMessage(IncomingMessage message, Action<OutgoingMessage> sendMessage, Action resume)
	{
		resume();
	}

	private void OnClientSendingMessage(OutgoingMessage message, Action<OutgoingMessage> sendMessage, Action resume)
	{
		resume();
	}
}
