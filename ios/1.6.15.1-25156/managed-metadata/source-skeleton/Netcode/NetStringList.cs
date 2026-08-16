using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetStringList : NetList<string, NetString>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetStringList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetStringList(IEnumerable<string> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetStringList(int capacity)
	{
	}
}
