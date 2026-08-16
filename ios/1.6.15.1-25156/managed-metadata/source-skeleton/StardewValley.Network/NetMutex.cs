using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Network;

public class NetMutex : INetObject<NetFields>
{
	public const long NoOwner = -1L;

	private long prevOwner;

	private readonly NetLong owner;

	private readonly NetEvent1Field<long, NetLong> lockRequest;

	private Action onLockAcquired;

	private Action onLockFailed;

	[XmlIgnore]
	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetMutex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestLock(Action acquired = null, Action failed = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseLock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLocked()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLockHeld()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(FarmerCollection farmers)
	{
	}
}
