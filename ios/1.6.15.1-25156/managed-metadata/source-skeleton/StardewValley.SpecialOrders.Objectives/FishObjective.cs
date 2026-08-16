using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.SpecialOrders.Objectives;

public class FishObjective : OrderObjective
{
	[XmlElement("acceptableContextTagSets")]
	public NetStringList acceptableContextTagSets;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Load(SpecialOrder order, Dictionary<string, string> data)
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
	public virtual void OnFishCaught(Farmer farmer, Item fish_item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishObjective()
	{
	}
}
