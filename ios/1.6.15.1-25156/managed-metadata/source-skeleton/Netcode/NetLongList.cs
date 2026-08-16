using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetLongList : NetList<long, NetLong>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLongList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLongList(IEnumerable<long> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLongList(int capacity)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Contains(long item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int IndexOf(long item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
