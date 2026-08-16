using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetObjectList<T> : NetList<T, NetRef<T>> where T : class, INetObject<INetSerializable>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetObjectList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetObjectList(IEnumerable<T> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetObjectList(int capacity)
	{
	}
}
