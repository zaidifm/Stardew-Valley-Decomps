using System;
using System.Runtime.CompilerServices;

namespace Netcode.Validation;

[AttributeUsage(AttributeTargets.Field)]
public class NotNetFieldAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NotNetFieldAttribute()
	{
	}
}
