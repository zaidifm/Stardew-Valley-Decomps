using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Characters;

[Obsolete("All cats now use the Pet class.")]
public class Cat : Pet
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cat()
	{
	}
}
