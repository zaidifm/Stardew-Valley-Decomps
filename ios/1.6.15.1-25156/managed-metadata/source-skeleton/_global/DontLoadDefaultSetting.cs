using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class DontLoadDefaultSetting : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DontLoadDefaultSetting()
	{
	}
}
