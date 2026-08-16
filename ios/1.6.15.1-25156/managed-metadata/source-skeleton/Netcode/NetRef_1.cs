using System.Runtime.CompilerServices;

namespace Netcode;

public class NetRef<T> : NetExtendableRef<T, NetRef<T>> where T : class, INetObject<INetSerializable>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRef()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRef(T value)
	{
	}
}
