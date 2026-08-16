using System;

namespace StardewValley.Network;

public interface IHookableClient
{
	Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage { get; set; }

	Action<OutgoingMessage, Action<OutgoingMessage>, Action> OnSendingMessage { get; set; }
}
