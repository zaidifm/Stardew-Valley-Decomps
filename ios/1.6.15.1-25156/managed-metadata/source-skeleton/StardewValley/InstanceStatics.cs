using System;
using System.Runtime.CompilerServices;

namespace StardewValley;

[AttributeUsage(AttributeTargets.Class)]
public class InstanceStatics : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public InstanceStatics()
	{
	}
}
