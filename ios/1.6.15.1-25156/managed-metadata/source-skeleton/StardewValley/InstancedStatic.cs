using System;
using System.Runtime.CompilerServices;

namespace StardewValley;

[AttributeUsage(AttributeTargets.Field)]
public class InstancedStatic : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public InstancedStatic()
	{
	}
}
