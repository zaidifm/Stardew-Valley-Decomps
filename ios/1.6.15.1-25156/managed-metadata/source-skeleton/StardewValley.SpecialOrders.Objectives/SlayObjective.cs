using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;
using StardewValley.Monsters;

namespace StardewValley.SpecialOrders.Objectives;

public class SlayObjective : OrderObjective
{
	[XmlElement("targetNames")]
	public NetStringList targetNames;

	[XmlElement("ignoreFarmMonsters")]
	public NetBool ignoreFarmMonsters;

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
	public virtual void OnMonsterSlain(Farmer farmer, Monster monster)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SlayObjective()
	{
	}
}
