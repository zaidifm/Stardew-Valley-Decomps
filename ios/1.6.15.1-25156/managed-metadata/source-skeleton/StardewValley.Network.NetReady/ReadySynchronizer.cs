using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.Network.NetReady.Internal;

namespace StardewValley.Network.NetReady;

public class ReadySynchronizer
{
	private readonly Dictionary<string, BaseReadyCheck> ReadyChecks;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLocalRequiredFarmers(string id, List<Farmer> requiredFarmers)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLocalReady(string id, bool ready)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsReady(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsReadyCheckCancelable(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetNumberReady(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetNumberRequired(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMessage(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BaseReadyCheck GetIfExists(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BaseReadyCheck GetOrCreate(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadySynchronizer()
	{
	}
}
