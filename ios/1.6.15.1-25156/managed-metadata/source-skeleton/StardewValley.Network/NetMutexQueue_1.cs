using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Network;

public class NetMutexQueue<T> : INetObject<NetFields>
{
	private readonly NetLongDictionary<bool, NetBool> requests;

	private readonly NetLong currentOwner;

	private readonly List<T> localJobs;

	[XmlIgnore]
	public Action<T> Processor;

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
	public NetMutexQueue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T job)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(T job)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(GameLocation location)
	{
	}
}
