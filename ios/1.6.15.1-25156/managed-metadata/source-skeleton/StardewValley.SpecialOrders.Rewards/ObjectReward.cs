using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;
using Netcode.Validation;

namespace StardewValley.SpecialOrders.Rewards;

public class ObjectReward : OrderReward
{
	public readonly NetString itemKey;

	public readonly NetInt amount;

	[NotNetField]
	private Object _objectInstance;

	public Object objectInstance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Load(SpecialOrder order, Dictionary<string, string> data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Grant()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ObjectReward()
	{
	}
}
