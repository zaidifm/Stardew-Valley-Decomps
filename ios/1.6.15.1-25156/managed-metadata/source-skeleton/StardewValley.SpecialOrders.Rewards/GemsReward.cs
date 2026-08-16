using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.SpecialOrders.Rewards;

public class GemsReward : OrderReward
{
	public NetInt amount;

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
	public GemsReward()
	{
	}
}
