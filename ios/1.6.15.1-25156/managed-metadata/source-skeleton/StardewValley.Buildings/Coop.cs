using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Buildings;

[Obsolete("The Coop class is only used to preserve data from old save files. All coops were converted into plain Building instances based on the rules in Data/Buildings.")]
public class Coop : Building
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Coop()
	{
	}
}
