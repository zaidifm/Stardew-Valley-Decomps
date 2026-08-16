using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public abstract class HookableClient : Client, IHookableClient
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

	public Action<OutgoingMessage, Action<OutgoingMessage>, Action> OnSendingMessage
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
	public HookableClient()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClientProcessingMessage(IncomingMessage message, Action<OutgoingMessage> sendMessage, Action resume)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClientSendingMessage(OutgoingMessage message, Action<OutgoingMessage> sendMessage, Action resume)
	{
	}
}
