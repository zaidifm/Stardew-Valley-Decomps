using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.SpecialOrders.Rewards;

public class ResetEventReward : OrderReward
{
	[XmlArrayItem("int")]
	public NetStringList resetEvents;

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
	public ResetEventReward()
	{
	}
}
