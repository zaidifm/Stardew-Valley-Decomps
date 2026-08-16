using System.Runtime.CompilerServices;

namespace rail;

public interface IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	ulong GetComponentVersion();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Release();
}
