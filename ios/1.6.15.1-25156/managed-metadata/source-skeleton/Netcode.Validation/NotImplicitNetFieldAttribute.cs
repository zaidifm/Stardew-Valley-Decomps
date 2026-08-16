using System;
using System.Runtime.CompilerServices;

namespace Netcode.Validation;

[AttributeUsage(AttributeTargets.Class)]
public class NotImplicitNetFieldAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NotImplicitNetFieldAttribute()
	{
	}
}
