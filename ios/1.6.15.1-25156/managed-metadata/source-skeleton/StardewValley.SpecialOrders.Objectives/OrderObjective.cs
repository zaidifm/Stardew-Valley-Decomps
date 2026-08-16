using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.SpecialOrders.Objectives;

[XmlInclude(typeof(ReachMineFloorObjective))]
[XmlInclude(typeof(JKScoreObjective))]
[XmlInclude(typeof(GiftObjective))]
[XmlInclude(typeof(FishObjective))]
[XmlInclude(typeof(ShipObjective))]
[XmlInclude(typeof(DeliverObjective))]
[XmlInclude(typeof(CollectObjective))]
[XmlInclude(typeof(DonateObjective))]
[XmlInclude(typeof(SlayObjective))]
public class OrderObjective : INetObject<NetFields>
{
	[XmlIgnore]
	protected SpecialOrder _order;

	[XmlElement("currentCount")]
	public NetIntDelta currentCount;

	[XmlElement("maxCount")]
	public NetInt maxCount;

	[XmlElement("description")]
	public NetString description;

	[XmlIgnore]
	protected bool _complete;

	[XmlIgnore]
	protected bool _registered;

	[XmlElement("failOnCompletion")]
	public NetBool failOnCompletion;

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
	public OrderObjective()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFail()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnCurrentCountChanged(NetIntDelta field, int oldValue, int newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Register(SpecialOrder new_order)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _Register()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Unregister()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _Unregister()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldShowProgress()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void IncrementCount(int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetCount(int new_count)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCompletion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CheckCompletion(bool play_sound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsComplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanUncomplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanComplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Load(SpecialOrder order, Dictionary<string, string> data)
	{
	}
}
