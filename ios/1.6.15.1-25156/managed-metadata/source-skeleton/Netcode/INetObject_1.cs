using System.Runtime.CompilerServices;

namespace Netcode;

public interface INetObject<out T> where T : INetSerializable
{
	T NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}
}
