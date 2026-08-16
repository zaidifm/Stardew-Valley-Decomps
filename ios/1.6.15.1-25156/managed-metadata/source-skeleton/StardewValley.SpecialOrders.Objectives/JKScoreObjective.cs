using System.Runtime.CompilerServices;

namespace StardewValley.SpecialOrders.Objectives;

public class JKScoreObjective : OrderObjective
{
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
	public JKScoreObjective()
	{
	}
}
