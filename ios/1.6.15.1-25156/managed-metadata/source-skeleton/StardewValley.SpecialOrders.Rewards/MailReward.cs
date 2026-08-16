using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.SpecialOrders.Rewards;

public class MailReward : OrderReward
{
	public NetBool noLetter;

	public NetStringList grantedMails;

	public NetBool host;

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
	public MailReward()
	{
	}
}
