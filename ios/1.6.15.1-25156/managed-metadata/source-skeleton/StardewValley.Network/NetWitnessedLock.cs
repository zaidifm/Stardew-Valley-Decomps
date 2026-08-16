using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Network;

public class NetWitnessedLock : INetObject<NetFields>
{
	private readonly NetBool requested;

	private readonly NetFarmerCollection witnesses;

	private Action acquired;

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
	public NetWitnessedLock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestLock(Action acquired, Action failed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLocked()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}
}
