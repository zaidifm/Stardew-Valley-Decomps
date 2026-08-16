using System;
using System.Runtime.CompilerServices;

namespace StardewValley;

[AttributeUsage(AttributeTargets.Field)]
public class NonInstancedStatic : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NonInstancedStatic()
	{
	}
}
