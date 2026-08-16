using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.SpecialOrders.Objectives;

public class ShipObjective : OrderObjective
{
	[XmlElement("acceptableContextTagSets")]
	public NetStringList acceptableContextTagSets;

	[XmlElement("useShipmentValue")]
	public NetBool useShipmentValue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Load(SpecialOrder order, Dictionary<string, string> data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _Register()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _Unregister()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnItemShipped(Farmer farmer, Item item, int shipped_price)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShipObjective()
	{
	}
}
