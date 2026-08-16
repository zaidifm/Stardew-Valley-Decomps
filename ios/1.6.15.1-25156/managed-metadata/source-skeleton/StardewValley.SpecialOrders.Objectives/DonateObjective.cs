using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.SpecialOrders.Objectives;

public class DonateObjective : OrderObjective
{
	[XmlElement("dropBox")]
	public NetString dropBox;

	[XmlElement("dropBoxGameLocation")]
	public NetString dropBoxGameLocation;

	[XmlElement("dropBoxTileLocation")]
	public NetVector2 dropBoxTileLocation;

	[XmlElement("acceptableContextTagSets")]
	public NetStringList acceptableContextTagSets;

	[XmlElement("minimumCapacity")]
	public NetInt minimumCapacity;

	[XmlElement("confirmed")]
	public NetBool confirmed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetDropboxLocationName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Load(SpecialOrder order, Dictionary<string, string> data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAcceptCount(Item item, int stack_count)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCompletion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanComplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Confirm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanUncomplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnConfirmed(NetBool field, bool oldValue, bool newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsValidItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DonateObjective()
	{
	}
}
