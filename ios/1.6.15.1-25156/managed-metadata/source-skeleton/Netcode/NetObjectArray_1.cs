using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetObjectArray<T> : NetArray<T, NetRef<T>> where T : class, INetObject<INetSerializable>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetObjectArray()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetObjectArray(IEnumerable<T> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetObjectArray(int size)
	{
	}
}
