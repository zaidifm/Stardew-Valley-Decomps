using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Characters;

[Obsolete("All dogs now use the Pet class.")]
public class Dog : Pet
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dog()
	{
	}
}
