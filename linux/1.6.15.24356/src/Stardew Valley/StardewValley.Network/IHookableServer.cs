using System;

namespace StardewValley.Network;

public interface IHookableServer
{
	Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage { get; set; }
}
