using System;

namespace StardewValley.Network;

public abstract class HookableServer : Server, IHookableServer
{
	public Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage { get; set; }

	public HookableServer(IGameServer gameServer)
		: base(gameServer)
	{
		OnProcessingMessage = OnServerProcessingMessage;
	}

	private void OnServerProcessingMessage(IncomingMessage message, Action<OutgoingMessage> sendMessage, Action resume)
	{
		resume();
	}
}
