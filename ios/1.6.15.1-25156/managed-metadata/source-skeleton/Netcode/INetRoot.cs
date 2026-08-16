using System.Runtime.CompilerServices;

namespace Netcode;

public interface INetRoot
{
	NetClock Clock
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void TickTree();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Disconnect(long connection);
}
