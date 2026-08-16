using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.SpecialOrders.Objectives;

public class GiftObjective : OrderObjective
{
	public enum LikeLevels
	{
		None,
		Hated,
		Disliked,
		Neutral,
		Liked,
		Loved
	}

	[XmlElement("acceptableContextTagSets")]
	public NetStringList acceptableContextTagSets;

	[XmlElement("minimumLikeLevel")]
	public NetEnum<LikeLevels> minimumLikeLevel;

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
	public virtual void OnGiftGiven(Farmer farmer, NPC npc, Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftObjective()
	{
	}
}
