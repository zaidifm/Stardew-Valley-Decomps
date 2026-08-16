using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Internal;

[AttributeUsage(AttributeTargets.Method)]
public class OtherNamesAttribute : Attribute
{
	public string[] Aliases
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OtherNamesAttribute(params string[] aliases)
	{
	}
}
