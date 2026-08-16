using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Network;

namespace StardewValley;

public abstract class NetSynchronizer
{
	private const byte MessageTypeVar = 0;

	private const byte MessageTypeBarrier = 1;

	private Dictionary<string, INetObject<INetSerializable>> variables;

	private Dictionary<string, HashSet<long>> barriers;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HashSet<long> barrierPlayers(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool barrierReady(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool shouldAbort()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void barrier(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBarrierReady(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isVarReady(string varName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T waitForVar<TField, T>(string varName) where TField : NetFieldBase<T, TField>, new()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendVar<TField, T>(string varName, T value) where TField : NetFieldBase<T, TField>, new()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasVar(string varName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void processMessages();

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void sendMessage(params object[] data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveMessage(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected NetSynchronizer()
	{
	}
}
