using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public abstract class HookableServer : Server, IHookableServer
{
	public Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HookableServer(IGameServer gameServer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnServerProcessingMessage(IncomingMessage message, Action<OutgoingMessage> sendMessage, Action resume)
	{
	}
}
