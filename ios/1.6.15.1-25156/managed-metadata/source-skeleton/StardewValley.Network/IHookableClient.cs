using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public interface IHookableClient
{
	Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	Action<OutgoingMessage, Action<OutgoingMessage>, Action> OnSendingMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}
}
