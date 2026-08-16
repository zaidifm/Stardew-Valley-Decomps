using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.SpecialOrders.Objectives;

public class ReachMineFloorObjective : OrderObjective
{
	public NetBool skullCave;

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
	public virtual void OnNewValue(Farmer who, int new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReachMineFloorObjective()
	{
	}
}
