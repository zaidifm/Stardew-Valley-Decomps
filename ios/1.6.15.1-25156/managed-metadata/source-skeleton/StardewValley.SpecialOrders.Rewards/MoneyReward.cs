using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.SpecialOrders.Rewards;

public class MoneyReward : OrderReward
{
	public NetInt amount;

	public NetFloat multiplier;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetRewardMoneyAmount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Load(SpecialOrder order, Dictionary<string, string> data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MoneyReward()
	{
	}
}
