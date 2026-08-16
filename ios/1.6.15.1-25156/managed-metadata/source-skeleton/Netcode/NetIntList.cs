using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetIntList : NetList<int, NetInt>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntList(IEnumerable<int> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntList(int capacity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Contains(int item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int IndexOf(int item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
