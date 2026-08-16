using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.NetReady.Internal;

internal sealed class ServerReadyCheck : BaseReadyCheck
{
	private readonly Dictionary<long, ReadyState> ReadyStates;

	private bool Locking;

	private readonly HashSet<long> RequiredFarmers;

	private bool IncludesAll
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerReadyCheck(string id)
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
	private void ProcessReady(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessCancel(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessAcceptLock(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessRejectLock(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessRequireFarmers(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequireFarmers(ICollection<long> farmerIds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsFarmerRequired(long uid)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
