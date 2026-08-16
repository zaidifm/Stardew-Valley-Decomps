using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.SpecialOrders.Rewards;

[XmlInclude(typeof(ObjectReward))]
[XmlInclude(typeof(FriendshipReward))]
[XmlInclude(typeof(GemsReward))]
[XmlInclude(typeof(MailReward))]
[XmlInclude(typeof(MoneyReward))]
[XmlInclude(typeof(ResetEventReward))]
public class OrderReward : INetObject<NetFields>
{
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
	public OrderReward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Grant()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Load(SpecialOrder order, Dictionary<string, string> data)
	{
	}
}
