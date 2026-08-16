using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Quests;

public class NetDescriptionElementList : NetList<DescriptionElement, NetDescriptionElementRef>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDescriptionElementList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDescriptionElementList(IEnumerable<DescriptionElement> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDescriptionElementList(int capacity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string key)
	{
	}
}
