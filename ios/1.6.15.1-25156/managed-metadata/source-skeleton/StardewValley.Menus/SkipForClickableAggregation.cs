using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Menus;

[AttributeUsage(AttributeTargets.Field)]
public class SkipForClickableAggregation : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkipForClickableAggregation()
	{
	}
}
