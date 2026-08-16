using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Quests;

public class NetDescriptionElementRef : NetExtendableRef<DescriptionElement, NetDescriptionElementRef>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDescriptionElementRef()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDescriptionElementRef(DescriptionElement value)
	{
	}
}
