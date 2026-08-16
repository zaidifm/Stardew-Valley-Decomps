using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public interface IHookableServer
{
	Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}
}
