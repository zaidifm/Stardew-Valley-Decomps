using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public class NetFarmerRoot : NetRoot<Farmer>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFarmerRoot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFarmerRoot(Farmer value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override NetRoot<Farmer> Clone()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
