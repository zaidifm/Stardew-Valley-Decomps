using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.NetReady.Internal;

internal sealed class ClientReadyCheck : BaseReadyCheck
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientReadyCheck(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetRequiredFarmers(List<long> farmerIds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool SetLocalReady(bool ready)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ProcessMessage(ReadyCheckMessageType messageType, IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SendMessage(ReadyCheckMessageType messageType, params object[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessLock(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessRelease(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessUpdateAmounts(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessFinish(IncomingMessage message)
	{
	}
}
